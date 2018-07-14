namespace SUMPLA_net
   {
   partial class LA2Frm2
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

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent ()
         {
         this.components = new System.ComponentModel.Container();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LA2Frm2));
         this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
         this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
         this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
         this.button2 = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();
         this.colorDialog1 = new System.Windows.Forms.ColorDialog();
         this.Channels = new SUMPLA_net.DSSettings();
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tbLA = new System.Windows.Forms.TabPage();
         this.panel4 = new System.Windows.Forms.Panel();
         this.AnalyzerDisplay = new SUMPLA_net.LADisplay();
         this.gBCapture = new SUMPLA_net.InstrumentPanel();
         this.nBuffSize = new System.Windows.Forms.ComboBox();
         this.cbRLE = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.cbNoiseFilter = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.pnBeforeafter = new SUMPLA_net.InstrumentPanel();
         this.tbRatio = new System.Windows.Forms.TrackBar();
         this.cbClock = new System.Windows.Forms.ComboBox();
         this.label1 = new System.Windows.Forms.Label();
         this.btDemo = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.btRun = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.label9 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.cbRate = new System.Windows.Forms.ComboBox();
         this.label2 = new System.Windows.Forms.Label();
         this.instrumentPanel5 = new SUMPLA_net.InstrumentPanel();
         this.btSaveSamples = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.btLoadSamples = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.tbCapture = new SUMPLA_net.PullApartTabPage();
         this.groupBox3 = new SUMPLA_net.InstrumentPanel();
         this.dgData = new System.Windows.Forms.DataGridView();
         this.instrumentPanel4 = new SUMPLA_net.InstrumentPanel();
         this.btRaw = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.btTrans = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.tbTrigger = new SUMPLA_net.PullApartTabPage();
         this.trigger3 = new SUMPLA_net.Trigger();
         this.trigger2 = new SUMPLA_net.Trigger();
         this.trigger1 = new SUMPLA_net.Trigger();
         this.trigger0 = new SUMPLA_net.Trigger();
         this.panel1 = new System.Windows.Forms.Panel();
         this.cbTrigEnable = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.rbSimple = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.rbComplex = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.panel2 = new System.Windows.Forms.Panel();
         this.tbChannels = new SUMPLA_net.PullApartTabPage();
         this.instrumentPanel3 = new SUMPLA_net.InstrumentPanel();
         this.gvChannels = new System.Windows.Forms.DataGridView();
         this.labelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.visibleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
         this.instrumentPanel1 = new SUMPLA_net.InstrumentPanel();
         this.cg3 = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.cg0 = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.cg2 = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.cg1 = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.PullApartTabPage1 = new SUMPLA_net.PullApartTabPage();
         this.instrumentPanel7 = new SUMPLA_net.InstrumentPanel();
         this.CCOddBG = new SUMPLA_net.ColorChooser();
         this.CCOddFG = new SUMPLA_net.ColorChooser();
         this.CCEvenBG = new SUMPLA_net.ColorChooser();
         this.CCEvenFG = new SUMPLA_net.ColorChooser();
         this.instrumentPanel6 = new SUMPLA_net.InstrumentPanel();
         this.gvBufSize = new System.Windows.Forms.DataGridView();
         this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.gbRates = new SUMPLA_net.InstrumentPanel();
         this.gvSamplerate = new System.Windows.Forms.DataGridView();
         this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.frequencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.panel3 = new System.Windows.Forms.Panel();
         this.instrumentPanel2 = new SUMPLA_net.InstrumentPanel();
         this.btLoadConfig = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.btSaveConfig = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.gbSerial = new SUMPLA_net.InstrumentPanel();
         this.label6 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.nWTOut = new System.Windows.Forms.NumericUpDown();
         this.nRTOut = new System.Windows.Forms.NumericUpDown();
         this.cbBaud = new System.Windows.Forms.ComboBox();
         this.label4 = new System.Windows.Forms.Label();
         this.cbPort = new System.Windows.Forms.ComboBox();
         this.label5 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize) (this.Channels)).BeginInit();
         this.tabControl1.SuspendLayout();
         this.tbLA.SuspendLayout();
         this.panel4.SuspendLayout();
         this.gBCapture.SuspendLayout();
         this.pnBeforeafter.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize) (this.tbRatio)).BeginInit();
         this.instrumentPanel5.SuspendLayout();
         this.tbCapture.SuspendLayout();
         this.groupBox3.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize) (this.dgData)).BeginInit();
         this.instrumentPanel4.SuspendLayout();
         this.tbTrigger.SuspendLayout();
         this.panel1.SuspendLayout();
         this.tbChannels.SuspendLayout();
         this.instrumentPanel3.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize) (this.gvChannels)).BeginInit();
         this.instrumentPanel1.SuspendLayout();
         this.PullApartTabPage1.SuspendLayout();
         this.instrumentPanel7.SuspendLayout();
         this.instrumentPanel6.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize) (this.gvBufSize)).BeginInit();
         this.gbRates.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize) (this.gvSamplerate)).BeginInit();
         this.panel3.SuspendLayout();
         this.instrumentPanel2.SuspendLayout();
         this.gbSerial.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize) (this.nWTOut)).BeginInit();
         ((System.ComponentModel.ISupportInitialize) (this.nRTOut)).BeginInit();
         this.SuspendLayout();
         // 
         // serialPort1
         // 
         this.serialPort1.BaudRate = 115200;
         this.serialPort1.ReadBufferSize = 16000;
         this.serialPort1.ReadTimeout = 10000;
         this.serialPort1.WriteTimeout = 10000;
         // 
         // saveFileDialog1
         // 
         this.saveFileDialog1.DefaultExt = "xml";
         this.saveFileDialog1.Filter = "XML File|*.xml";
         // 
         // openFileDialog1
         // 
         this.openFileDialog1.DefaultExt = "xml";
         this.openFileDialog1.FileName = "openFileDialog1";
         this.openFileDialog1.Filter = "XML File|*.xml";
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(120, 25);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(75, 23);
         this.button2.TabIndex = 1;
         this.button2.Text = "ID";
         this.button2.UseVisualStyleBackColor = true;
         // 
         // button3
         // 
         this.button3.Location = new System.Drawing.Point(28, 25);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(75, 23);
         this.button3.TabIndex = 0;
         this.button3.Text = "Reset LA";
         this.button3.UseVisualStyleBackColor = true;
         // 
         // Channels
         // 
         this.Channels.DataSetName = "DSSettings";
         this.Channels.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // tabControl1
         // 
         this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
         this.tabControl1.Controls.Add(this.tbLA);
         this.tabControl1.Controls.Add(this.tbCapture);
         this.tabControl1.Controls.Add(this.tbTrigger);
         this.tabControl1.Controls.Add(this.tbChannels);
         this.tabControl1.Controls.Add(this.PullApartTabPage1);
         this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabControl1.HotTrack = true;
         this.tabControl1.Location = new System.Drawing.Point(0, 0);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(980, 747);
         this.tabControl1.TabIndex = 1;
         // 
         // tbLA
         // 
         this.tbLA.Controls.Add(this.AnalyzerDisplay);
         this.tbLA.Controls.Add(this.panel4);
         this.tbLA.Location = new System.Drawing.Point(4, 25);
         this.tbLA.Name = "tbLA";
         this.tbLA.Padding = new System.Windows.Forms.Padding(3);
         this.tbLA.Size = new System.Drawing.Size(972, 718);
         this.tbLA.TabIndex = 0;
         this.tbLA.Text = "LA";
         this.tbLA.UseVisualStyleBackColor = true;
         // 
         // panel4
         // 
         this.panel4.Controls.Add(this.gBCapture);
         this.panel4.Controls.Add(this.instrumentPanel5);
         this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel4.Location = new System.Drawing.Point(3, 584);
         this.panel4.Name = "panel4";
         this.panel4.Size = new System.Drawing.Size(966, 131);
         this.panel4.TabIndex = 37;
         // 
         // AnalyzerDisplay
         // 
         this.AnalyzerDisplay.BackColor = System.Drawing.Color.Beige;
         this.AnalyzerDisplay.BackgroundColorEven = System.Drawing.Color.Transparent;
         this.AnalyzerDisplay.BackgroundColorOdd = System.Drawing.Color.Transparent;
         this.AnalyzerDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.AnalyzerDisplay.CausesValidation = false;
         this.AnalyzerDisplay.Cursor = System.Windows.Forms.Cursors.Default;
         this.AnalyzerDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
         this.AnalyzerDisplay.ForegroundColorEven = System.Drawing.Color.Yellow;
         this.AnalyzerDisplay.ForegroundColorOdd = System.Drawing.Color.Cyan;
         this.AnalyzerDisplay.Location = new System.Drawing.Point(3, 3);
         this.AnalyzerDisplay.Name = "AnalyzerDisplay";
         this.AnalyzerDisplay.NumDivisions = 16;
         this.AnalyzerDisplay.SampleFrequency = 1000000;
         this.AnalyzerDisplay.SampleValid = false;
         this.AnalyzerDisplay.SeparationPercent = 15;
         this.AnalyzerDisplay.Size = new System.Drawing.Size(966, 581);
         this.AnalyzerDisplay.TabIndex = 28;
         this.AnalyzerDisplay.VisibleChannelsMask = 0;
         // 
         // gBCapture
         // 
         this.gBCapture.AdjustPadding = false;
         this.gBCapture.BackColor = System.Drawing.Color.WhiteSmoke;
         this.gBCapture.Caption = "Run Control";
         this.gBCapture.CaptionFont = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.gBCapture.CausesValidation = false;
         this.gBCapture.Controls.Add(this.nBuffSize);
         this.gBCapture.Controls.Add(this.cbRLE);
         this.gBCapture.Controls.Add(this.cbNoiseFilter);
         this.gBCapture.Controls.Add(this.pnBeforeafter);
         this.gBCapture.Controls.Add(this.cbClock);
         this.gBCapture.Controls.Add(this.label1);
         this.gBCapture.Controls.Add(this.btDemo);
         this.gBCapture.Controls.Add(this.btRun);
         this.gBCapture.Controls.Add(this.label9);
         this.gBCapture.Controls.Add(this.label8);
         this.gBCapture.Controls.Add(this.cbRate);
         this.gBCapture.Controls.Add(this.label2);
         this.gBCapture.CornerRadius = 32;
         this.gBCapture.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gBCapture.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.gBCapture.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (12)))), ((int) (((byte) (2)))), ((int) (((byte) (98)))));
         this.gBCapture.Location = new System.Drawing.Point(0, 0);
         this.gBCapture.Margin = new System.Windows.Forms.Padding(0);
         this.gBCapture.Name = "gBCapture";
         this.gBCapture.Size = new System.Drawing.Size(836, 131);
         this.gBCapture.TabIndex = 7;
         this.gBCapture.Text = "Capture";
         // 
         // nBuffSize
         // 
         this.nBuffSize.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.Channels, "CurrentSettings.BufferSize", true));
         this.nBuffSize.DisplayMember = "Frequency";
         this.nBuffSize.FormattingEnabled = true;
         this.nBuffSize.Location = new System.Drawing.Point(245, 38);
         this.nBuffSize.Name = "nBuffSize";
         this.nBuffSize.Size = new System.Drawing.Size(78, 24);
         this.nBuffSize.TabIndex = 37;
         this.nBuffSize.ValueMember = "Frequency";
         // 
         // cbRLE
         // 
         this.cbRLE.BackColor = System.Drawing.Color.Goldenrod;
         this.cbRLE.Checked = false;
         this.cbRLE.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.Channels, "CurrentSettings.RLE", true));
         this.cbRLE.Dome = true;
         this.cbRLE.Location = new System.Drawing.Point(490, 74);
         this.cbRLE.Name = "cbRLE";
         this.cbRLE.Pushable = true;
         this.cbRLE.PushedColor = System.Drawing.Color.Yellow;
         this.cbRLE.RadioGroup = 0;
         this.cbRLE.RecessDepth = 0;
         this.cbRLE.Size = new System.Drawing.Size(63, 43);
         this.cbRLE.TabIndex = 36;
         this.cbRLE.Text = "RLE";
         this.cbRLE.UseVisualStyleBackColor = false;
         // 
         // cbNoiseFilter
         // 
         this.cbNoiseFilter.BackColor = System.Drawing.Color.Goldenrod;
         this.cbNoiseFilter.Checked = false;
         this.cbNoiseFilter.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.Channels, "CurrentSettings.NoiseFilter", true));
         this.cbNoiseFilter.Dome = true;
         this.cbNoiseFilter.Location = new System.Drawing.Point(490, 28);
         this.cbNoiseFilter.Name = "cbNoiseFilter";
         this.cbNoiseFilter.Pushable = true;
         this.cbNoiseFilter.PushedColor = System.Drawing.Color.Yellow;
         this.cbNoiseFilter.RadioGroup = 0;
         this.cbNoiseFilter.RecessDepth = 0;
         this.cbNoiseFilter.Size = new System.Drawing.Size(63, 43);
         this.cbNoiseFilter.TabIndex = 35;
         this.cbNoiseFilter.Text = "Noise Filter";
         this.cbNoiseFilter.UseVisualStyleBackColor = false;
         // 
         // pnBeforeafter
         // 
         this.pnBeforeafter.AdjustPadding = true;
         this.pnBeforeafter.Caption = "Before/After Ratio = 50/50";
         this.pnBeforeafter.CaptionFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.pnBeforeafter.Controls.Add(this.tbRatio);
         this.pnBeforeafter.CornerRadius = 12;
         this.pnBeforeafter.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (77)))), ((int) (((byte) (109)))));
         this.pnBeforeafter.Location = new System.Drawing.Point(8, 67);
         this.pnBeforeafter.Name = "pnBeforeafter";
         this.pnBeforeafter.Padding = new System.Windows.Forms.Padding(2);
         this.pnBeforeafter.Size = new System.Drawing.Size(476, 55);
         this.pnBeforeafter.TabIndex = 34;
         // 
         // tbRatio
         // 
         this.tbRatio.BackColor = System.Drawing.Color.WhiteSmoke;
         this.tbRatio.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.tbRatio.LargeChange = 10;
         this.tbRatio.Location = new System.Drawing.Point(2, 23);
         this.tbRatio.Margin = new System.Windows.Forms.Padding(0);
         this.tbRatio.Maximum = 100;
         this.tbRatio.MaximumSize = new System.Drawing.Size(0, 30);
         this.tbRatio.Name = "tbRatio";
         this.tbRatio.Size = new System.Drawing.Size(0, 30);
         this.tbRatio.TabIndex = 31;
         this.tbRatio.TickFrequency = 10;
         this.tbRatio.TickStyle = System.Windows.Forms.TickStyle.None;
         this.tbRatio.Value = 50;
         this.tbRatio.ValueChanged += new System.EventHandler(this.tbRatio_ValueChanged);
         // 
         // cbClock
         // 
         this.cbClock.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.Channels, "CurrentSettings.SamplingClock", true));
         this.cbClock.FormattingEnabled = true;
         this.cbClock.Items.AddRange(new object[] {
            "Internal",
            "External-Rising",
            "External-Falling"});
         this.cbClock.Location = new System.Drawing.Point(380, 37);
         this.cbClock.Name = "cbClock";
         this.cbClock.Size = new System.Drawing.Size(104, 24);
         this.cbClock.TabIndex = 32;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(329, 41);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(50, 17);
         this.label1.TabIndex = 31;
         this.label1.Text = " Clock";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // btDemo
         // 
         this.btDemo.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.btDemo.BackColor = System.Drawing.Color.Aquamarine;
         this.btDemo.Checked = false;
         this.btDemo.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btDemo.Dome = true;
         this.btDemo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
         this.btDemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btDemo.Location = new System.Drawing.Point(744, 74);
         this.btDemo.Name = "btDemo";
         this.btDemo.Pushable = false;
         this.btDemo.PushedColor = System.Drawing.Color.Empty;
         this.btDemo.RadioGroup = 0;
         this.btDemo.RecessDepth = 0;
         this.btDemo.Size = new System.Drawing.Size(63, 43);
         this.btDemo.TabIndex = 30;
         this.btDemo.Text = "Demo";
         this.btDemo.UseVisualStyleBackColor = false;
         this.btDemo.Click += new System.EventHandler(this.btDemo_Click);
         // 
         // btRun
         // 
         this.btRun.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.btRun.BackColor = System.Drawing.Color.GreenYellow;
         this.btRun.Checked = false;
         this.btRun.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btRun.Dome = true;
         this.btRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
         this.btRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btRun.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.btRun.Location = new System.Drawing.Point(744, 28);
         this.btRun.Name = "btRun";
         this.btRun.Pushable = false;
         this.btRun.PushedColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))), ((int) (((byte) (128)))));
         this.btRun.RadioGroup = 0;
         this.btRun.RecessDepth = 0;
         this.btRun.Size = new System.Drawing.Size(63, 43);
         this.btRun.TabIndex = 27;
         this.btRun.Text = "Run";
         this.btRun.UseVisualStyleBackColor = false;
         this.btRun.Click += new System.EventHandler(this.btRun_Click);
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(366, 19);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(0, 17);
         this.label9.TabIndex = 22;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(154, 41);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(85, 17);
         this.label8.TabIndex = 20;
         this.label8.Text = "Buffer Size";
         // 
         // cbRate
         // 
         this.cbRate.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.Channels, "CurrentSettings.CaptureRate", true));
         this.cbRate.DisplayMember = "Frequency";
         this.cbRate.FormattingEnabled = true;
         this.cbRate.Location = new System.Drawing.Point(47, 37);
         this.cbRate.Name = "cbRate";
         this.cbRate.Size = new System.Drawing.Size(87, 24);
         this.cbRate.TabIndex = 0;
         this.cbRate.Text = "System.Data.DataViewManagerListItemTypeDescriptor";
         this.cbRate.ValueMember = "Frequency";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(4, 41);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(40, 17);
         this.label2.TabIndex = 1;
         this.label2.Text = "Rate";
         // 
         // instrumentPanel5
         // 
         this.instrumentPanel5.AdjustPadding = false;
         this.instrumentPanel5.Caption = "Trace";
         this.instrumentPanel5.CaptionFont = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.instrumentPanel5.CausesValidation = false;
         this.instrumentPanel5.Controls.Add(this.btSaveSamples);
         this.instrumentPanel5.Controls.Add(this.btLoadSamples);
         this.instrumentPanel5.CornerRadius = 12;
         this.instrumentPanel5.Dock = System.Windows.Forms.DockStyle.Right;
         this.instrumentPanel5.ForeColor = System.Drawing.Color.SteelBlue;
         this.instrumentPanel5.Location = new System.Drawing.Point(836, 0);
         this.instrumentPanel5.Name = "instrumentPanel5";
         this.instrumentPanel5.Size = new System.Drawing.Size(130, 131);
         this.instrumentPanel5.TabIndex = 8;
         // 
         // btSaveSamples
         // 
         this.btSaveSamples.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.btSaveSamples.BackColor = System.Drawing.Color.MediumTurquoise;
         this.btSaveSamples.Checked = false;
         this.btSaveSamples.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btSaveSamples.Dome = true;
         this.btSaveSamples.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
         this.btSaveSamples.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btSaveSamples.Location = new System.Drawing.Point(34, 28);
         this.btSaveSamples.Name = "btSaveSamples";
         this.btSaveSamples.Pushable = false;
         this.btSaveSamples.PushedColor = System.Drawing.Color.Empty;
         this.btSaveSamples.RadioGroup = 0;
         this.btSaveSamples.RecessDepth = 0;
         this.btSaveSamples.Size = new System.Drawing.Size(63, 43);
         this.btSaveSamples.TabIndex = 28;
         this.btSaveSamples.Text = "Save";
         this.btSaveSamples.UseVisualStyleBackColor = false;
         this.btSaveSamples.Click += new System.EventHandler(this.btSaveSamples_Click);
         // 
         // btLoadSamples
         // 
         this.btLoadSamples.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.btLoadSamples.BackColor = System.Drawing.Color.MediumTurquoise;
         this.btLoadSamples.Checked = false;
         this.btLoadSamples.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btLoadSamples.Dome = true;
         this.btLoadSamples.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
         this.btLoadSamples.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btLoadSamples.Location = new System.Drawing.Point(34, 74);
         this.btLoadSamples.Name = "btLoadSamples";
         this.btLoadSamples.Pushable = false;
         this.btLoadSamples.PushedColor = System.Drawing.Color.Empty;
         this.btLoadSamples.RadioGroup = 0;
         this.btLoadSamples.RecessDepth = 0;
         this.btLoadSamples.Size = new System.Drawing.Size(63, 43);
         this.btLoadSamples.TabIndex = 29;
         this.btLoadSamples.Text = "Load";
         this.btLoadSamples.UseVisualStyleBackColor = false;
         this.btLoadSamples.Click += new System.EventHandler(this.btLoadSamples_Click);
         // 
         // tbCapture
         // 
         this.tbCapture.Controls.Add(this.groupBox3);
         this.tbCapture.Controls.Add(this.instrumentPanel4);
         this.tbCapture.Location = new System.Drawing.Point(4, 25);
         this.tbCapture.Name = "tbCapture";
         this.tbCapture.Padding = new System.Windows.Forms.Padding(3);
         this.tbCapture.Size = new System.Drawing.Size(972, 718);
         this.tbCapture.TabIndex = 5;
         this.tbCapture.TabMode = SUMPLA_net.TabMode.Dock;
         this.tbCapture.Text = "Captured Data";
         this.tbCapture.UseVisualStyleBackColor = true;
         // 
         // groupBox3
         // 
         this.groupBox3.AdjustPadding = false;
         this.groupBox3.Caption = "Captured Data";
         this.groupBox3.CaptionFont = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.groupBox3.Controls.Add(this.dgData);
         this.groupBox3.CornerRadius = 12;
         this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
         this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (12)))), ((int) (((byte) (2)))), ((int) (((byte) (98)))));
         this.groupBox3.Location = new System.Drawing.Point(3, 103);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 22, 2, 2);
         this.groupBox3.Size = new System.Drawing.Size(966, 612);
         this.groupBox3.TabIndex = 9;
         this.groupBox3.Text = "Data";
         // 
         // dgData
         // 
         this.dgData.AllowUserToDeleteRows = false;
         dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
         this.dgData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
         this.dgData.BackgroundColor = System.Drawing.Color.Azure;
         this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgData.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dgData.Location = new System.Drawing.Point(2, 22);
         this.dgData.Name = "dgData";
         this.dgData.Size = new System.Drawing.Size(962, 588);
         this.dgData.TabIndex = 4;
         // 
         // instrumentPanel4
         // 
         this.instrumentPanel4.AdjustPadding = false;
         this.instrumentPanel4.Caption = "Data Source";
         this.instrumentPanel4.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.instrumentPanel4.Controls.Add(this.btRaw);
         this.instrumentPanel4.Controls.Add(this.btTrans);
         this.instrumentPanel4.CornerRadius = 12;
         this.instrumentPanel4.Dock = System.Windows.Forms.DockStyle.Top;
         this.instrumentPanel4.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (12)))), ((int) (((byte) (2)))), ((int) (((byte) (98)))));
         this.instrumentPanel4.Location = new System.Drawing.Point(3, 3);
         this.instrumentPanel4.Name = "instrumentPanel4";
         this.instrumentPanel4.Size = new System.Drawing.Size(966, 100);
         this.instrumentPanel4.TabIndex = 10;
         // 
         // btRaw
         // 
         this.btRaw.BackColor = System.Drawing.Color.CadetBlue;
         this.btRaw.Checked = true;
         this.btRaw.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btRaw.Dome = true;
         this.btRaw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
         this.btRaw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btRaw.Location = new System.Drawing.Point(17, 20);
         this.btRaw.Name = "btRaw";
         this.btRaw.Pushable = true;
         this.btRaw.PushedColor = System.Drawing.Color.LightSkyBlue;
         this.btRaw.RadioGroup = 2;
         this.btRaw.RecessDepth = 0;
         this.btRaw.Size = new System.Drawing.Size(92, 64);
         this.btRaw.TabIndex = 31;
         this.btRaw.Text = "Raw";
         this.btRaw.UseVisualStyleBackColor = false;
         this.btRaw.Click += new System.EventHandler(this.btRaw_Click);
         // 
         // btTrans
         // 
         this.btTrans.BackColor = System.Drawing.Color.CadetBlue;
         this.btTrans.Checked = false;
         this.btTrans.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btTrans.Dome = true;
         this.btTrans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
         this.btTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btTrans.Location = new System.Drawing.Point(111, 20);
         this.btTrans.Name = "btTrans";
         this.btTrans.Pushable = true;
         this.btTrans.PushedColor = System.Drawing.Color.LightSkyBlue;
         this.btTrans.RadioGroup = 2;
         this.btTrans.RecessDepth = 0;
         this.btTrans.Size = new System.Drawing.Size(92, 64);
         this.btTrans.TabIndex = 32;
         this.btTrans.Text = "Transitions";
         this.btTrans.UseVisualStyleBackColor = false;
         this.btTrans.Click += new System.EventHandler(this.btRaw_Click);
         // 
         // tbTrigger
         // 
         this.tbTrigger.BackColor = System.Drawing.Color.Cornsilk;
         this.tbTrigger.Controls.Add(this.trigger3);
         this.tbTrigger.Controls.Add(this.trigger2);
         this.tbTrigger.Controls.Add(this.trigger1);
         this.tbTrigger.Controls.Add(this.trigger0);
         this.tbTrigger.Controls.Add(this.panel1);
         this.tbTrigger.Controls.Add(this.panel2);
         this.tbTrigger.ForeColor = System.Drawing.Color.Maroon;
         this.tbTrigger.Location = new System.Drawing.Point(4, 25);
         this.tbTrigger.Name = "tbTrigger";
         this.tbTrigger.Padding = new System.Windows.Forms.Padding(3);
         this.tbTrigger.Size = new System.Drawing.Size(972, 718);
         this.tbTrigger.TabIndex = 1;
         this.tbTrigger.TabMode = SUMPLA_net.TabMode.Dock;
         this.tbTrigger.Text = "Trigger";
         // 
         // trigger3
         // 
         this.trigger3.BackColor = System.Drawing.Color.LavenderBlush;
         this.trigger3.CausesValidation = false;
         this.trigger3.Dock = System.Windows.Forms.DockStyle.Top;
         this.trigger3.HeaderBG = System.Drawing.Color.Thistle;
         this.trigger3.HeaderFG = System.Drawing.Color.Indigo;
         this.trigger3.Level = ((byte) (0));
         this.trigger3.Location = new System.Drawing.Point(3, 457);
         this.trigger3.Name = "trigger3";
         this.trigger3.Size = new System.Drawing.Size(966, 136);
         this.trigger3.StageNum = 3;
         this.trigger3.TabIndex = 37;
         // 
         // trigger2
         // 
         this.trigger2.BackColor = System.Drawing.Color.Azure;
         this.trigger2.CausesValidation = false;
         this.trigger2.Dock = System.Windows.Forms.DockStyle.Top;
         this.trigger2.HeaderBG = System.Drawing.Color.LightBlue;
         this.trigger2.HeaderFG = System.Drawing.Color.SteelBlue;
         this.trigger2.Level = ((byte) (0));
         this.trigger2.Location = new System.Drawing.Point(3, 321);
         this.trigger2.Name = "trigger2";
         this.trigger2.Size = new System.Drawing.Size(966, 136);
         this.trigger2.StageNum = 2;
         this.trigger2.TabIndex = 36;
         // 
         // trigger1
         // 
         this.trigger1.BackColor = System.Drawing.Color.Honeydew;
         this.trigger1.CausesValidation = false;
         this.trigger1.Dock = System.Windows.Forms.DockStyle.Top;
         this.trigger1.ForeColor = System.Drawing.Color.ForestGreen;
         this.trigger1.HeaderBG = System.Drawing.Color.Honeydew;
         this.trigger1.HeaderFG = System.Drawing.Color.ForestGreen;
         this.trigger1.Level = ((byte) (0));
         this.trigger1.Location = new System.Drawing.Point(3, 185);
         this.trigger1.Name = "trigger1";
         this.trigger1.Size = new System.Drawing.Size(966, 136);
         this.trigger1.StageNum = 1;
         this.trigger1.TabIndex = 35;
         // 
         // trigger0
         // 
         this.trigger0.CausesValidation = false;
         this.trigger0.Dock = System.Windows.Forms.DockStyle.Top;
         this.trigger0.HeaderBG = System.Drawing.Color.LightGoldenrodYellow;
         this.trigger0.HeaderFG = System.Drawing.Color.LightSeaGreen;
         this.trigger0.Level = ((byte) (0));
         this.trigger0.Location = new System.Drawing.Point(3, 49);
         this.trigger0.Name = "trigger0";
         this.trigger0.Size = new System.Drawing.Size(966, 136);
         this.trigger0.StageNum = 0;
         this.trigger0.TabIndex = 34;
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.cbTrigEnable);
         this.panel1.Controls.Add(this.rbSimple);
         this.panel1.Controls.Add(this.rbComplex);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(3, 3);
         this.panel1.Name = "panel1";
         this.panel1.Padding = new System.Windows.Forms.Padding(2);
         this.panel1.Size = new System.Drawing.Size(966, 46);
         this.panel1.TabIndex = 38;
         // 
         // cbTrigEnable
         // 
         this.cbTrigEnable.BackColor = System.Drawing.Color.Tomato;
         this.cbTrigEnable.Checked = false;
         this.cbTrigEnable.Cursor = System.Windows.Forms.Cursors.Hand;
         this.cbTrigEnable.Dock = System.Windows.Forms.DockStyle.Left;
         this.cbTrigEnable.Dome = true;
         this.cbTrigEnable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
         this.cbTrigEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.cbTrigEnable.Location = new System.Drawing.Point(2, 2);
         this.cbTrigEnable.Name = "cbTrigEnable";
         this.cbTrigEnable.Pushable = true;
         this.cbTrigEnable.PushedColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))), ((int) (((byte) (128)))));
         this.cbTrigEnable.RadioGroup = 0;
         this.cbTrigEnable.RecessDepth = 0;
         this.cbTrigEnable.Size = new System.Drawing.Size(63, 42);
         this.cbTrigEnable.TabIndex = 28;
         this.cbTrigEnable.Text = "Enable";
         this.cbTrigEnable.UseVisualStyleBackColor = false;
         // 
         // rbSimple
         // 
         this.rbSimple.BackColor = System.Drawing.Color.CadetBlue;
         this.rbSimple.Checked = true;
         this.rbSimple.Cursor = System.Windows.Forms.Cursors.Hand;
         this.rbSimple.Dock = System.Windows.Forms.DockStyle.Right;
         this.rbSimple.Dome = true;
         this.rbSimple.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
         this.rbSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.rbSimple.Location = new System.Drawing.Point(838, 2);
         this.rbSimple.Name = "rbSimple";
         this.rbSimple.Pushable = true;
         this.rbSimple.PushedColor = System.Drawing.Color.LightSkyBlue;
         this.rbSimple.RadioGroup = 2;
         this.rbSimple.RecessDepth = 0;
         this.rbSimple.Size = new System.Drawing.Size(63, 42);
         this.rbSimple.TabIndex = 29;
         this.rbSimple.Text = "Simple";
         this.rbSimple.UseVisualStyleBackColor = false;
         this.rbSimple.Click += new System.EventHandler(this.rbSimple_Click);
         // 
         // rbComplex
         // 
         this.rbComplex.BackColor = System.Drawing.Color.CadetBlue;
         this.rbComplex.Checked = false;
         this.rbComplex.Cursor = System.Windows.Forms.Cursors.Hand;
         this.rbComplex.Dock = System.Windows.Forms.DockStyle.Right;
         this.rbComplex.Dome = true;
         this.rbComplex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
         this.rbComplex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.rbComplex.Location = new System.Drawing.Point(901, 2);
         this.rbComplex.Name = "rbComplex";
         this.rbComplex.Pushable = true;
         this.rbComplex.PushedColor = System.Drawing.Color.LightSkyBlue;
         this.rbComplex.RadioGroup = 2;
         this.rbComplex.RecessDepth = 0;
         this.rbComplex.Size = new System.Drawing.Size(63, 42);
         this.rbComplex.TabIndex = 30;
         this.rbComplex.Text = "Complex";
         this.rbComplex.UseVisualStyleBackColor = false;
         this.rbComplex.Click += new System.EventHandler(this.rbSimple_Click);
         // 
         // panel2
         // 
         this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel2.Location = new System.Drawing.Point(3, 645);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(966, 70);
         this.panel2.TabIndex = 34;
         // 
         // tbChannels
         // 
         this.tbChannels.Controls.Add(this.instrumentPanel3);
         this.tbChannels.Controls.Add(this.instrumentPanel1);
         this.tbChannels.Location = new System.Drawing.Point(4, 25);
         this.tbChannels.Name = "tbChannels";
         this.tbChannels.Padding = new System.Windows.Forms.Padding(3);
         this.tbChannels.Size = new System.Drawing.Size(972, 718);
         this.tbChannels.TabIndex = 3;
         this.tbChannels.TabMode = SUMPLA_net.TabMode.Dock;
         this.tbChannels.Text = "Channels";
         this.tbChannels.UseVisualStyleBackColor = true;
         // 
         // instrumentPanel3
         // 
         this.instrumentPanel3.AdjustPadding = true;
         this.instrumentPanel3.BackColor = System.Drawing.Color.WhiteSmoke;
         this.instrumentPanel3.Caption = "Channels Labels / Visibility";
         this.instrumentPanel3.CaptionFont = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.instrumentPanel3.Controls.Add(this.gvChannels);
         this.instrumentPanel3.CornerRadius = 12;
         this.instrumentPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
         this.instrumentPanel3.ForeColor = System.Drawing.Color.SteelBlue;
         this.instrumentPanel3.Location = new System.Drawing.Point(189, 3);
         this.instrumentPanel3.Name = "instrumentPanel3";
         this.instrumentPanel3.Padding = new System.Windows.Forms.Padding(1, 22, 1, 1);
         this.instrumentPanel3.Size = new System.Drawing.Size(780, 712);
         this.instrumentPanel3.TabIndex = 28;
         // 
         // gvChannels
         // 
         dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
         this.gvChannels.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
         this.gvChannels.AutoGenerateColumns = false;
         this.gvChannels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
         this.gvChannels.BackgroundColor = System.Drawing.Color.Azure;
         this.gvChannels.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.gvChannels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.gvChannels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.labelDataGridViewTextBoxColumn,
            this.visibleDataGridViewCheckBoxColumn});
         this.gvChannels.DataMember = "tblChannels";
         this.gvChannels.DataSource = this.Channels;
         this.gvChannels.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gvChannels.Location = new System.Drawing.Point(1, 22);
         this.gvChannels.Name = "gvChannels";
         this.gvChannels.Size = new System.Drawing.Size(778, 689);
         this.gvChannels.TabIndex = 1;
         // 
         // labelDataGridViewTextBoxColumn
         // 
         this.labelDataGridViewTextBoxColumn.DataPropertyName = "Label";
         this.labelDataGridViewTextBoxColumn.HeaderText = "Label";
         this.labelDataGridViewTextBoxColumn.Name = "labelDataGridViewTextBoxColumn";
         this.labelDataGridViewTextBoxColumn.Width = 58;
         // 
         // visibleDataGridViewCheckBoxColumn
         // 
         this.visibleDataGridViewCheckBoxColumn.DataPropertyName = "Visible";
         this.visibleDataGridViewCheckBoxColumn.HeaderText = "Visible";
         this.visibleDataGridViewCheckBoxColumn.Name = "visibleDataGridViewCheckBoxColumn";
         this.visibleDataGridViewCheckBoxColumn.Width = 43;
         // 
         // instrumentPanel1
         // 
         this.instrumentPanel1.AdjustPadding = false;
         this.instrumentPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
         this.instrumentPanel1.Caption = "Groups";
         this.instrumentPanel1.CaptionFont = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.instrumentPanel1.Controls.Add(this.cg3);
         this.instrumentPanel1.Controls.Add(this.cg0);
         this.instrumentPanel1.Controls.Add(this.cg2);
         this.instrumentPanel1.Controls.Add(this.cg1);
         this.instrumentPanel1.CornerRadius = 12;
         this.instrumentPanel1.Dock = System.Windows.Forms.DockStyle.Left;
         this.instrumentPanel1.ForeColor = System.Drawing.Color.SteelBlue;
         this.instrumentPanel1.Location = new System.Drawing.Point(3, 3);
         this.instrumentPanel1.Name = "instrumentPanel1";
         this.instrumentPanel1.Size = new System.Drawing.Size(186, 712);
         this.instrumentPanel1.TabIndex = 27;
         // 
         // cg3
         // 
         this.cg3.BackColor = System.Drawing.Color.Goldenrod;
         this.cg3.Checked = true;
         this.cg3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.Channels, "CurrentSettings.ChannelGroup_3", true));
         this.cg3.Dome = true;
         this.cg3.Location = new System.Drawing.Point(63, 240);
         this.cg3.Name = "cg3";
         this.cg3.Pushable = true;
         this.cg3.PushedColor = System.Drawing.Color.Yellow;
         this.cg3.RadioGroup = 0;
         this.cg3.RecessDepth = 0;
         this.cg3.Size = new System.Drawing.Size(56, 50);
         this.cg3.TabIndex = 3;
         this.cg3.Text = "Group 3";
         this.cg3.UseVisualStyleBackColor = false;
         // 
         // cg0
         // 
         this.cg0.BackColor = System.Drawing.Color.Goldenrod;
         this.cg0.Checked = false;
         this.cg0.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.Channels, "CurrentSettings.ChannelGroup_0", true));
         this.cg0.Dome = true;
         this.cg0.Location = new System.Drawing.Point(63, 50);
         this.cg0.Name = "cg0";
         this.cg0.Pushable = true;
         this.cg0.PushedColor = System.Drawing.Color.Yellow;
         this.cg0.RadioGroup = 0;
         this.cg0.RecessDepth = 0;
         this.cg0.Size = new System.Drawing.Size(56, 50);
         this.cg0.TabIndex = 0;
         this.cg0.Text = "Group 0";
         this.cg0.UseVisualStyleBackColor = false;
         // 
         // cg2
         // 
         this.cg2.BackColor = System.Drawing.Color.Goldenrod;
         this.cg2.Checked = true;
         this.cg2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.Channels, "CurrentSettings.ChannelGroup_2", true));
         this.cg2.Dome = true;
         this.cg2.Location = new System.Drawing.Point(63, 169);
         this.cg2.Name = "cg2";
         this.cg2.Pushable = true;
         this.cg2.PushedColor = System.Drawing.Color.Yellow;
         this.cg2.RadioGroup = 0;
         this.cg2.RecessDepth = 0;
         this.cg2.Size = new System.Drawing.Size(56, 50);
         this.cg2.TabIndex = 2;
         this.cg2.Text = "Group 2";
         this.cg2.UseVisualStyleBackColor = false;
         // 
         // cg1
         // 
         this.cg1.BackColor = System.Drawing.Color.Goldenrod;
         this.cg1.Checked = false;
         this.cg1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.Channels, "CurrentSettings.ChannelGroup_1", true));
         this.cg1.Dome = true;
         this.cg1.Location = new System.Drawing.Point(63, 106);
         this.cg1.Name = "cg1";
         this.cg1.Pushable = true;
         this.cg1.PushedColor = System.Drawing.Color.Yellow;
         this.cg1.RadioGroup = 0;
         this.cg1.RecessDepth = 0;
         this.cg1.Size = new System.Drawing.Size(56, 50);
         this.cg1.TabIndex = 1;
         this.cg1.Text = "Group 1";
         this.cg1.UseVisualStyleBackColor = false;
         // 
         // PullApartTabPage1
         // 
         this.PullApartTabPage1.Controls.Add(this.instrumentPanel7);
         this.PullApartTabPage1.Controls.Add(this.instrumentPanel6);
         this.PullApartTabPage1.Controls.Add(this.gbRates);
         this.PullApartTabPage1.Controls.Add(this.panel3);
         this.PullApartTabPage1.Location = new System.Drawing.Point(4, 25);
         this.PullApartTabPage1.Name = "PullApartTabPage1";
         this.PullApartTabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.PullApartTabPage1.Size = new System.Drawing.Size(972, 718);
         this.PullApartTabPage1.TabIndex = 4;
         this.PullApartTabPage1.TabMode = SUMPLA_net.TabMode.Dock;
         this.PullApartTabPage1.Text = "Configuration";
         this.PullApartTabPage1.UseVisualStyleBackColor = true;
         // 
         // instrumentPanel7
         // 
         this.instrumentPanel7.AdjustPadding = true;
         this.instrumentPanel7.BackColor = System.Drawing.Color.Bisque;
         this.instrumentPanel7.Caption = "Display";
         this.instrumentPanel7.CaptionFont = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.instrumentPanel7.Controls.Add(this.CCOddBG);
         this.instrumentPanel7.Controls.Add(this.CCOddFG);
         this.instrumentPanel7.Controls.Add(this.CCEvenBG);
         this.instrumentPanel7.Controls.Add(this.CCEvenFG);
         this.instrumentPanel7.CornerRadius = 12;
         this.instrumentPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
         this.instrumentPanel7.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (12)))), ((int) (((byte) (2)))), ((int) (((byte) (98)))));
         this.instrumentPanel7.Location = new System.Drawing.Point(509, 103);
         this.instrumentPanel7.Name = "instrumentPanel7";
         this.instrumentPanel7.Padding = new System.Windows.Forms.Padding(2, 28, 2, 2);
         this.instrumentPanel7.Size = new System.Drawing.Size(460, 612);
         this.instrumentPanel7.TabIndex = 28;
         // 
         // CCOddBG
         // 
         this.CCOddBG.ARGBColor = -4144960;
         this.CCOddBG.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
         this.CCOddBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.CCOddBG.Caption = "Odd Background";
         this.CCOddBG.CausesValidation = false;
         this.CCOddBG.Dock = System.Windows.Forms.DockStyle.Top;
         this.CCOddBG.Location = new System.Drawing.Point(2, 160);
         this.CCOddBG.Name = "CCOddBG";
         this.CCOddBG.SelectedColor = System.Drawing.Color.Silver;
         this.CCOddBG.Size = new System.Drawing.Size(456, 44);
         this.CCOddBG.TabIndex = 3;
         this.CCOddBG.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(this.CCEvenFG_PropertyChanged);
         // 
         // CCOddFG
         // 
         this.CCOddFG.ARGBColor = -4144960;
         this.CCOddFG.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
         this.CCOddFG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.CCOddFG.Caption = "Odd Trace";
         this.CCOddFG.CausesValidation = false;
         this.CCOddFG.Dock = System.Windows.Forms.DockStyle.Top;
         this.CCOddFG.Location = new System.Drawing.Point(2, 116);
         this.CCOddFG.Name = "CCOddFG";
         this.CCOddFG.SelectedColor = System.Drawing.Color.Silver;
         this.CCOddFG.Size = new System.Drawing.Size(456, 44);
         this.CCOddFG.TabIndex = 2;
         this.CCOddFG.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(this.CCEvenFG_PropertyChanged);
         // 
         // CCEvenBG
         // 
         this.CCEvenBG.ARGBColor = -4144960;
         this.CCEvenBG.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
         this.CCEvenBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.CCEvenBG.Caption = "Even Background";
         this.CCEvenBG.CausesValidation = false;
         this.CCEvenBG.Dock = System.Windows.Forms.DockStyle.Top;
         this.CCEvenBG.Location = new System.Drawing.Point(2, 72);
         this.CCEvenBG.Name = "CCEvenBG";
         this.CCEvenBG.SelectedColor = System.Drawing.Color.Silver;
         this.CCEvenBG.Size = new System.Drawing.Size(456, 44);
         this.CCEvenBG.TabIndex = 1;
         this.CCEvenBG.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(this.CCEvenFG_PropertyChanged);
         // 
         // CCEvenFG
         // 
         this.CCEvenFG.ARGBColor = -2572328;
         this.CCEvenFG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.CCEvenFG.Caption = "Even Trace";
         this.CCEvenFG.Dock = System.Windows.Forms.DockStyle.Top;
         this.CCEvenFG.Location = new System.Drawing.Point(2, 28);
         this.CCEvenFG.Name = "CCEvenFG";
         this.CCEvenFG.SelectedColor = System.Drawing.Color.Thistle;
         this.CCEvenFG.Size = new System.Drawing.Size(456, 44);
         this.CCEvenFG.TabIndex = 0;
         this.CCEvenFG.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(this.CCEvenFG_PropertyChanged);
         // 
         // instrumentPanel6
         // 
         this.instrumentPanel6.AdjustPadding = true;
         this.instrumentPanel6.BackColor = System.Drawing.Color.FloralWhite;
         this.instrumentPanel6.Caption = "Buffer Sizes";
         this.instrumentPanel6.CaptionFont = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.instrumentPanel6.Controls.Add(this.gvBufSize);
         this.instrumentPanel6.CornerRadius = 12;
         this.instrumentPanel6.Dock = System.Windows.Forms.DockStyle.Left;
         this.instrumentPanel6.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.instrumentPanel6.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (12)))), ((int) (((byte) (2)))), ((int) (((byte) (98)))));
         this.instrumentPanel6.Location = new System.Drawing.Point(256, 103);
         this.instrumentPanel6.Name = "instrumentPanel6";
         this.instrumentPanel6.Padding = new System.Windows.Forms.Padding(2, 28, 2, 2);
         this.instrumentPanel6.Size = new System.Drawing.Size(253, 612);
         this.instrumentPanel6.TabIndex = 10;
         this.instrumentPanel6.Text = "Sampling Rates";
         // 
         // gvBufSize
         // 
         this.gvBufSize.AllowUserToDeleteRows = false;
         dataGridViewCellStyle3.BackColor = System.Drawing.Color.Honeydew;
         this.gvBufSize.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
         this.gvBufSize.AutoGenerateColumns = false;
         this.gvBufSize.BackgroundColor = System.Drawing.Color.Azure;
         this.gvBufSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.gvBufSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.gvBufSize.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn});
         this.gvBufSize.DataMember = "BufferSizes";
         this.gvBufSize.DataSource = this.Channels;
         this.gvBufSize.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gvBufSize.Location = new System.Drawing.Point(2, 28);
         this.gvBufSize.Name = "gvBufSize";
         this.gvBufSize.Size = new System.Drawing.Size(249, 582);
         this.gvBufSize.TabIndex = 3;
         // 
         // nameDataGridViewTextBoxColumn
         // 
         this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
         this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
         this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
         // 
         // sizeDataGridViewTextBoxColumn
         // 
         this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
         this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
         this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
         // 
         // gbRates
         // 
         this.gbRates.AdjustPadding = false;
         this.gbRates.BackColor = System.Drawing.Color.FloralWhite;
         this.gbRates.Caption = "Sample Rates";
         this.gbRates.CaptionFont = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.gbRates.Controls.Add(this.gvSamplerate);
         this.gbRates.CornerRadius = 12;
         this.gbRates.Dock = System.Windows.Forms.DockStyle.Left;
         this.gbRates.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.gbRates.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (12)))), ((int) (((byte) (2)))), ((int) (((byte) (98)))));
         this.gbRates.Location = new System.Drawing.Point(3, 103);
         this.gbRates.Name = "gbRates";
         this.gbRates.Padding = new System.Windows.Forms.Padding(2, 28, 2, 2);
         this.gbRates.Size = new System.Drawing.Size(253, 612);
         this.gbRates.TabIndex = 1;
         this.gbRates.Text = "Sampling Rates";
         // 
         // gvSamplerate
         // 
         this.gvSamplerate.AllowUserToDeleteRows = false;
         dataGridViewCellStyle4.BackColor = System.Drawing.Color.Honeydew;
         this.gvSamplerate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
         this.gvSamplerate.AutoGenerateColumns = false;
         this.gvSamplerate.BackgroundColor = System.Drawing.Color.Azure;
         this.gvSamplerate.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.gvSamplerate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.gvSamplerate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.frequencyDataGridViewTextBoxColumn});
         this.gvSamplerate.DataMember = "SampleRates";
         this.gvSamplerate.DataSource = this.Channels;
         this.gvSamplerate.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gvSamplerate.Location = new System.Drawing.Point(2, 28);
         this.gvSamplerate.Name = "gvSamplerate";
         this.gvSamplerate.Size = new System.Drawing.Size(249, 582);
         this.gvSamplerate.TabIndex = 3;
         // 
         // nameDataGridViewTextBoxColumn1
         // 
         this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
         this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
         this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
         // 
         // frequencyDataGridViewTextBoxColumn
         // 
         this.frequencyDataGridViewTextBoxColumn.DataPropertyName = "Frequency";
         this.frequencyDataGridViewTextBoxColumn.HeaderText = "Frequency";
         this.frequencyDataGridViewTextBoxColumn.Name = "frequencyDataGridViewTextBoxColumn";
         // 
         // panel3
         // 
         this.panel3.Controls.Add(this.instrumentPanel2);
         this.panel3.Controls.Add(this.gbSerial);
         this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel3.Location = new System.Drawing.Point(3, 3);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(966, 100);
         this.panel3.TabIndex = 9;
         // 
         // instrumentPanel2
         // 
         this.instrumentPanel2.AdjustPadding = false;
         this.instrumentPanel2.BackColor = System.Drawing.Color.FloralWhite;
         this.instrumentPanel2.Caption = "Settings";
         this.instrumentPanel2.CaptionFont = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.instrumentPanel2.Controls.Add(this.btLoadConfig);
         this.instrumentPanel2.Controls.Add(this.btSaveConfig);
         this.instrumentPanel2.CornerRadius = 12;
         this.instrumentPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.instrumentPanel2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (12)))), ((int) (((byte) (2)))), ((int) (((byte) (98)))));
         this.instrumentPanel2.Location = new System.Drawing.Point(506, 0);
         this.instrumentPanel2.Name = "instrumentPanel2";
         this.instrumentPanel2.Size = new System.Drawing.Size(460, 100);
         this.instrumentPanel2.TabIndex = 27;
         // 
         // btLoadConfig
         // 
         this.btLoadConfig.BackColor = System.Drawing.Color.MediumAquamarine;
         this.btLoadConfig.Checked = false;
         this.btLoadConfig.Dome = true;
         this.btLoadConfig.Location = new System.Drawing.Point(18, 30);
         this.btLoadConfig.Name = "btLoadConfig";
         this.btLoadConfig.Pushable = false;
         this.btLoadConfig.PushedColor = System.Drawing.Color.PaleGreen;
         this.btLoadConfig.RadioGroup = 0;
         this.btLoadConfig.RecessDepth = 0;
         this.btLoadConfig.Size = new System.Drawing.Size(56, 50);
         this.btLoadConfig.TabIndex = 25;
         this.btLoadConfig.Text = "Load";
         this.btLoadConfig.UseVisualStyleBackColor = false;
         this.btLoadConfig.Click += new System.EventHandler(this.btLoad_Click);
         // 
         // btSaveConfig
         // 
         this.btSaveConfig.BackColor = System.Drawing.Color.MediumAquamarine;
         this.btSaveConfig.Checked = false;
         this.btSaveConfig.Dome = true;
         this.btSaveConfig.Location = new System.Drawing.Point(96, 30);
         this.btSaveConfig.Name = "btSaveConfig";
         this.btSaveConfig.Pushable = false;
         this.btSaveConfig.PushedColor = System.Drawing.Color.PaleGreen;
         this.btSaveConfig.RadioGroup = 0;
         this.btSaveConfig.RecessDepth = 0;
         this.btSaveConfig.Size = new System.Drawing.Size(56, 50);
         this.btSaveConfig.TabIndex = 24;
         this.btSaveConfig.Text = "Save ";
         this.btSaveConfig.UseVisualStyleBackColor = false;
         this.btSaveConfig.Click += new System.EventHandler(this.btSaveConfig_Click);
         // 
         // gbSerial
         // 
         this.gbSerial.AdjustPadding = false;
         this.gbSerial.BackColor = System.Drawing.Color.AliceBlue;
         this.gbSerial.Caption = "Serial Port";
         this.gbSerial.CaptionFont = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.gbSerial.Controls.Add(this.label6);
         this.gbSerial.Controls.Add(this.label3);
         this.gbSerial.Controls.Add(this.nWTOut);
         this.gbSerial.Controls.Add(this.nRTOut);
         this.gbSerial.Controls.Add(this.cbBaud);
         this.gbSerial.Controls.Add(this.label4);
         this.gbSerial.Controls.Add(this.cbPort);
         this.gbSerial.Controls.Add(this.label5);
         this.gbSerial.CornerRadius = 12;
         this.gbSerial.Dock = System.Windows.Forms.DockStyle.Left;
         this.gbSerial.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.gbSerial.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (12)))), ((int) (((byte) (2)))), ((int) (((byte) (98)))));
         this.gbSerial.Location = new System.Drawing.Point(0, 0);
         this.gbSerial.Name = "gbSerial";
         this.gbSerial.Size = new System.Drawing.Size(506, 100);
         this.gbSerial.TabIndex = 0;
         this.gbSerial.Text = "Serial Port";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(266, 56);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(108, 17);
         this.label6.TabIndex = 12;
         this.label6.Text = "Write Timeout";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(266, 26);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(105, 17);
         this.label3.TabIndex = 11;
         this.label3.Text = "Read Timeout";
         // 
         // nWTOut
         // 
         this.nWTOut.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.Channels, "CurrentSettings.WriteTOut", true));
         this.nWTOut.Location = new System.Drawing.Point(377, 60);
         this.nWTOut.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
         this.nWTOut.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
         this.nWTOut.Name = "nWTOut";
         this.nWTOut.Size = new System.Drawing.Size(98, 24);
         this.nWTOut.TabIndex = 10;
         this.nWTOut.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
         // 
         // nRTOut
         // 
         this.nRTOut.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.Channels, "CurrentSettings.ReadTOut", true));
         this.nRTOut.Location = new System.Drawing.Point(377, 26);
         this.nRTOut.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
         this.nRTOut.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
         this.nRTOut.Name = "nRTOut";
         this.nRTOut.Size = new System.Drawing.Size(98, 24);
         this.nRTOut.TabIndex = 9;
         this.nRTOut.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
         // 
         // cbBaud
         // 
         this.cbBaud.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.Channels, "CurrentSettings.Baud", true));
         this.cbBaud.FormattingEnabled = true;
         this.cbBaud.Items.AddRange(new object[] {
            "115200\t",
            "  57600",
            "  38400",
            "  19200"});
         this.cbBaud.Location = new System.Drawing.Point(93, 60);
         this.cbBaud.Name = "cbBaud";
         this.cbBaud.Size = new System.Drawing.Size(121, 24);
         this.cbBaud.TabIndex = 8;
         this.cbBaud.SelectedValueChanged += new System.EventHandler(this.cbPort_SelectedValueChanged);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(3, 56);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(81, 17);
         this.label4.TabIndex = 7;
         this.label4.Text = "Baud Rate";
         // 
         // cbPort
         // 
         this.cbPort.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.Channels, "CurrentSettings.ComPort", true));
         this.cbPort.FormattingEnabled = true;
         this.cbPort.Location = new System.Drawing.Point(93, 26);
         this.cbPort.Name = "cbPort";
         this.cbPort.Size = new System.Drawing.Size(121, 24);
         this.cbPort.TabIndex = 6;
         this.cbPort.SelectedValueChanged += new System.EventHandler(this.cbPort_SelectedValueChanged);
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(50, 26);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(37, 17);
         this.label5.TabIndex = 5;
         this.label5.Text = "Port";
         // 
         // LA2Frm2
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.LightSteelBlue;
         this.ClientSize = new System.Drawing.Size(980, 747);
         this.Controls.Add(this.tabControl1);
         this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
         this.MinimumSize = new System.Drawing.Size(968, 741);
         this.Name = "LA2Frm2";
         this.Text = "SUMP LA .net";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LA2Frm2_FormClosing);
         ((System.ComponentModel.ISupportInitialize) (this.Channels)).EndInit();
         this.tabControl1.ResumeLayout(false);
         this.tbLA.ResumeLayout(false);
         this.panel4.ResumeLayout(false);
         this.gBCapture.ResumeLayout(false);
         this.gBCapture.PerformLayout();
         this.pnBeforeafter.ResumeLayout(false);
         this.pnBeforeafter.PerformLayout();
         ((System.ComponentModel.ISupportInitialize) (this.tbRatio)).EndInit();
         this.instrumentPanel5.ResumeLayout(false);
         this.tbCapture.ResumeLayout(false);
         this.groupBox3.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize) (this.dgData)).EndInit();
         this.instrumentPanel4.ResumeLayout(false);
         this.tbTrigger.ResumeLayout(false);
         this.panel1.ResumeLayout(false);
         this.tbChannels.ResumeLayout(false);
         this.instrumentPanel3.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize) (this.gvChannels)).EndInit();
         this.instrumentPanel1.ResumeLayout(false);
         this.PullApartTabPage1.ResumeLayout(false);
         this.instrumentPanel7.ResumeLayout(false);
         this.instrumentPanel6.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize) (this.gvBufSize)).EndInit();
         this.gbRates.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize) (this.gvSamplerate)).EndInit();
         this.panel3.ResumeLayout(false);
         this.instrumentPanel2.ResumeLayout(false);
         this.gbSerial.ResumeLayout(false);
         this.gbSerial.PerformLayout();
         ((System.ComponentModel.ISupportInitialize) (this.nWTOut)).EndInit();
         ((System.ComponentModel.ISupportInitialize) (this.nRTOut)).EndInit();
         this.ResumeLayout(false);

         }

      #endregion

      private System.IO.Ports.SerialPort serialPort1;
      private InstrumentPanel gBCapture;
      private System.Windows.Forms.ComboBox cbRate;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.SaveFileDialog saveFileDialog1;
      private System.Windows.Forms.OpenFileDialog openFileDialog1;
      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage tbLA;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button3;
      private PullApartTabPage tbTrigger;
      private PullApartTabPage tbChannels;
      private System.Windows.Forms.DataGridView gvChannels;
      private PullApartTabPage PullApartTabPage1;
      private InstrumentPanel  gbSerial;
      private System.Windows.Forms.ComboBox cbBaud;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.ComboBox cbPort;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.DataGridView gvSamplerate;
      private PullApartTabPage tbCapture;
      private InstrumentPanel groupBox3;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label label8;
      private LADisplay AnalyzerDisplay;
      private GaryPerkin.UserControls.Buttons.RoundButton btDemo;
      private GaryPerkin.UserControls.Buttons.RoundButton btLoadSamples;
      private GaryPerkin.UserControls.Buttons.RoundButton btSaveSamples;
      private GaryPerkin.UserControls.Buttons.RoundButton btRun;
      private DSSettings Channels;
      private GaryPerkin.UserControls.Buttons.RoundButton rbComplex;
      private GaryPerkin.UserControls.Buttons.RoundButton rbSimple;
      private GaryPerkin.UserControls.Buttons.RoundButton cbTrigEnable;
      private Trigger trigger0;
      private Trigger trigger1;
      private Trigger trigger2;
      private Trigger trigger3;
      private System.Windows.Forms.Panel panel2;
      private GaryPerkin.UserControls.Buttons.RoundButton btLoadConfig;
      private GaryPerkin.UserControls.Buttons.RoundButton btSaveConfig;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.ComboBox cbClock;
      private System.Windows.Forms.Label label1;
      private InstrumentPanel instrumentPanel2;
      private System.Windows.Forms.Panel panel3;
      private InstrumentPanel pnBeforeafter;
      private System.Windows.Forms.TrackBar tbRatio;
      private GaryPerkin.UserControls.Buttons.RoundButton cbRLE;
      private GaryPerkin.UserControls.Buttons.RoundButton cbNoiseFilter;
      private InstrumentPanel instrumentPanel3;
      private InstrumentPanel instrumentPanel1;
      private GaryPerkin.UserControls.Buttons.RoundButton cg3;
      private GaryPerkin.UserControls.Buttons.RoundButton cg0;
      private GaryPerkin.UserControls.Buttons.RoundButton cg2;
      private GaryPerkin.UserControls.Buttons.RoundButton cg1;
      private InstrumentPanel instrumentPanel4;
      private GaryPerkin.UserControls.Buttons.RoundButton btRaw;
      private GaryPerkin.UserControls.Buttons.RoundButton btTrans;
      private System.Windows.Forms.DataGridView dgData;
      private System.Windows.Forms.Panel panel4;
      private InstrumentPanel instrumentPanel5;
      private InstrumentPanel instrumentPanel6;
      private System.Windows.Forms.DataGridView gvBufSize;
      private System.Windows.Forms.ComboBox nBuffSize;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.NumericUpDown nWTOut;
      private System.Windows.Forms.NumericUpDown nRTOut;
      private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn frequencyDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn labelDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewCheckBoxColumn visibleDataGridViewCheckBoxColumn;
      private InstrumentPanel instrumentPanel7;
      private System.Windows.Forms.ColorDialog colorDialog1;
      private ColorChooser CCEvenFG;
      public InstrumentPanel gbRates;
      private ColorChooser CCOddBG;
      private ColorChooser CCOddFG;
      private ColorChooser CCEvenBG;
      }
   }