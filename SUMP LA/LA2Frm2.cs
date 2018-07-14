using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO.Ports;
using System.IO;
using System.Xml;
using System.Xml.Serialization;


namespace SUMPLA_net
    {
    public partial class LA2Frm2 :Form
        {

        List<byte> lBuffer = new List<byte>();
        List<Trigger> TrLst = new List<Trigger>();


        //public DSSettings Channels; // this will hold the global Settings for the program

        bool _continue = true;
        bool _aborted = false;
        bool _running = false;
        byte[] LABuff = new byte[65536]; // 64K buffer
        int LABuff_ReadLen = 0;


        public LA2Frm2 ()
            {
            InitializeComponent();
            Application.Idle += new EventHandler(Application_Idle);

            Rotate(0x0f);//80000000);


            TrLst.Add(trigger0);
            TrLst.Add(trigger1);
            TrLst.Add(trigger2);
            TrLst.Add(trigger3);

            ResetSettings();

            }

        void Application_Idle ( object sender, EventArgs e )
            {
            //trigger0.Enabled = trigger1.Enabled = trigger2.Enabled = trigger3.Enabled = cbTrigEnable.Checked;
            //trigger1.Visible = trigger2.Visible = trigger3.Visible = !(rbSimple.Checked);
            btRaw.Enabled = btTrans.Enabled = AnalyzerDisplay.QS.Count > 0;
            btRun.Enabled = (cg0.Checked || cg1.Checked || cg2.Checked || cg3.Checked);
            }


        private void btRun_Click ( object sender, EventArgs e )
            {
            this.Cursor = Cursors.WaitCursor;
            try
                {

                AnalyzerDisplay.ClearSamples();
                AnalyzerDisplay.ChannelVisibility();

                serialPort1.ReadTimeout = (int) nRTOut.Value;
                serialPort1.WriteTimeout = (int) nWTOut.Value;


                if (cbPort.Text.Trim() != "")
                    serialPort1.PortName = cbPort.Text;
                if (cbBaud.SelectedValue != null)
                    serialPort1.BaudRate = (int) cbBaud.SelectedValue;

                try
                    {
                    serialPort1.Open();
                    }
                catch (Exception exx)
                    {
                    MessageBox.Show("COM Port Error: " + exx.Message);
                    }


                try
                    {
                    ReadData();
                    }

                catch (Exception exx)
                    {
                    if (exx is System.TimeoutException)
                        {
                        if (AnalyzerDisplay.QS.Count < 2)
                            MessageBox.Show(exx.Message);

                        }
                    else
                        MessageBox.Show(exx.Message);
                    }
                }
            finally
                {
                this.Cursor = Cursors.Default;
                if (serialPort1.IsOpen)
                    serialPort1.Close();

                AnalyzerDisplay.SampleValid = true;
                dgData.DataSource = null;
                dgData.DataSource = AnalyzerDisplay.QS;

                }

            }

        private void btDemo_Click ( object sender, EventArgs e )
            {
            uint TStamp;
            int k = 0;
            uint val;
            AnalyzerDisplay.QS.Clear();
            AnalyzerDisplay.SampleFrequency = (int) cbRate.SelectedValue;

            for (uint i = 0 ; i < 2000 ; i++)
                {
                TStamp = i;
                val = i + (i << 16);
                AnalyzerDisplay.AddSample(TStamp, val);
                }

            AnalyzerDisplay.SampleValid = true;
            dgData.DataSource = null;
            dgData.DataSource = AnalyzerDisplay.QS;
            }



        void ResetSettings ()
            {
            // get the channels 
            try
                {

                cbRate.DataSource = Channels.SampleRates;
                cbRate.DisplayMember = "Name";
                cbRate.ValueMember = "Frequency";


                nBuffSize.DataSource = Channels.BufferSizes;
                nBuffSize.DisplayMember = "Name";
                nBuffSize.ValueMember = "Size";


                foreach (string s in SerialPort.GetPortNames())
                    cbPort.Items.Add(s);

                Channels.Clear();
                Channels.ReadXml("ChannelsConfig.xml");
                AnalyzerDisplay.Channels = Channels;



                if (Channels.CurrentSettings.Rows.Count == 0)
                    {
                    DSSettings.CurrentSettingsRow R1 = Channels.CurrentSettings.NewCurrentSettingsRow();
                    R1.Baud = "9600";
                    R1.ComPort = "COM1";
                    R1.ReadTOut = 1500;
                    R1.WriteTOut = 1500;
                    R1.SamplingClock = 0;
                    R1.ChannelGroup_0 = true;
                    R1.ChannelGroup_1 = true;
                    R1.ChannelGroup_2 = true;
                    R1.ChannelGroup_3 = true;

                    R1.NoiseFilter = true;
                    R1.RLE = false;

                    Channels.CurrentSettings.AddCurrentSettingsRow(R1);
                    }

                if (Channels.Colors.Rows.Count == 0)
                    {
                    DSSettings.ColorsRow CR1 = Channels.Colors.NewColorsRow();

                    CR1.ChannelLabelBG = Color.Gray.ToArgb();
                    CR1.ChannelLabelFG = Color.Gold.ToArgb();
                    CR1.EvenTraceBackColor = Color.Black.ToArgb();
                    CR1.EvenTraceColor = Color.Gold.ToArgb();
                    CR1.OddTraceBackColor = Color.Black.ToArgb();
                    CR1.OddTraceColor = Color.Cyan.ToArgb();

                    Channels.Colors.AddColorsRow(CR1);
                    }


                DSSettings.CurrentSettingsRow R = ((DSSettings.CurrentSettingsRow) Channels.CurrentSettings.Rows[0]);


                cg0.Checked = R.ChannelGroup_0;
                cg1.Checked = R.ChannelGroup_1;
                cg2.Checked = R.ChannelGroup_2;
                cg3.Checked = R.ChannelGroup_3;

                cbClock.SelectedIndex = R.SamplingClock;

                /*try
                   {
                   cbClock.SelectedIndex = R.SamplingClock;
                   }
                catch
                   {
                   cbClock.SelectedIndex = 0;
                   }
                cbNoiseFilter.Checked = R.NoiseFilter;
                cbRLE.Checked = R.RLE;
                */

                if (serialPort1.IsOpen)
                    serialPort1.Close();

                DSSettings.ColorsRow CR = (DSSettings.ColorsRow) Channels.Colors.Rows[0];

                CCEvenBG.ARGBColor = CR.EvenTraceBackColor;
                CCOddBG.ARGBColor = CR.OddTraceBackColor;
                CCEvenFG.ARGBColor = CR.EvenTraceColor;
                CCOddFG.ARGBColor = CR.OddTraceColor;

                SetLADisplayColors();

                AnalyzerDisplay.ChannelVisibility();
                AnalyzerDisplay.InvalidatePictures();

                pnBeforeafter.Caption = string.Format("Before/After Ratio: {0}/{1}", tbRatio.Value, 100 - tbRatio.Value);
                }
            catch (Exception ex)
                {
                string s = ex.Message;
                MessageBox.Show(s);
                }
            }

        private void SetLADisplayColors ()
            {
            AnalyzerDisplay.BackgroundColorEven = CCEvenBG.SelectedColor;
            AnalyzerDisplay.BackgroundColorOdd = CCOddBG.SelectedColor;
            AnalyzerDisplay.ForegroundColorEven = CCEvenFG.SelectedColor;
            AnalyzerDisplay.ForegroundColorOdd = CCOddFG.SelectedColor;

            AnalyzerDisplay.InvalidatePictures();
            }

        private void LA2Frm2_FormClosing ( object sender, FormClosingEventArgs e )
            {
            //Channels.CurrentSettings.Rows.Clear();
            DSSettings.CurrentSettingsRow R = (DSSettings.CurrentSettingsRow) Channels.CurrentSettings.Rows[0];
            DSSettings.ColorsRow CR = (DSSettings.ColorsRow) Channels.Colors.Rows[0];

            R.SamplingClock = cbClock.SelectedIndex;

            /*
             R.Baud = Int32.Parse(String.Format("{0}", cbBaud.Text).Trim());
             R.ComPort = cbPort.Text;
             R.SamplingClock = cbClock.SelectedIndex;
             R.ChannelGroup_0 = cg0.Checked;
             R.ChannelGroup_1 = cg1.Checked;
             R.ChannelGroup_2 = cg2.Checked;
             R.ChannelGroup_3 = cg3.Checked;

             R.NoiseFilter = cbNoiseFilter.Checked;
             R.RLE = cbRLE.Checked;

             Channels.CurrentSettings.AddCurrentSettingsRow(R); 
             */


            R.AcceptChanges();


            CR.EvenTraceBackColor = CCEvenBG.ARGBColor;
            CR.OddTraceBackColor = CCOddBG.ARGBColor;
            CR.EvenTraceColor = CCEvenFG.ARGBColor;
            CR.OddTraceColor = CCOddFG.ARGBColor;

            CR.AcceptChanges();

            Channels.CurrentSettings.AcceptChanges();
            Channels.Colors.AcceptChanges();
            Channels.AcceptChanges();
            Channels.WriteXml("ChannelsConfig.xml");

            if (serialPort1.IsOpen)
                serialPort1.Close();
            serialPort1.Dispose();
            }




        private void btSaveConfig_Click ( object sender, EventArgs e )
            {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                AnalyzerDisplay.Channels.WriteXml(saveFileDialog1.FileName);
                }
            }


        private void btLoad_Click ( object sender, EventArgs e )
            {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                AnalyzerDisplay.Channels.Clear();
                AnalyzerDisplay.Channels.ReadXml(openFileDialog1.FileName);
                AnalyzerDisplay.Channels.AcceptChanges();
                AnalyzerDisplay.Channels.WriteXml("ChannelsConfig.xml");
                ResetSettings();
                }
            }

        private void ResetLA_Click ( object sender, EventArgs e )
            {
            LAReset();
            }


        private void LAReset ()
            {
            byte[] BReset = new byte[] { 0, 0, 0, 0, 0 };
            LASendCommand(BReset, 5);
            LAID();
            }

        private void IDLA_Click ( object sender, EventArgs e )
            {
            LAID();
            }


        private void LAID ()
            {
            byte[] LAID = new byte[] { 2 };
            LASendCommand(LAID, 1);

            LARead(4);
            int i = LABuff[0];
            }

        private byte[] buildStartCommand ()
            {
            List<byte> start = new List<byte>();

            byte c1 = 0xC0;
            byte b = 0;
            int k = 0;
            int v = 0;

            foreach (Trigger T in TrLst)
                {
                int Stage = T.StageNum;

                start.Add((byte) (c1++ + Stage * 4)); // set Mask
                start.AddRange(T.MaskBytes);

                start.Add((byte) (c1++ + Stage * 4)); // set Mask
                start.AddRange(T.ValueBytes);


                start.Add((byte) (c1++ + Stage * 4)); // set Config

                start.AddRange(T.DelayBytes);   // delay

                b = (byte) (((int) T.SerialChannel.Value & 0xf) << 4);  // serial Chanel
                b += (T.Level);
                start.Add(b);

                b = 0;
                if (T.rbSerial.Checked)
                    b += 4;
                if (T.rbStart.Checked)
                    b += 8;

                if ((int) T.SerialChannel.Value > 15)
                    b += 1;
                start.Add(b);
                }

            /* set divider
            00 00 00 100 MHz
            09 00 00  10 MHz
            63 00 00   1 MHz
            e7 03 00 100 kHz
            0f 27 00  10 kHz
            9f 86 01   1 KHz

            value to send= (100,000,000/ freq) -1

            */

            int fx = (int) ((100000000 / (int) cbRate.SelectedValue) - 1);

            start.Add((byte) 0x80);
            start.AddRange(Trigger.LSBFirstGetBytes(fx, 3));
            start.Add((byte) 0);


            //81 0f 00 0f 00  64 bits 50/50
            // 81 00 10 03 20
            start.Add((byte) 0x81);
            fx = (int) nBuffSize.SelectedValue / 4 - 1; // buffer size
            start.AddRange(Trigger.LSBFirstGetBytes(fx, 2));

            fx = (fx * (100 - tbRatio.Value)) / 100;
            start.AddRange(Trigger.LSBFirstGetBytes(fx, 2));


            // 82 00 00 00 00  internal, all groups   0 0  0 0  0 0 0 0 
            // 82 20 00 00 00  internal, group 3 off  0 0  1 0  0 0 0 0
            // 82 10 00 00 00  internal  group 2 off  0 0  0 1  0 0 0 0
            // 82 08 00 00 00  internal  group 1 off  0 0  0 0  1 0 0 0
            // 82 04 00 00 00  internal  group 0 off  0 0  0 0  0 1 0 0



            // 82 40 00 00 00 extern rising     0 1 0 0
            // 82 c0 00 00 00  extern falling   1 1 0 0 
            // 82 00 00 00 00 internal          0 0 0 0   
            start.Add((byte) 0x82);
            b = 0;

            if (cbClock.SelectedIndex == 1)
                b += 0x40;
            if (cbClock.SelectedIndex == 2)
                b += 0xC0;

            if (!cg3.Checked)
                b += 0x20;

            if (!cg2.Checked)
                b += 0x10;

            if (!cg1.Checked)
                b += 0x08;

            if (!cg0.Checked)
                b += 0x04;

            start.Add(b);
            start.Add((byte) 0);
            start.Add((byte) 0);
            start.Add((byte) 0);

            start.Add((byte) 1); // start command

            byte[] bstart = start.ToArray();

            string s = "";
            for (int o = 0 ; o < 10 ; o++)
                {
                s = s + string.Format("{0:X} ", bstart[o]);
                }
            return bstart;

            }

        private void ReadData ()
            {

            byte[] start = buildStartCommand();


            LAReset();
            LAID();

            AnalyzerDisplay.SampleFrequency = (int) cbRate.SelectedValue;
            Sample.TicksPerMicrosecond = (double) AnalyzerDisplay.SampleFrequency / 1000000.0;

            uint Tick = 0;
            uint val = 0;
            LASendCommand(start, start.Length);



            byte[] bit32word = new byte[4];
            do
                {
                do
                    {

                    bit32word[3] = 0;// 8
                    bit32word[2] = 0;//16
                    bit32word[1] = 0;//24
                    bit32word[0] = 0;//32

                    if (cg0.Checked)
                        {
                        LARead(1);  //Get 8 bits    reversed order
                        bit32word[3] = (LABuff[0]);
                        }
                    if (cg1.Checked)
                        {
                        LARead(1);
                        bit32word[2] = (LABuff[0]);
                        }

                    if (cg2.Checked)
                        {
                        LARead(1);
                        bit32word[1] = (LABuff[0]);//24
                        }

                    if (cg3.Checked)
                        {
                        LARead(1);  //Get 32 bits   
                        bit32word[0] = (LABuff[0]);
                        }


                    val = (uint) bit32word[0]; //MSB
                    val *= 256;


                    val += (uint) bit32word[1]; //8
                    val *= 256;

                    val += (uint) bit32word[2]; //8
                    val *= 256;

                    val += (uint) bit32word[3]; //LSB

                    AnalyzerDisplay.AddSample(Tick++, val);
                    } while (serialPort1.BytesToRead > 0);

                Thread.Sleep(200);
                } while (serialPort1.BytesToRead > 0);

            AnalyzerDisplay.SampleValid = true;
            dgData.DataSource = null;
            dgData.DataSource = AnalyzerDisplay.QS;

            }
        static uint Rotate ( uint input )
            {
            uint output = 0;
            for (int i = 0 ; i < 32 ; i++)
                {
                output <<= 1;
                output += input & 0x1;
                input >>= 1;
                }
            //output += input & 0x1;
            //output <<= 1;
            return output;
            }


        static byte Rotate ( byte input )
            {
            int output = 0;
            for (int i = 0 ; i < 8 ; i++)
                {
                output <<= 1;
                output += input & (byte) 0x1;
                input >>= 1;
                }
            //output += input & 0x1;
            //output <<= 1;
            return (byte) output;
            }


        private void ReadData2 ()
            {

            byte[] start = buildStartCommand();


            LAReset();
            LAID();

            AnalyzerDisplay.SampleFrequency = (int) cbRate.SelectedValue;
            Sample.TicksPerMicrosecond = (double) AnalyzerDisplay.SampleFrequency / 1000000.0;

            uint Tick = 0;
            uint val = 0;
            LASendCommand(start, start.Length);


            byte[] bit32word = new byte[4];
            do
                {
                do
                    {

                    bit32word[3] = 0;
                    bit32word[2] = 0;//16
                    bit32word[1] = 0;//24
                    bit32word[0] = 0;

                    if (cg3.Checked)
                        {
                        LARead(1);  //Get 8 bits    reversed order
                        bit32word[3] = LABuff[0];
                        }
                    if (cg2.Checked)
                        {
                        LARead(1);
                        bit32word[2] = LABuff[0];//16
                        }

                    if (cg1.Checked)
                        {
                        LARead(1);
                        bit32word[1] = LABuff[0];//24
                        }

                    if (cg0.Checked)
                        {
                        LARead(1);  //Get 32 bits   
                        bit32word[0] = LABuff[0];
                        }


                    val = (uint) bit32word[3]; //MSB
                    val *= 256;


                    val += (uint) bit32word[2]; //8
                    val *= 256;

                    val += (uint) bit32word[1]; //8
                    val *= 256;

                    val += (uint) bit32word[0]; //LSB

                    AnalyzerDisplay.AddSample(Tick++, Rotate(val));
                    } while (serialPort1.BytesToRead > 0);

                Thread.Sleep(200);
                } while (serialPort1.BytesToRead > 0);

            AnalyzerDisplay.SampleValid = true;
            dgData.DataSource = null;
            dgData.DataSource = AnalyzerDisplay.QS;

            }


        private void LARead ( int len )
            {
            LABuff_ReadLen = len;

            serialPort1.Read(LABuff, 0, len);


            //Thread readThread = new Thread(ReadSerialData);
            //_continue = true;
            //_aborted = false;
            //readThread.Start();
            //readThread.Join();
            }

        private void LASendCommand ( byte[] Buff, int len )
            {
            try
                {
                for (int i = 0 ; i < len ; i++)
                    {
                    serialPort1.Write(Buff, i, 1);
                    Thread.Sleep(1);
                    }
                Thread.Sleep(50);
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                return;
                }
            }




        private void ClearLABuff ( int len )
            {
            for (int i = 0 ; i < len ; i++)
                LABuff[i] = 0;

            }


        private void btSaveSamples_Click ( object sender, EventArgs e )
            {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                try
                    {
                    this.Cursor = Cursors.WaitCursor;
                    TextWriter writer = new StreamWriter(saveFileDialog1.FileName);
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Sample>));
                    serializer.Serialize(writer, AnalyzerDisplay.QS);
                    writer.Close();
                    }
                catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message);
                    }
                finally
                    {
                    this.Cursor = Cursors.Default;
                    }
            }

        private void btLoadSamples_Click ( object sender, EventArgs e )
            {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                    {
                    AnalyzerDisplay.QS.Clear();
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Sample>));
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                    XmlReader reader = new XmlTextReader(fs);
                    AnalyzerDisplay.QS = (List<Sample>) serializer.Deserialize(reader);
                    fs.Close();
                    AnalyzerDisplay.SampleValid = true;
                    dgData.DataSource = null;
                    dgData.DataSource = AnalyzerDisplay.QS;
                    }
                catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message);
                    }
                finally
                    {
                    this.Cursor = Cursors.Default;
                    }

            }
        private void rbSimple_Click ( object sender, EventArgs e )
            {
            if (!rbSimple.Checked && !rbComplex.Checked)
                rbSimple.Checked = true;
            }


        private void tbRatio_ValueChanged ( object sender, EventArgs e )
            {
            pnBeforeafter.Caption = string.Format("Before/After Ratio: {0}/{1}", tbRatio.Value, 100 - tbRatio.Value);
            }




        // returns transition ticks only
        protected List<Sample> GetTransitions ( List<Sample> QS )
            {
            if (QS.Count == 0)
                return null;
            List<Sample> L = new List<Sample>();
            Sample s = QS[0];
            L.Add(s);

            for (int i = 0 ; i < QS.Count ; i++)
                if (QS[i].S8 != s.S8)
                    {
                    s = QS[i];
                    L.Add(s);
                    }
            return L;
            }

        private void btRaw_Click ( object sender, EventArgs e )
            {
            if (btRaw.Checked)
                dgData.DataSource = AnalyzerDisplay.QS;
            else
                dgData.DataSource = GetTransitions(AnalyzerDisplay.QS);
            }

        private void cbPort_SelectedValueChanged ( object sender, EventArgs e )
            {
            if (serialPort1.IsOpen)
                serialPort1.Close();
            if (cbPort.Text.Trim() != "")
                serialPort1.PortName = cbPort.Text;
            if (cbBaud.SelectedValue != null)
                serialPort1.BaudRate = (int) cbBaud.SelectedValue;

            }


        private void CCEvenFG_PropertyChanged ( object sender, PropertyChangedEventArgs e )
            {
            SetLADisplayColors();
            }



        }
    }



