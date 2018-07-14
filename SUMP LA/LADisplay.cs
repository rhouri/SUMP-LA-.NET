using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Text;
using System.Windows.Forms;
namespace SUMPLA_net
    {
    public partial class LADisplay :UserControl
        {
        private bool aSampleValid;

        bool[] ChannelVisible;
        int[] ChannelLineup;

        public List<Sample> QS;
        private float[] Markers = new float[2];
        public DSSettings Channels = null;


        private Bitmap _backBuffer, labelBuffer;

        float DivisionWidth;
        decimal ZoomRate;
        int ScreenWidth;


        int Start;
        float PixelsPerTick; // screen pixels for each tick


        int TSpan; // tick time span



        int state_mouse = 0;
        float mouseStart, mouseCurrent, mouseCursor;


        int CDMouseDown = -1; // marker being moved by its handle


        public int NumChannels;
        private int VisibleChannelsCount = 32;
        public int VisibleChannelsMask
            {
            get;
            set;
            }

        [DefaultValue(1000)]
        public int SampleFrequency
            {
            get;
            set;
            }


        public bool SampleValid
            {
            set
                {
                if (QS.Count == 0)
                    {
                    aSampleValid = false;
                    return;
                    }
                aSampleValid = value;
                if (aSampleValid)
                    {
                    for (int i = 0 ; i < QS.Count ; i++)
                        QS[i].Ticks -= QS[0].Ticks; // normalize ( start at 0)

                    Sample S = new Sample();

                    S.Ticks = QS[QS.Count - 1].Ticks;
                    S.S8 = QS[QS.Count - 1].S8;
                    QS.Add(S);



                    TSpan = (int) (QS[QS.Count - 1].Ticks - QS[0].Ticks);
                    Start = trackBar1.Minimum = 0;
                    trackBar1.Maximum = (int) QS[QS.Count - 1].Ticks;
                    udZoomRate.Maximum = decimal.MaxValue;
                    udZoomRate.Value = 1;

                    Markers[0] = Markers[1] = -1;

                    NumChannels = Channels.tblChannels.Rows.Count;
                    InvalidatePictures();

                    }
                }
            get
                {
                return aSampleValid;
                }
            }




        public LADisplay ()
            {
            InitializeComponent();
            QS = new List<Sample>();

            Start = 0;
            trackBar1.Maximum = 0;
            // create the channels list
            ChannelVisible = new bool[512];
            ChannelLineup = new int[512];
            SampleFrequency = 1000000;
            }

        public void ChannelVisibility ()
            {
            VisibleChannelsMask = 0;

            for (int i = 0 ; i < Channels.tblChannels.Rows.Count ; i++)
                {
                ChannelVisible[i] = Channels.tblChannels[i].Visible;
                VisibleChannelsMask |= (int) (((Channels.tblChannels[i].Visible) ? 1 : 0) << i);

                }

            int j = 0;
            for (int i = 0 ; i < NumChannels ; i++)
                ChannelLineup[i] = 0;

            for (int i = 0 ; i < NumChannels ; i++)
                if (ChannelVisible[i])
                    ChannelLineup[j++] = i;

            VisibleChannelsCount = j;
            }



        int aTraceSeparation = 10;
        public int SeparationPercent
            {
            get
                {
                return aTraceSeparation;
                }
            set
                {
                aTraceSeparation = value;
                InvalidatePictures();
                }
            }

        private int aNumDivisions = 16;
        public int NumDivisions
            {
            set
                {
                aNumDivisions = value;
                InvalidatePictures();
                }
            get
                {
                return aNumDivisions;
                }
            }


        private Color aBackgroundColorEven = Color.White;
        public Color BackgroundColorEven
            {
            set
                {
                aBackgroundColorEven = value;
                InvalidatePictures();
                }
            get
                {
                return aBackgroundColorEven;
                }

            }

        private Color aBackgroundColorOdd = Color.Aqua;
        public Color BackgroundColorOdd
            {
            set
                {
                aBackgroundColorOdd = value;
                InvalidatePictures();
                }

            get
                {
                return aBackgroundColorOdd;
                }
            }

        private Color aForegroundColorEven = Color.Navy;
        public Color ForegroundColorEven
            {
            set
                {
                aForegroundColorEven = value;
                InvalidatePictures();
                }

            get
                {
                return aForegroundColorEven;
                }

            }

        private Color aForegroundColorOdd = Color.Navy;
        public Color ForegroundColorOdd
            {
            set
                {
                aForegroundColorOdd = value;
                InvalidatePictures();
                }
            get
                {
                return aForegroundColorOdd;
                }

            }


        public void AddSample ( uint ts, uint Smpl )
            {
            if (ts == int.MaxValue)
                ts = (uint) QS.Count;
            Sample s = new Sample();
            s.Ticks = ts;
            s.S8 = Smpl;
            QS.Add(s);
            }

        private int FindSampleIndex ( int t )
            {
            int i = 0;
            for (i = 0 ; i < QS.Count - 1 ; i++)
                {
                if (t >= QS[i].Ticks && t < QS[i + 1].Ticks)
                    return i;
                }
            return 0;
            }




        public void ClearSamples ()
            {
            QS.Clear();
            trackBar1.Maximum = 0;
            }


        private Color Dim ( Color C )
            {
            return Color.FromArgb((C.R - 50 > 0) ? C.R - 50 : 0
                                       , (C.G + 50 < 255) ? C.G + 50 : 255
                                       , (C.B - 50 > 0) ? C.B - 50 : 0);
            }





        // channel labels
        private void pictureBox1_Paint ( object sender, PaintEventArgs e )
            {
            ScreenWidth = LabelsDisplay.Width - 1;
            if (labelBuffer == null)
                {
                labelBuffer = new Bitmap(ScreenWidth, MainDisplay.Height);
                }
            SolidBrush bgBrushEven = new SolidBrush(aBackgroundColorEven);
            SolidBrush bgBrushOdd = new SolidBrush(aBackgroundColorOdd);
            if (SampleValid) // do we have the whole set?
                {
                ChannelVisibility();

                using (Graphics gfx = Graphics.FromImage(labelBuffer))
                    {
                    gfx.Clear(aBackgroundColorEven);

                    int h = (MainDisplay.Height - 10) / VisibleChannelsCount; //channel height

                    for (int l = 0 ; l < VisibleChannelsCount ; l++) // paint background
                        {
                        Rectangle R1 = new Rectangle(0, l * h + 10, ScreenWidth, h);
                        R1.Inflate(-1, -1);
                        if ((l % 2) == 0)
                            gfx.FillRectangle(bgBrushEven, R1);
                        else
                            gfx.FillRectangle(bgBrushOdd, R1);

                        R1.Inflate(1, 1);
                        gfx.DrawRectangle(Pens.Black, R1);
                        }




                    int j = 0;
                    for (int k = 0 ; k < VisibleChannelsCount ; k++) // for each channel
                        {
                        j = ChannelLineup[k];
                        int iy = h * (k) + (h / 4) + 10;
                        gfx.DrawString(Channels.tblChannels[j].Label, this.Font, Brushes.Wheat, new Point(0, iy));
                        }
                    }

                }
            else
                {
                using (Graphics gfx = Graphics.FromImage(labelBuffer))
                    {
                    gfx.Clear(aBackgroundColorEven);
                    }
                }
            e.Graphics.DrawImageUnscaled(labelBuffer, 0, 0);
            bgBrushEven.Dispose();
            bgBrushOdd.Dispose();
            }



        public void InvalidatePictures ()
            {
            LabelsDisplay.Invalidate();
            LabelsDisplay.Update();
            MainDisplay.Invalidate();
            MainDisplay.Update();
            }





        // main display   
        private void MainDisplay_Paint ( object sender, PaintEventArgs e )
            {
            ScreenWidth = MainDisplay.Width;

            PixelsPerTick = (((float) (ScreenWidth)) / (float) TSpan) * (float) udZoomRate.Value;

            if (_backBuffer == null)
                {
                _backBuffer = new Bitmap(ScreenWidth, MainDisplay.Height);
                }

            SolidBrush bgBrushEven = new SolidBrush(aBackgroundColorEven);
            SolidBrush bgBrushOdd = new SolidBrush(aBackgroundColorOdd);
            Pen PenHighEven = new Pen(new SolidBrush(aForegroundColorEven), 1);
            Pen PenLowEven = new Pen(new SolidBrush(Dim(aForegroundColorEven)), 1);
            Pen PenHighOdd = new Pen(new SolidBrush(aForegroundColorOdd), 1);
            Pen PenLowOdd = new Pen(new SolidBrush(Dim(aForegroundColorOdd)), 1);


            if (SampleValid) // do we have the whole set?
                {

                ChannelVisibility();

                // Ticks/Division
                ZoomRate = udZoomRate.Value;
                DivisionWidth = (ScreenWidth) / NumDivisions; // # of pixels per division



                using (Graphics gfx = Graphics.FromImage(_backBuffer))
                    {
                    gfx.Clear(aBackgroundColorEven);


                    float x = 0, y = 0, x1 = 0, Last_y = 0, Last_x = 0;

                    Sample s = null;


                    int h = (MainDisplay.Height - 10) / VisibleChannelsCount; //channel height

                    gfx.FillRectangle(Brushes.DarkSlateGray, 0, 0, ScreenWidth, 10);



                    for (int l = 0 ; l < VisibleChannelsCount ; l++) // paint background
                        {
                        if ((l % 2) == 0)
                            gfx.FillRectangle(bgBrushEven, 0, l * h + 10, ScreenWidth, h);
                        else
                            gfx.FillRectangle(bgBrushOdd, 0, l * h + 10, ScreenWidth, h);
                        }

                    // division starts @0
                    // depending on scale selected
                    // i.e if ms selected, 1st division would be at  NumDivisions ms
                    // Ticks count represents (time of event)/ sample frequency

                    //PixelsPerTick = # of pixels for one sample 
                    // on sample time=1/sample frequency;

                    double SamplePeriod = 1.0 / SampleFrequency; // sample time in seconds

                    double requestedDivPeriod = 1.0 / 1000.0;
                    if (rbnS.Checked)
                        requestedDivPeriod = 1.0 / 1000000000.0;
                    if (rbuS.Checked)
                        requestedDivPeriod = 1.0 / 1000000.0;

                    requestedDivPeriod = requestedDivPeriod / SamplePeriod;

                    requestedDivPeriod *= NumDivisions;


                    int divWidth = (int) (requestedDivPeriod * PixelsPerTick);


                    if (divWidth > 0)
                        for (int xdiv = 0 ; xdiv < MainDisplay.Width ;)
                            {
                            gfx.DrawLine(Pens.DarkSlateGray, xdiv, 0, xdiv, MainDisplay.Height);
                            xdiv += divWidth;
                            }

                    ////////////////////////
                    // Start drawing traces
                    ////////////////////////
                    gfx.SmoothingMode = SmoothingMode.HighQuality;

                    int j = 0;
                    for (int k = 0 ; k < VisibleChannelsCount ; k++) // for each channel
                        {
                        j = ChannelLineup[k]; // actual channel  to display


                        Pen TraceHigh = null; // which pen to use for the current trace. Will vary from odd to even
                        Pen TraceLow = null; // which pen to use for the current trace. Will vary from odd to even
                        Pen Trace = null;

                        if ((k % 2) == 0)
                            {
                            TraceHigh = PenHighEven;
                            TraceLow = PenLowEven;
                            }
                        else
                            {
                            TraceHigh = PenHighOdd;
                            TraceLow = PenLowOdd;
                            }


                        int Separation = (h * SeparationPercent / 100);
                        int sx = FindSampleIndex(Start);


                        x = 0;
                        Last_x = -1;
                        y = 0;
                        Last_y = -1;
                        float Last_x1 = -1;
                        for (int i = sx ; x < MainDisplay.Width && i < (QS.Count - 1) ; i++)
                            {

                            Trace = TraceLow;
                            s = QS[i]; // current sample

                            // y is high or low
                            y = 10 + h * (k + 1) - Separation;

                            if (((1 << j) & s.S8) > 0)
                                {
                                Trace = TraceHigh;
                                y = y - h + (Separation) * 2;
                                }


                            Trace.StartCap = LineCap.Round;
                            Trace.EndCap = LineCap.Round;


                            x = (QS[i].Ticks - Start) * PixelsPerTick; // width of the trace
                                                                       // x1 = (QS[i + 1].Ticks - Start) * PixelsPerTick;
                            if (i == sx)
                                {
                                Last_x = x;
                                Last_x1 = x;
                                Last_y = y;
                                }
                            if (x < MainDisplay.Width)
                                if (y != Last_y) // draw transition: 1/2 time on last level, 1/2 time on new level
                                    {
                                    gfx.DrawLine(Trace, Last_x, Last_y, Last_x1 + PixelsPerTick / 4f, Last_y);
                                    gfx.DrawLine(Trace, Last_x1 + PixelsPerTick / 4f, Last_y, x - PixelsPerTick / 4f, y);
                                    //gfx.DrawLine(Trace, x, y, x1, y);
                                    Last_x = x - PixelsPerTick / 4f;
                                    }
                            Last_x1 = x;
                            Last_y = y;
                            }

                        gfx.DrawLine(Trace, Last_x, Last_y, ScreenWidth, Last_y);

                        }
                    ////////////////////////////
                    // Start Drawing Markers ///
                    ////////////////////////////
                    using (Pen PP = new Pen(Color.FromArgb(60, Color.Honeydew), 14))
                    using (Pen P = new Pen(Color.FromArgb(180, Color.Yellow), 1))
                        {
                        P.DashStyle = DashStyle.Custom;
                        P.DashPattern = new float[] { 1f, 2f, 2f, 1f, 2f };
                        Brush B = Brushes.Goldenrod;

                        for (int i = 0 ; i < Markers.Length ; i++)
                            {
                            if ((Markers[i] - Start) * PixelsPerTick >= 0 && (Markers[i] - Start) * PixelsPerTick <= ScreenWidth)
                                {


                                // marker shading
                                float MarkX = (Markers[i] - Start) * PixelsPerTick - PixelsPerTick / 2f;

                                gfx.DrawLine(PP, MarkX, 10, MarkX, this.MainDisplay.Height);

                                //marker line
                                gfx.DrawLine(P, MarkX, 10, MarkX, this.MainDisplay.Height);




                                // marker handle
                                Point[] pts = new Point[4];


                                pts[0].X = (int) MarkX;
                                pts[0].Y = 10;
                                pts[1].X = (int) (MarkX - 5);
                                pts[1].Y = 0;

                                pts[2].X = (int) (MarkX + 5);
                                pts[2].Y = 0;


                                pts[3].X = (int) MarkX;
                                pts[3].Y = 10;

                                gfx.FillPolygon(B, pts);

                                }
                            B = Brushes.Azure;
                            P.Color = Color.Pink;
                            }
                        }


                    if (state_mouse > 0)
                        using (SolidBrush b = new SolidBrush(Color.FromArgb(100, 180, 200, 250)))
                            {
                            float rx1 = (mouseStart - Start) * PixelsPerTick;
                            float rx2 = (mouseCurrent - mouseStart) * PixelsPerTick;
                            gfx.FillRectangle(b, rx1, 0, rx2, MainDisplay.Height);
                            }

                    }

                }
            else
                using (Graphics gfx = Graphics.FromImage(_backBuffer))
                    {
                    gfx.Clear(aBackgroundColorEven);
                    }
            //Copy the back buffer to the screen 
            e.Graphics.DrawImageUnscaled(_backBuffer, 0, 0);

            bgBrushEven.Dispose();
            bgBrushOdd.Dispose();
            PenHighEven.Dispose();
            PenLowEven.Dispose();
            PenHighOdd.Dispose();
            PenLowOdd.Dispose();



            // calculate times for display
            }

        protected override void OnPaintBackground ( PaintEventArgs pevent )
            {

            //Don't allow the background to paint 

            }



        protected override void OnSizeChanged ( EventArgs e )
            {
            if (_backBuffer != null)
                {
                _backBuffer.Dispose();
                _backBuffer = null;
                }

            if (labelBuffer != null)
                {
                labelBuffer.Dispose();
                labelBuffer = null;
                }


            base.OnSizeChanged(e);
            }

        private string GetTickText ( float tm, bool Freq ) // ticks, ?display frequency
            {
            // calculate event time

            float SamplePeriod = (float) (1.0 / SampleFrequency); // sample time in seconds

            tm = tm * SamplePeriod * 1000000; // micro-seconds
            if (Freq)
                {
                string hz = "Hz";
                string fmt = "{0:#.###} {1}";
                tm = 1000000.0f / tm;
                if (tm >= 1000f && tm < 1000000f)
                    {
                    hz = "KHz";
                    tm = tm / 1000f;
                    }
                else
                   if (tm >= 1000000f)
                    {
                    hz = "MHz";
                    fmt = "{0:#.#} {1}";
                    tm = tm / 1000000f;
                    }
                return string.Format(fmt, tm, hz);

                }



            if (rbnS.Checked)
                {
                tm = tm * (float) 1000.0;
                return string.Format("{0:####0} ", tm);
                }
            if (rbmS.Checked)
                {
                tm = tm / (float) 1000.0;
                return string.Format("{0:0.000} ", tm);
                }
            return string.Format("{0:0.0} ", tm);

            }




        private void ShowMarkerTiming ()
            {
            if (Markers[0] > -1)
                mT0.Text = GetTickText(mouseCursor - Markers[0], cbFreq.Checked);
            else
                mT0.Text = "";

            if (Markers[1] > -1)
                mT1.Text = GetTickText(mouseCursor - Markers[1], cbFreq.Checked);
            else
                mT1.Text = "";

            if (Markers[0] > -1)
                T0.Text = GetTickText(Markers[0], false);
            else
                T0.Text = "";

            if (Markers[1] > -1)
                T1.Text = GetTickText(Markers[1], false);
            else
                T1.Text = "";

            if (Markers[1] > -1 && Markers[0] > -1)
                {
                T0T1.Text = GetTickText(Markers[1] - Markers[0], cbFreq.Checked);
                }
            else
                T0T1.Text = "";
            }

        private float GetSnap ( float X )
            {
            if (!cbSnap.Checked)
                return X;
            int i = FindSampleIndex((int) X);

            //snap before
            uint k = QS[i].S8;
            while (i >= 0 && (QS[i].S8 & VisibleChannelsMask) == (k & VisibleChannelsMask))
                i--;
            i++;
            float before = (float) QS[i].Ticks;

            // after
            i = FindSampleIndex((int) X);
            k = QS[i].S8;
            while (i < QS.Count && (QS[i].S8 & VisibleChannelsMask) == (k & VisibleChannelsMask))
                i++;
            if (i >= QS.Count)
                i--;
            float after = (float) QS[i].Ticks;



            return (float) (((X - before) < (after - X)) ? before : after);
            }



        private void MainDisplay_MouseClick ( object sender, MouseEventArgs e )
            {
            float X = (e.X) / PixelsPerTick + Start;
            if (CDMouseDown >= 0)
                return;
            this.Cursor = Cursors.Cross;

            if (e.Button == MouseButtons.Left)
                {
                switch (state_mouse)
                    {
                    case 0:
                    case 1:
                        if (Markers[0] == -1)
                            Markers[0] = GetSnap(X);
                        else
                           if (Markers[1] != -1)
                            {
                            Markers[1] = -1;
                            Markers[0] = GetSnap(X);
                            }
                        else
                            Markers[1] = GetSnap(X);

                        ShowMarkerTiming();
                        break;
                    case 2:
                        state_mouse = 3;
                        break;
                    case 3:
                        if (X >= mouseStart && X <= mouseCurrent)
                            {
                            Start = trackBar1.Value = (int) (mouseStart);
                            PixelsPerTick = ((float) (MainDisplay.Width)) / Math.Abs(mouseCurrent - mouseStart);
                            // update zoom level
                            udZoomRate.Value = (decimal) (PixelsPerTick / (((float) (MainDisplay.Width)) / (float) TSpan));
                            }
                        mouseStart = mouseCurrent = -1;
                        state_mouse = 0;
                        break;
                    }
                InvalidatePictures();
                }

            if (e.Button == MouseButtons.Right)
                {
                Markers[1] = GetSnap(X);
                ShowMarkerTiming();
                InvalidatePictures();
                }
            }

        private void MainDisplay_MouseMove ( object sender, MouseEventArgs e )
            {
            float X = (e.X) / PixelsPerTick + Start; // sample # 

            if (CDMouseDown < 0 || e.Button != MouseButtons.Left)
                {
                CDMouseDown = -1;
                }

            if (CDMouseDown >= 0)
                {
                // move the marker
                Markers[CDMouseDown] = GetSnap(X);
                //cursorDisplay.Invalidate();
                InvalidatePictures();
                return;
                }


            this.Cursor = Cursors.Cross;


            if (SampleValid)
                {
                mouseCursor = X;
                m0.Text = GetTickText(mouseCursor, false);
                ShowMarkerTiming();

                }
            if ((state_mouse == 1 && X != mouseStart) || state_mouse == 2)
                {
                state_mouse = 2;
                mouseCurrent = X;
                InvalidatePictures();
                }
            }



        private void MainDisplay_MouseDown ( object sender, MouseEventArgs e )
            {
            float X = (e.X) / PixelsPerTick + Start;


            if (e.Button == MouseButtons.Left)
                if (e.Y < 10)
                    {
                    for (int i = 0 ; i < Markers.Length ; i++)
                        {
                        int x0 = (int) ((Markers[i] - Start) * PixelsPerTick - 5);
                        int x1 = (int) ((Markers[i] - Start) * PixelsPerTick + 5);
                        if (e.X >= x0 && e.X <= x1 & e.Y < 10.0)
                            {
                            CDMouseDown = i;
                            this.Cursor = Cursors.VSplit;
                            }
                        }
                    return;
                    }


            this.Cursor = Cursors.Cross;


            if (state_mouse == 0)
                {
                mouseStart = X;
                mouseCurrent = -1;
                state_mouse = 1;
                }
            }

        private void MainDisplay_MouseUp ( object sender, MouseEventArgs e )
            {
            float X = (e.X) / PixelsPerTick + Start;
            this.Cursor = Cursors.Cross;

            if (CDMouseDown >= 0)
                {
                CDMouseDown = -1;
                InvalidatePictures();
                return;
                }
            if (state_mouse < 2)
                {
                state_mouse = 0;
                mouseStart = -1;
                mouseCurrent = -1;
                }
            }

        private void trackBar1_Scroll ( object sender, EventArgs e )
            {
            Start = trackBar1.Value;
            InvalidatePictures();
            }



        private void TicksPerDiv_ValueChanged ( object sender, EventArgs e )
            {
            PixelsPerTick = (((float) (MainDisplay.Width)) / (float) TSpan) * (float) udZoomRate.Value;
            InvalidatePictures();
            }

        private void numericUpDown1_ValueChanged ( object sender, EventArgs e )
            {
            NumDivisions = (int) edDivisions.Value;
            InvalidatePictures();
            }

        private void cb7_CheckedChanged ( object sender, EventArgs e )
            {
            InvalidatePictures();
            }

        private void button1_Click ( object sender, EventArgs e )
            {
            Markers[0] = -1;
            Markers[1] = -1;
            ShowMarkerTiming();
            InvalidatePictures();
            }


        private void MainDisplay_SizeChanged ( object sender, EventArgs e )
            {
            InvalidatePictures();
            }


        private void cbFreq_Click ( object sender, EventArgs e )
            {
            ShowMarkerTiming();
            }

        private void edDivisions_Click ( object sender, EventArgs e )
            {
            ShowMarkerTiming();
            InvalidatePictures();
            }

        private void roundButton1_Click ( object sender, EventArgs e )
            {
            try
                {
                Start = trackBar1.Value = (int) (Markers[0]);
                }
            catch
                {
                Start = 0;
                }
            InvalidatePictures();
            }

        private void label3_Click ( object sender, EventArgs e )
            {

            }

        private void LADisplay_Resize ( object sender, EventArgs e )
            {
            InvalidatePictures();
            }


        }



    [Serializable]
    public class Sample
        {
        static public double TicksPerMicrosecond = 1.0;

        [DisplayName("Decimal Sample")]
        public uint S8 // 32 bits
            {
            get;
            set;
            }

        [DisplayName("Hex Sample")]
        public string S8Hex
            {
            get
                {
                string s = string.Format("{0:X}", S8).PadLeft(8, '0');
                return s.Substring(0, 2) + " " + s.Substring(2, 2) + " " + s.Substring(4, 2) + " " + s.Substring(6, 2);
                }
            }

        [DisplayName("Binary Sample")]
        public string BitsArray
            {
            get
                {
                return getBits(S8, 32);
                }
            }


        private string getBits ( uint sa, int numBits )
            {
            char[] s = new char[4];
            int i = 0;
            int k = 0;
            string res = "";

            ulong j = (ulong) Math.Floor(Math.Pow(2, numBits - 1));
            for (ulong t = j ; t > 0 ; t = t / 2)
                {
                s[i++] = ((sa & t) != 0) ? '1' : '0';
                if (i == 4)
                    {
                    res = res + new string(s) + " ";
                    i = 0;
                    k++;
                    if (k % 2 == 0)
                        res = res + " ";
                    }
                }

            return res;
            }



        [DisplayName("Sample #")]
        public uint Ticks
            {
            get;
            set;
            }

        [DisplayName("Sample Time")]
        public string TimeStamp
            {
            get
                {
                string unit = "{0} µS";
                float microsec = (float) (((Ticks / TicksPerMicrosecond)));
                if (microsec < 1)
                    {
                    microsec *= 1000;
                    unit = "{0} nS";
                    }
                else
                if (microsec >= 1000 && microsec < 10000000)
                    {
                    microsec /= 1000;
                    unit = "{0} mS";
                    }
                else
                   if (microsec >= 10000000)
                    {
                    microsec /= 1000000;
                    unit = "{0} S";
                    }


                return string.Format(unit, microsec);
                }
            }


        }


    public class Channel
        {
        public string Label
            {
            get;
            set;
            }
        public bool Visible
            {
            get;
            set;
            }


        }

    }