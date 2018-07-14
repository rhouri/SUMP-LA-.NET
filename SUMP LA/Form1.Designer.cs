namespace LA2
   {
   partial class Form1
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
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.probeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.rS232ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.checkBox7 = new System.Windows.Forms.CheckBox();
         this.checkBox6 = new System.Windows.Forms.CheckBox();
         this.checkBox5 = new System.Windows.Forms.CheckBox();
         this.checkBox4 = new System.Windows.Forms.CheckBox();
         this.checkBox3 = new System.Windows.Forms.CheckBox();
         this.checkBox2 = new System.Windows.Forms.CheckBox();
         this.checkBox1 = new System.Windows.Forms.CheckBox();
         this.cb7 = new System.Windows.Forms.CheckBox();
         this.btStart = new System.Windows.Forms.Button();
         this.button1 = new System.Windows.Forms.Button();
         this.pnlBottom = new System.Windows.Forms.Panel();
         this.userControl11 = new AnalyzerDisplay.UserControl1();
         this.menuStrip1.SuspendLayout();
         this.groupBox1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).BeginInit();
         this.groupBox2.SuspendLayout();
         this.pnlBottom.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configToolStripMenuItem,
            this.actionsToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(782, 24);
         this.menuStrip1.TabIndex = 1;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "File";
         // 
         // loadToolStripMenuItem
         // 
         this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
         this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
         this.loadToolStripMenuItem.Text = "Load";
         // 
         // saveToolStripMenuItem
         // 
         this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
         this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
         this.saveToolStripMenuItem.Text = "Save";
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
         this.exitToolStripMenuItem.Text = "Exit";
         // 
         // configToolStripMenuItem
         // 
         this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.probeToolStripMenuItem,
            this.rS232ToolStripMenuItem});
         this.configToolStripMenuItem.Name = "configToolStripMenuItem";
         this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
         this.configToolStripMenuItem.Text = "Config";
         // 
         // probeToolStripMenuItem
         // 
         this.probeToolStripMenuItem.Name = "probeToolStripMenuItem";
         this.probeToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
         this.probeToolStripMenuItem.Text = "Parallel port (HC245)";
         // 
         // rS232ToolStripMenuItem
         // 
         this.rS232ToolStripMenuItem.Name = "rS232ToolStripMenuItem";
         this.rS232ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
         this.rS232ToolStripMenuItem.Text = "RS 232";
         // 
         // actionsToolStripMenuItem
         // 
         this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
         this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
         this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
         this.actionsToolStripMenuItem.Text = "Actions";
         // 
         // toolStripMenuItem1
         // 
         this.toolStripMenuItem1.Name = "toolStripMenuItem1";
         this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
         this.toolStripMenuItem1.Text = "Trigger Word";
         // 
         // startToolStripMenuItem
         // 
         this.startToolStripMenuItem.Name = "startToolStripMenuItem";
         this.startToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
         this.startToolStripMenuItem.Text = "Start";
         // 
         // stopToolStripMenuItem
         // 
         this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
         this.stopToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
         this.stopToolStripMenuItem.Text = "Stop";
         // 
         // serialPort1
         // 
         this.serialPort1.BaudRate = 115200;
         this.serialPort1.PortName = "COM2";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.label4);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Controls.Add(this.numericUpDown1);
         this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
         this.groupBox1.Location = new System.Drawing.Point(0, 0);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(260, 142);
         this.groupBox1.TabIndex = 6;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Display";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(21, 119);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(34, 13);
         this.label4.TabIndex = 11;
         this.label4.Text = "Zoom";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(21, 105);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(34, 13);
         this.label3.TabIndex = 10;
         this.label3.Text = "Zoom";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(13, 75);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(34, 13);
         this.label2.TabIndex = 9;
         this.label2.Text = "Zoom";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(7, 25);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(34, 13);
         this.label1.TabIndex = 8;
         this.label1.Text = "Zoom";
         // 
         // numericUpDown1
         // 
         this.numericUpDown1.Location = new System.Drawing.Point(47, 19);
         this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
         this.numericUpDown1.Name = "numericUpDown1";
         this.numericUpDown1.Size = new System.Drawing.Size(65, 20);
         this.numericUpDown1.TabIndex = 7;
         this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.checkBox7);
         this.groupBox2.Controls.Add(this.checkBox6);
         this.groupBox2.Controls.Add(this.checkBox5);
         this.groupBox2.Controls.Add(this.checkBox4);
         this.groupBox2.Controls.Add(this.checkBox3);
         this.groupBox2.Controls.Add(this.checkBox2);
         this.groupBox2.Controls.Add(this.checkBox1);
         this.groupBox2.Controls.Add(this.cb7);
         this.groupBox2.Controls.Add(this.btStart);
         this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
         this.groupBox2.Location = new System.Drawing.Point(260, 0);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(210, 142);
         this.groupBox2.TabIndex = 7;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Capture";
         // 
         // checkBox7
         // 
         this.checkBox7.AutoSize = true;
         this.checkBox7.Location = new System.Drawing.Point(174, 25);
         this.checkBox7.Name = "checkBox7";
         this.checkBox7.Size = new System.Drawing.Size(15, 14);
         this.checkBox7.TabIndex = 12;
         this.checkBox7.UseVisualStyleBackColor = true;
         // 
         // checkBox6
         // 
         this.checkBox6.AutoSize = true;
         this.checkBox6.Location = new System.Drawing.Point(151, 25);
         this.checkBox6.Name = "checkBox6";
         this.checkBox6.Size = new System.Drawing.Size(15, 14);
         this.checkBox6.TabIndex = 11;
         this.checkBox6.UseVisualStyleBackColor = true;
         // 
         // checkBox5
         // 
         this.checkBox5.AutoSize = true;
         this.checkBox5.Location = new System.Drawing.Point(128, 25);
         this.checkBox5.Name = "checkBox5";
         this.checkBox5.Size = new System.Drawing.Size(15, 14);
         this.checkBox5.TabIndex = 10;
         this.checkBox5.UseVisualStyleBackColor = true;
         // 
         // checkBox4
         // 
         this.checkBox4.AutoSize = true;
         this.checkBox4.Location = new System.Drawing.Point(82, 25);
         this.checkBox4.Name = "checkBox4";
         this.checkBox4.Size = new System.Drawing.Size(15, 14);
         this.checkBox4.TabIndex = 9;
         this.checkBox4.UseVisualStyleBackColor = true;
         // 
         // checkBox3
         // 
         this.checkBox3.AutoSize = true;
         this.checkBox3.Location = new System.Drawing.Point(105, 25);
         this.checkBox3.Name = "checkBox3";
         this.checkBox3.Size = new System.Drawing.Size(15, 14);
         this.checkBox3.TabIndex = 8;
         this.checkBox3.UseVisualStyleBackColor = true;
         // 
         // checkBox2
         // 
         this.checkBox2.AutoSize = true;
         this.checkBox2.Location = new System.Drawing.Point(59, 25);
         this.checkBox2.Name = "checkBox2";
         this.checkBox2.Size = new System.Drawing.Size(15, 14);
         this.checkBox2.TabIndex = 7;
         this.checkBox2.UseVisualStyleBackColor = true;
         // 
         // checkBox1
         // 
         this.checkBox1.AutoSize = true;
         this.checkBox1.Location = new System.Drawing.Point(36, 25);
         this.checkBox1.Name = "checkBox1";
         this.checkBox1.Size = new System.Drawing.Size(15, 14);
         this.checkBox1.TabIndex = 6;
         this.checkBox1.UseVisualStyleBackColor = true;
         // 
         // cb7
         // 
         this.cb7.AutoSize = true;
         this.cb7.Checked = true;
         this.cb7.CheckState = System.Windows.Forms.CheckState.Indeterminate;
         this.cb7.Location = new System.Drawing.Point(13, 25);
         this.cb7.Name = "cb7";
         this.cb7.Size = new System.Drawing.Size(15, 14);
         this.cb7.TabIndex = 5;
         this.cb7.UseVisualStyleBackColor = true;
         // 
         // btStart
         // 
         this.btStart.Location = new System.Drawing.Point(114, 100);
         this.btStart.Name = "btStart";
         this.btStart.Size = new System.Drawing.Size(75, 23);
         this.btStart.TabIndex = 4;
         this.btStart.Text = "Start";
         this.btStart.UseVisualStyleBackColor = true;
         this.btStart.Click += new System.EventHandler(this.btStart_Click);
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(684, 109);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 8;
         this.button1.Text = "Demo";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // pnlBottom
         // 
         this.pnlBottom.Controls.Add(this.button1);
         this.pnlBottom.Controls.Add(this.groupBox2);
         this.pnlBottom.Controls.Add(this.groupBox1);
         this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.pnlBottom.Location = new System.Drawing.Point(0, 319);
         this.pnlBottom.Name = "pnlBottom";
         this.pnlBottom.Size = new System.Drawing.Size(782, 142);
         this.pnlBottom.TabIndex = 9;
         // 
         // userControl11
         // 
         this.userControl11.BackgroundColorEven = System.Drawing.Color.Black;
         this.userControl11.BackgroundColorOdd = System.Drawing.Color.FromArgb(((int) (((byte) (50)))), ((int) (((byte) (50)))), ((int) (((byte) (50)))));
         this.userControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.userControl11.Channels = 4;
         this.userControl11.Cursor = System.Windows.Forms.Cursors.Cross;
         this.userControl11.Dock = System.Windows.Forms.DockStyle.Fill;
         this.userControl11.ForegroundColorEven = System.Drawing.Color.RoyalBlue;
         this.userControl11.ForegroundColorOdd = System.Drawing.Color.OrangeRed;
         this.userControl11.Location = new System.Drawing.Point(0, 24);
         this.userControl11.Name = "userControl11";
         this.userControl11.SeparationPercent = 20;
         this.userControl11.Size = new System.Drawing.Size(782, 295);
         this.userControl11.TabIndex = 2;
         this.userControl11.Zoom = 1F;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.LightSteelBlue;
         this.ClientSize = new System.Drawing.Size(782, 461);
         this.Controls.Add(this.userControl11);
         this.Controls.Add(this.pnlBottom);
         this.Controls.Add(this.menuStrip1);
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "Form1";
         this.Text = "Logic Analyzer";
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).EndInit();
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.pnlBottom.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

         }

      #endregion

      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem probeToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem rS232ToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
      private AnalyzerDisplay.UserControl1 userControl11;
      private System.IO.Ports.SerialPort serialPort1;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.NumericUpDown numericUpDown1;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.Button btStart;
      private System.Windows.Forms.CheckBox checkBox7;
      private System.Windows.Forms.CheckBox checkBox6;
      private System.Windows.Forms.CheckBox checkBox5;
      private System.Windows.Forms.CheckBox checkBox4;
      private System.Windows.Forms.CheckBox checkBox3;
      private System.Windows.Forms.CheckBox checkBox2;
      private System.Windows.Forms.CheckBox checkBox1;
      private System.Windows.Forms.CheckBox cb7;
      private System.Windows.Forms.Button button1;
       private System.Windows.Forms.Label label4;
       private System.Windows.Forms.Label label3;
       private System.Windows.Forms.Label label2;
       private System.Windows.Forms.Panel pnlBottom;
      }
   }

