namespace SUMPLA_net
   {
   partial class LADisplay
      {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose ( bool disposing )
         {
         if (disposing && (components != null))
            {
            components.Dispose();
            }
         base.Dispose(disposing);
         }

      #region Component Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent ()
         {
         this.panel1 = new System.Windows.Forms.Panel();
         this.trackBar1 = new System.Windows.Forms.TrackBar();
         this.panel3 = new System.Windows.Forms.Panel();
         this.panel4 = new System.Windows.Forms.Panel();
         this.MainDisplay = new System.Windows.Forms.PictureBox();
         this.LabelsDisplay = new System.Windows.Forms.PictureBox();
         this.pnlTrace = new SUMPLA_net.InstrumentPanel();
         this.gbMarkers = new SUMPLA_net.InstrumentPanel();
         this.roundButton1 = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.cbFreq = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.cbSnap = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.button1 = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.label12 = new System.Windows.Forms.Label();
         this.mT1 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.mT0 = new System.Windows.Forms.Label();
         this.label11 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.T0T1 = new System.Windows.Forms.Label();
         this.T1 = new System.Windows.Forms.Label();
         this.T0 = new System.Windows.Forms.Label();
         this.m0 = new System.Windows.Forms.Label();
         this.gbDisplay = new SUMPLA_net.InstrumentPanel();
         this.rbnS = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.rbuS = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.label3 = new System.Windows.Forms.Label();
         this.edDivisions = new System.Windows.Forms.NumericUpDown();
         this.rbmS = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.udZoomRate = new System.Windows.Forms.NumericUpDown();
         this.label2 = new System.Windows.Forms.Label();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize) (this.trackBar1)).BeginInit();
         this.panel3.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize) (this.MainDisplay)).BeginInit();
         ((System.ComponentModel.ISupportInitialize) (this.LabelsDisplay)).BeginInit();
         this.gbMarkers.SuspendLayout();
         this.gbDisplay.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize) (this.edDivisions)).BeginInit();
         ((System.ComponentModel.ISupportInitialize) (this.udZoomRate)).BeginInit();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.gbMarkers);
         this.panel1.Controls.Add(this.gbDisplay);
         this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(951, 115);
         this.panel1.TabIndex = 1;
         // 
         // trackBar1
         // 
         this.trackBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
         this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (225)))), ((int) (((byte) (224)))), ((int) (((byte) (219)))));
         this.trackBar1.Cursor = System.Windows.Forms.Cursors.Arrow;
         this.trackBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.trackBar1.Location = new System.Drawing.Point(52, 4);
         this.trackBar1.Margin = new System.Windows.Forms.Padding(0);
         this.trackBar1.Name = "trackBar1";
         this.trackBar1.Size = new System.Drawing.Size(899, 45);
         this.trackBar1.TabIndex = 1;
         this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
         this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
         // 
         // panel3
         // 
         this.panel3.Controls.Add(this.trackBar1);
         this.panel3.Controls.Add(this.panel4);
         this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel3.Location = new System.Drawing.Point(0, 430);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(951, 49);
         this.panel3.TabIndex = 2;
         // 
         // panel4
         // 
         this.panel4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (225)))), ((int) (((byte) (224)))), ((int) (((byte) (219)))));
         this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
         this.panel4.Location = new System.Drawing.Point(0, 0);
         this.panel4.Name = "panel4";
         this.panel4.Size = new System.Drawing.Size(52, 49);
         this.panel4.TabIndex = 2;
         // 
         // MainDisplay
         // 
         this.MainDisplay.BackColor = System.Drawing.Color.Black;
         this.MainDisplay.Cursor = System.Windows.Forms.Cursors.Cross;
         this.MainDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
         this.MainDisplay.ForeColor = System.Drawing.Color.Goldenrod;
         this.MainDisplay.Location = new System.Drawing.Point(66, 131);
         this.MainDisplay.Name = "MainDisplay";
         this.MainDisplay.Size = new System.Drawing.Size(885, 299);
         this.MainDisplay.TabIndex = 1;
         this.MainDisplay.TabStop = false;
         this.MainDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainDisplay_MouseMove);
         this.MainDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainDisplay_MouseClick);
         this.MainDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainDisplay_MouseDown);
         this.MainDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.MainDisplay_Paint);
         this.MainDisplay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainDisplay_MouseUp);
         this.MainDisplay.SizeChanged += new System.EventHandler(this.MainDisplay_SizeChanged);
         // 
         // LabelsDisplay
         // 
         this.LabelsDisplay.BackColor = System.Drawing.Color.DimGray;
         this.LabelsDisplay.Dock = System.Windows.Forms.DockStyle.Left;
         this.LabelsDisplay.ForeColor = System.Drawing.Color.Goldenrod;
         this.LabelsDisplay.Location = new System.Drawing.Point(0, 131);
         this.LabelsDisplay.Name = "LabelsDisplay";
         this.LabelsDisplay.Size = new System.Drawing.Size(66, 299);
         this.LabelsDisplay.TabIndex = 0;
         this.LabelsDisplay.TabStop = false;
         this.LabelsDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
         // 
         // pnlTrace
         // 
         this.pnlTrace.AdjustPadding = true;
         this.pnlTrace.BackColor = System.Drawing.Color.Black;
         this.pnlTrace.Caption = "TRACE";
         this.pnlTrace.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.pnlTrace.CornerRadius = 22;
         this.pnlTrace.Dock = System.Windows.Forms.DockStyle.Top;
         this.pnlTrace.ForeColor = System.Drawing.Color.Goldenrod;
         this.pnlTrace.Location = new System.Drawing.Point(0, 115);
         this.pnlTrace.Name = "pnlTrace";
         this.pnlTrace.Padding = new System.Windows.Forms.Padding(2, 15, 2, 2);
         this.pnlTrace.Size = new System.Drawing.Size(951, 16);
         this.pnlTrace.TabIndex = 2;
         // 
         // gbMarkers
         // 
         this.gbMarkers.AdjustPadding = false;
         this.gbMarkers.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (225)))), ((int) (((byte) (224)))), ((int) (((byte) (219)))));
         this.gbMarkers.Caption = "Markers";
         this.gbMarkers.CaptionFont = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.gbMarkers.Controls.Add(this.roundButton1);
         this.gbMarkers.Controls.Add(this.cbFreq);
         this.gbMarkers.Controls.Add(this.cbSnap);
         this.gbMarkers.Controls.Add(this.button1);
         this.gbMarkers.Controls.Add(this.label12);
         this.gbMarkers.Controls.Add(this.mT1);
         this.gbMarkers.Controls.Add(this.label1);
         this.gbMarkers.Controls.Add(this.mT0);
         this.gbMarkers.Controls.Add(this.label11);
         this.gbMarkers.Controls.Add(this.label10);
         this.gbMarkers.Controls.Add(this.label9);
         this.gbMarkers.Controls.Add(this.label8);
         this.gbMarkers.Controls.Add(this.T0T1);
         this.gbMarkers.Controls.Add(this.T1);
         this.gbMarkers.Controls.Add(this.T0);
         this.gbMarkers.Controls.Add(this.m0);
         this.gbMarkers.CornerRadius = 32;
         this.gbMarkers.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gbMarkers.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (12)))), ((int) (((byte) (2)))), ((int) (((byte) (98)))));
         this.gbMarkers.Location = new System.Drawing.Point(0, 0);
         this.gbMarkers.Name = "gbMarkers";
         this.gbMarkers.Size = new System.Drawing.Size(776, 115);
         this.gbMarkers.TabIndex = 21;
         this.gbMarkers.Text = "Markers";
         // 
         // roundButton1
         // 
         this.roundButton1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.roundButton1.BackColor = System.Drawing.Color.DeepSkyBlue;
         this.roundButton1.Checked = false;
         this.roundButton1.Cursor = System.Windows.Forms.Cursors.Hand;
         this.roundButton1.Dome = true;
         this.roundButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
         this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.roundButton1.Location = new System.Drawing.Point(594, 46);
         this.roundButton1.Name = "roundButton1";
         this.roundButton1.Pushable = false;
         this.roundButton1.PushedColor = System.Drawing.Color.PowderBlue;
         this.roundButton1.RadioGroup = 0;
         this.roundButton1.RecessDepth = 0;
         this.roundButton1.Size = new System.Drawing.Size(53, 42);
         this.roundButton1.TabIndex = 28;
         this.roundButton1.Text = "Find";
         this.roundButton1.UseVisualStyleBackColor = false;
         this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
         // 
         // cbFreq
         // 
         this.cbFreq.BackColor = System.Drawing.Color.Goldenrod;
         this.cbFreq.Checked = false;
         this.cbFreq.Cursor = System.Windows.Forms.Cursors.Hand;
         this.cbFreq.Dome = true;
         this.cbFreq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
         this.cbFreq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.cbFreq.Location = new System.Drawing.Point(514, 46);
         this.cbFreq.Name = "cbFreq";
         this.cbFreq.Pushable = true;
         this.cbFreq.PushedColor = System.Drawing.Color.Yellow;
         this.cbFreq.RadioGroup = 0;
         this.cbFreq.RecessDepth = 0;
         this.cbFreq.Size = new System.Drawing.Size(53, 42);
         this.cbFreq.TabIndex = 26;
         this.cbFreq.Text = "Freq";
         this.cbFreq.UseVisualStyleBackColor = false;
         this.cbFreq.Click += new System.EventHandler(this.cbFreq_Click);
         // 
         // cbSnap
         // 
         this.cbSnap.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.cbSnap.BackColor = System.Drawing.Color.DeepSkyBlue;
         this.cbSnap.Checked = false;
         this.cbSnap.Cursor = System.Windows.Forms.Cursors.Hand;
         this.cbSnap.Dome = true;
         this.cbSnap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
         this.cbSnap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.cbSnap.Location = new System.Drawing.Point(653, 46);
         this.cbSnap.Name = "cbSnap";
         this.cbSnap.Pushable = true;
         this.cbSnap.PushedColor = System.Drawing.Color.PowderBlue;
         this.cbSnap.RadioGroup = 0;
         this.cbSnap.RecessDepth = 0;
         this.cbSnap.Size = new System.Drawing.Size(53, 42);
         this.cbSnap.TabIndex = 27;
         this.cbSnap.Text = "Snap";
         this.cbSnap.UseVisualStyleBackColor = false;
         // 
         // button1
         // 
         this.button1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.button1.BackColor = System.Drawing.Color.LightCoral;
         this.button1.Checked = false;
         this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
         this.button1.Dome = true;
         this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
         this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button1.Location = new System.Drawing.Point(712, 46);
         this.button1.Name = "button1";
         this.button1.Pushable = false;
         this.button1.PushedColor = System.Drawing.Color.Empty;
         this.button1.RadioGroup = 0;
         this.button1.RecessDepth = 0;
         this.button1.Size = new System.Drawing.Size(53, 42);
         this.button1.TabIndex = 25;
         this.button1.Text = "Clear";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // label12
         // 
         this.label12.AutoSize = true;
         this.label12.Location = new System.Drawing.Point(358, 83);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(35, 13);
         this.label12.TabIndex = 14;
         this.label12.Text = "┼►T1";
         // 
         // mT1
         // 
         this.mT1.BackColor = System.Drawing.Color.Black;
         this.mT1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.mT1.Font = new System.Drawing.Font("LCD", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.mT1.ForeColor = System.Drawing.Color.LightSkyBlue;
         this.mT1.Location = new System.Drawing.Point(396, 76);
         this.mT1.Name = "mT1";
         this.mT1.Size = new System.Drawing.Size(112, 24);
         this.mT1.TabIndex = 13;
         this.mT1.Text = "0";
         this.mT1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(186, 83);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(35, 13);
         this.label1.TabIndex = 12;
         this.label1.Text = "┼►T0";
         // 
         // mT0
         // 
         this.mT0.BackColor = System.Drawing.Color.Black;
         this.mT0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.mT0.Font = new System.Drawing.Font("LCD", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.mT0.ForeColor = System.Drawing.Color.LightSkyBlue;
         this.mT0.Location = new System.Drawing.Point(223, 76);
         this.mT0.Name = "mT0";
         this.mT0.Size = new System.Drawing.Size(112, 24);
         this.mT0.TabIndex = 11;
         this.mT0.Text = "0";
         this.mT0.TextAlign = System.Drawing.ContentAlignment.BottomRight;
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Location = new System.Drawing.Point(7, 83);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(51, 13);
         this.label11.TabIndex = 10;
         this.label11.Text = "T0 ─►T1";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(371, 46);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(21, 13);
         this.label10.TabIndex = 9;
         this.label10.Text = "T1";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(199, 46);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(21, 13);
         this.label9.TabIndex = 8;
         this.label9.Text = "T0";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(6, 46);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(46, 13);
         this.label8.TabIndex = 7;
         this.label8.Text = "Cursor";
         // 
         // T0T1
         // 
         this.T0T1.BackColor = System.Drawing.Color.Black;
         this.T0T1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.T0T1.Font = new System.Drawing.Font("LCD", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.T0T1.ForeColor = System.Drawing.Color.LightSkyBlue;
         this.T0T1.Location = new System.Drawing.Point(61, 76);
         this.T0T1.Name = "T0T1";
         this.T0T1.Size = new System.Drawing.Size(112, 24);
         this.T0T1.TabIndex = 5;
         this.T0T1.Text = "0 Mhz";
         this.T0T1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
         // 
         // T1
         // 
         this.T1.BackColor = System.Drawing.Color.Black;
         this.T1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.T1.Font = new System.Drawing.Font("LCD", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.T1.ForeColor = System.Drawing.Color.Red;
         this.T1.Location = new System.Drawing.Point(396, 39);
         this.T1.Name = "T1";
         this.T1.Size = new System.Drawing.Size(112, 24);
         this.T1.TabIndex = 4;
         this.T1.Text = "0";
         this.T1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
         // 
         // T0
         // 
         this.T0.BackColor = System.Drawing.Color.Black;
         this.T0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.T0.Font = new System.Drawing.Font("LCD", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.T0.ForeColor = System.Drawing.Color.Red;
         this.T0.Location = new System.Drawing.Point(223, 39);
         this.T0.Name = "T0";
         this.T0.Size = new System.Drawing.Size(112, 24);
         this.T0.TabIndex = 3;
         this.T0.Text = "0";
         this.T0.TextAlign = System.Drawing.ContentAlignment.BottomRight;
         // 
         // m0
         // 
         this.m0.BackColor = System.Drawing.Color.Black;
         this.m0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.m0.Font = new System.Drawing.Font("LCD", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.m0.ForeColor = System.Drawing.Color.Red;
         this.m0.Location = new System.Drawing.Point(61, 39);
         this.m0.Name = "m0";
         this.m0.Size = new System.Drawing.Size(112, 24);
         this.m0.TabIndex = 2;
         this.m0.Text = "0";
         this.m0.TextAlign = System.Drawing.ContentAlignment.BottomRight;
         // 
         // gbDisplay
         // 
         this.gbDisplay.AdjustPadding = false;
         this.gbDisplay.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (225)))), ((int) (((byte) (224)))), ((int) (((byte) (219)))));
         this.gbDisplay.Caption = "Display";
         this.gbDisplay.CaptionFont = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.gbDisplay.Controls.Add(this.rbnS);
         this.gbDisplay.Controls.Add(this.rbuS);
         this.gbDisplay.Controls.Add(this.label3);
         this.gbDisplay.Controls.Add(this.edDivisions);
         this.gbDisplay.Controls.Add(this.rbmS);
         this.gbDisplay.Controls.Add(this.udZoomRate);
         this.gbDisplay.Controls.Add(this.label2);
         this.gbDisplay.CornerRadius = 32;
         this.gbDisplay.Dock = System.Windows.Forms.DockStyle.Right;
         this.gbDisplay.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (12)))), ((int) (((byte) (2)))), ((int) (((byte) (98)))));
         this.gbDisplay.Location = new System.Drawing.Point(776, 0);
         this.gbDisplay.Name = "gbDisplay";
         this.gbDisplay.Size = new System.Drawing.Size(175, 115);
         this.gbDisplay.TabIndex = 23;
         this.gbDisplay.Text = "Display";
         // 
         // rbnS
         // 
         this.rbnS.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.rbnS.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.rbnS.Checked = false;
         this.rbnS.Cursor = System.Windows.Forms.Cursors.Hand;
         this.rbnS.Dome = true;
         this.rbnS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
         this.rbnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.rbnS.Location = new System.Drawing.Point(24, 82);
         this.rbnS.Name = "rbnS";
         this.rbnS.Pushable = true;
         this.rbnS.PushedColor = System.Drawing.Color.LawnGreen;
         this.rbnS.RadioGroup = 1;
         this.rbnS.RecessDepth = 0;
         this.rbnS.Size = new System.Drawing.Size(44, 30);
         this.rbnS.TabIndex = 29;
         this.rbnS.Text = "nS";
         this.rbnS.UseVisualStyleBackColor = false;
         this.rbnS.Click += new System.EventHandler(this.edDivisions_Click);
         // 
         // rbuS
         // 
         this.rbuS.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.rbuS.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.rbuS.Checked = false;
         this.rbuS.Cursor = System.Windows.Forms.Cursors.Hand;
         this.rbuS.Dome = true;
         this.rbuS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
         this.rbuS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.rbuS.Location = new System.Drawing.Point(24, 52);
         this.rbuS.Name = "rbuS";
         this.rbuS.Pushable = true;
         this.rbuS.PushedColor = System.Drawing.Color.LawnGreen;
         this.rbuS.RadioGroup = 1;
         this.rbuS.RecessDepth = 0;
         this.rbuS.Size = new System.Drawing.Size(44, 30);
         this.rbuS.TabIndex = 30;
         this.rbuS.Text = "uS";
         this.rbuS.UseVisualStyleBackColor = false;
         this.rbuS.Click += new System.EventHandler(this.edDivisions_Click);
         // 
         // label3
         // 
         this.label3.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(84, 22);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(58, 13);
         this.label3.TabIndex = 6;
         this.label3.Text = "Divisions";
         // 
         // edDivisions
         // 
         this.edDivisions.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.edDivisions.Location = new System.Drawing.Point(84, 41);
         this.edDivisions.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
         this.edDivisions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.edDivisions.Name = "edDivisions";
         this.edDivisions.Size = new System.Drawing.Size(64, 21);
         this.edDivisions.TabIndex = 5;
         this.edDivisions.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
         this.edDivisions.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
         this.edDivisions.Click += new System.EventHandler(this.edDivisions_Click);
         // 
         // rbmS
         // 
         this.rbmS.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.rbmS.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.rbmS.Checked = true;
         this.rbmS.Cursor = System.Windows.Forms.Cursors.Hand;
         this.rbmS.Dome = true;
         this.rbmS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
         this.rbmS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.rbmS.Location = new System.Drawing.Point(24, 22);
         this.rbmS.Name = "rbmS";
         this.rbmS.Pushable = true;
         this.rbmS.PushedColor = System.Drawing.Color.LawnGreen;
         this.rbmS.RadioGroup = 1;
         this.rbmS.RecessDepth = 0;
         this.rbmS.Size = new System.Drawing.Size(44, 30);
         this.rbmS.TabIndex = 28;
         this.rbmS.Text = "mS";
         this.rbmS.UseVisualStyleBackColor = false;
         this.rbmS.Click += new System.EventHandler(this.edDivisions_Click);
         // 
         // udZoomRate
         // 
         this.udZoomRate.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.udZoomRate.Location = new System.Drawing.Point(87, 88);
         this.udZoomRate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
         this.udZoomRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.udZoomRate.Name = "udZoomRate";
         this.udZoomRate.Size = new System.Drawing.Size(64, 21);
         this.udZoomRate.TabIndex = 3;
         this.udZoomRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.udZoomRate.ValueChanged += new System.EventHandler(this.TicksPerDiv_ValueChanged);
         // 
         // label2
         // 
         this.label2.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(84, 69);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(40, 13);
         this.label2.TabIndex = 4;
         this.label2.Text = "Zoom";
         // 
         // LADisplay
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Beige;
         this.Controls.Add(this.MainDisplay);
         this.Controls.Add(this.LabelsDisplay);
         this.Controls.Add(this.pnlTrace);
         this.Controls.Add(this.panel3);
         this.Controls.Add(this.panel1);
         this.Cursor = System.Windows.Forms.Cursors.Default;
         this.DoubleBuffered = true;
         this.Name = "LADisplay";
         this.Size = new System.Drawing.Size(951, 479);
         this.Resize += new System.EventHandler(this.LADisplay_Resize);
         this.panel1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize) (this.trackBar1)).EndInit();
         this.panel3.ResumeLayout(false);
         this.panel3.PerformLayout();
         ((System.ComponentModel.ISupportInitialize) (this.MainDisplay)).EndInit();
         ((System.ComponentModel.ISupportInitialize) (this.LabelsDisplay)).EndInit();
         this.gbMarkers.ResumeLayout(false);
         this.gbMarkers.PerformLayout();
         this.gbDisplay.ResumeLayout(false);
         this.gbDisplay.PerformLayout();
         ((System.ComponentModel.ISupportInitialize) (this.edDivisions)).EndInit();
         ((System.ComponentModel.ISupportInitialize) (this.udZoomRate)).EndInit();
         this.ResumeLayout(false);

         }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Label m0;
      private System.Windows.Forms.TrackBar trackBar1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.NumericUpDown udZoomRate;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.NumericUpDown edDivisions;
      private InstrumentPanel gbMarkers;
      private InstrumentPanel gbDisplay;
      private System.Windows.Forms.Label T0T1;
      private System.Windows.Forms.Label T1;
      private System.Windows.Forms.Label T0;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label mT0;
      private System.Windows.Forms.Label label12;
      private System.Windows.Forms.Label mT1;
      private GaryPerkin.UserControls.Buttons.RoundButton button1;
      private GaryPerkin.UserControls.Buttons.RoundButton rbuS;
      private GaryPerkin.UserControls.Buttons.RoundButton rbnS;
      private GaryPerkin.UserControls.Buttons.RoundButton rbmS;
      private GaryPerkin.UserControls.Buttons.RoundButton cbSnap;
      private GaryPerkin.UserControls.Buttons.RoundButton cbFreq;
      private System.Windows.Forms. PictureBox  LabelsDisplay;
      private System.Windows.Forms.Panel panel3;
      private System.Windows.Forms.Panel panel4;
      private InstrumentPanel pnlTrace;
      private System.Windows.Forms.PictureBox MainDisplay;
      private GaryPerkin.UserControls.Buttons.RoundButton roundButton1;



      }
   }