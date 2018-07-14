using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SUMPLA_net
    {
    public partial class InstrumentPanel :Panel
        {
        private string aCaption = "";
        private Bitmap _backBuffer = null;
        public string Caption
            {
            get
                {
                return aCaption;
                }
            set
                {
                aCaption = value.Trim();
                this.Invalidate();
                if (AdjustPadding)
                    AdjustSides();
                }
            }
        private Font aCaptionFont;
        public Font CaptionFont
            {
            get
                {
                return aCaptionFont;
                }
            set
                {
                aCaptionFont = value;
                this.Invalidate();
                }
            }
        private int cornerRadius = 12;
        public int CornerRadius
            {
            get
                {
                return cornerRadius;
                }
            set
                {
                cornerRadius = value;
                this.Invalidate();
                }
            }


        public bool AdjustPadding
            {
            get;
            set;
            }
        public InstrumentPanel ()
            {
            InitializeComponent();
            if (this.CaptionFont == null)
                this.CaptionFont = this.Font;
            }
        protected void AdjustSides ()
            {
            this.Padding = new Padding(2, (int) this.CaptionFont.Height + 2, 2, 2);
            }



        protected override void OnResize ( EventArgs eventargs )
            {
            base.OnResize(eventargs);
            this.Invalidate();

            }

        protected override void OnPaintBackground ( PaintEventArgs pevent )
            {

            //Don't allow the background to paint 

            }

        protected override void OnPaint ( PaintEventArgs pe )
            {
            if (Caption == "")
                {
                base.OnPaint(pe);
                return;
                }


            _backBuffer = new Bitmap(this.Width, this.Height);


            using (Graphics gfx = Graphics.FromImage(_backBuffer))
                {


                System.Drawing.Drawing2D.GraphicsPath border, border2;

                using (SolidBrush bg = new SolidBrush(this.BackColor))
                using (SolidBrush fg = new SolidBrush(this.ForeColor))
                using (Pen pfg = new Pen(fg, 2))
                    {
                    gfx.Clear(this.BackColor);
                    SizeF textwidth = gfx.MeasureString(this.Caption, this.CaptionFont);
                    PointF coord = new PointF((this.Width - textwidth.Width) / 2, 0);

                    gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;


                    Rectangle r = this.ClientRectangle;



                    //Set the Region of the Control
                    this.Region = new Region(RoundRegion(r));

                    r.Inflate(-1, -1);
                    border = RoundRegion(r);

                    r.Height -= (int) textwidth.Height;
                    r.Y += (int) textwidth.Height;


                    border2 = RoundRegion(r);



                    //Fill The Region with the Controls BackColor
                    gfx.FillPath(fg, border);

                    gfx.FillPath(bg, border2);

                    gfx.FillRectangle(fg, 0f, 0f, (float) this.Width, textwidth.Height);
                    gfx.FillRectangle(bg, coord.X, coord.Y, textwidth.Width, textwidth.Height);
                    gfx.DrawPath(pfg, border);

                    gfx.DrawString(this.Caption, this.CaptionFont, fg, coord.X, coord.Y + 2);

                    }
                pe.Graphics.DrawImageUnscaled(_backBuffer, 0, 0);
                }

            }




        private System.Drawing.Drawing2D.GraphicsPath RoundRegion ( Rectangle r )
            {
            //Scale the radius if it's too large to fit.
            int radius = CornerRadius;
            if (radius > (r.Width))
                radius = r.Width;
            if (radius > (r.Height))
                radius = r.Height;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            if (radius <= 0)
                {
                path.AddRectangle(r);
                }
            else
                {
                path.AddArc(r.Left, r.Top, radius, radius, 180, 90);
                path.AddArc(r.Right - radius, r.Top, radius, radius, 270, 90);
                path.AddLine(r.Right, r.Bottom, r.Right, r.Bottom);
                path.AddLine(r.Left, r.Bottom, r.Left, r.Bottom);
                path.CloseFigure();
                }

            return path;
            }




        }
    }
