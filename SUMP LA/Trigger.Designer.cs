namespace SUMPLA_net
   {
   partial class Trigger
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
         this.panel1 = new SUMPLA_net.InstrumentPanel();
         this.SerialChannel = new System.Windows.Forms.NumericUpDown();
         this.lblSerialChannel = new System.Windows.Forms.Label();
         this.lvlImmediate = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.Level1 = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.Level2 = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.Level3 = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.rbParallel = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.rbSerial = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.rbStart = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.rbRaise = new GaryPerkin.UserControls.Buttons.RoundButton();
         this.Delay = new System.Windows.Forms.NumericUpDown();
         this.Mask = new SUMPLA_net.BitsEditor();
         this.label21 = new System.Windows.Forms.Label();
         this.Value = new SUMPLA_net.BitsEditor();
         this.label10 = new System.Windows.Forms.Label();
         this.label11 = new System.Windows.Forms.Label();
         this.label18 = new System.Windows.Forms.Label();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize) (this.SerialChannel)).BeginInit();
         ((System.ComponentModel.ISupportInitialize) (this.Delay)).BeginInit();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.AdjustPadding = false;
         this.panel1.Caption = "Stage 0";
         this.panel1.CaptionFont = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.panel1.Controls.Add(this.SerialChannel);
         this.panel1.Controls.Add(this.lblSerialChannel);
         this.panel1.Controls.Add(this.lvlImmediate);
         this.panel1.Controls.Add(this.Level1);
         this.panel1.Controls.Add(this.Level2);
         this.panel1.Controls.Add(this.Level3);
         this.panel1.Controls.Add(this.rbParallel);
         this.panel1.Controls.Add(this.rbSerial);
         this.panel1.Controls.Add(this.rbStart);
         this.panel1.Controls.Add(this.rbRaise);
         this.panel1.Controls.Add(this.Delay);
         this.panel1.Controls.Add(this.Mask);
         this.panel1.Controls.Add(this.label21);
         this.panel1.Controls.Add(this.Value);
         this.panel1.Controls.Add(this.label10);
         this.panel1.Controls.Add(this.label11);
         this.panel1.Controls.Add(this.label18);
         this.panel1.CornerRadius = 12;
         this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Padding = new System.Windows.Forms.Padding(2);
         this.panel1.Size = new System.Drawing.Size(947, 136);
         this.panel1.TabIndex = 36;
         // 
         // SerialChannel
         // 
         this.SerialChannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.SerialChannel.Location = new System.Drawing.Point(733, 106);
         this.SerialChannel.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
         this.SerialChannel.Name = "SerialChannel";
         this.SerialChannel.Size = new System.Drawing.Size(65, 20);
         this.SerialChannel.TabIndex = 65;
         this.SerialChannel.Visible = false;
         // 
         // lblSerialChannel
         // 
         this.lblSerialChannel.AutoSize = true;
         this.lblSerialChannel.Location = new System.Drawing.Point(652, 106);
         this.lblSerialChannel.Name = "lblSerialChannel";
         this.lblSerialChannel.Size = new System.Drawing.Size(75, 13);
         this.lblSerialChannel.TabIndex = 64;
         this.lblSerialChannel.Text = "Serial Channel";
         this.lblSerialChannel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.lblSerialChannel.Visible = false;
         // 
         // lvlImmediate
         // 
         this.lvlImmediate.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.lvlImmediate.Checked = true;
         this.lvlImmediate.Cursor = System.Windows.Forms.Cursors.Hand;
         this.lvlImmediate.Dome = true;
         this.lvlImmediate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
         this.lvlImmediate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.lvlImmediate.Location = new System.Drawing.Point(708, 69);
         this.lvlImmediate.Name = "lvlImmediate";
         this.lvlImmediate.Pushable = true;
         this.lvlImmediate.PushedColor = System.Drawing.Color.LawnGreen;
         this.lvlImmediate.RadioGroup = 3;
         this.lvlImmediate.RecessDepth = 0;
         this.lvlImmediate.Size = new System.Drawing.Size(40, 24);
         this.lvlImmediate.TabIndex = 63;
         this.lvlImmediate.Text = "Imm";
         this.lvlImmediate.UseVisualStyleBackColor = false;
         // 
         // Level1
         // 
         this.Level1.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.Level1.Checked = false;
         this.Level1.Cursor = System.Windows.Forms.Cursors.Hand;
         this.Level1.Dome = true;
         this.Level1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
         this.Level1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Level1.Location = new System.Drawing.Point(767, 69);
         this.Level1.Name = "Level1";
         this.Level1.Pushable = true;
         this.Level1.PushedColor = System.Drawing.Color.LawnGreen;
         this.Level1.RadioGroup = 3;
         this.Level1.RecessDepth = 0;
         this.Level1.Size = new System.Drawing.Size(40, 24);
         this.Level1.TabIndex = 62;
         this.Level1.Text = "1";
         this.Level1.UseVisualStyleBackColor = false;
         // 
         // Level2
         // 
         this.Level2.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.Level2.Checked = false;
         this.Level2.Cursor = System.Windows.Forms.Cursors.Hand;
         this.Level2.Dome = true;
         this.Level2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
         this.Level2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Level2.Location = new System.Drawing.Point(826, 69);
         this.Level2.Name = "Level2";
         this.Level2.Pushable = true;
         this.Level2.PushedColor = System.Drawing.Color.LawnGreen;
         this.Level2.RadioGroup = 3;
         this.Level2.RecessDepth = 0;
         this.Level2.Size = new System.Drawing.Size(40, 24);
         this.Level2.TabIndex = 61;
         this.Level2.Text = "2";
         this.Level2.UseVisualStyleBackColor = false;
         this.Level2.Click += new System.EventHandler(this.roundButton3_Click);
         // 
         // Level3
         // 
         this.Level3.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.Level3.Checked = false;
         this.Level3.Cursor = System.Windows.Forms.Cursors.Hand;
         this.Level3.Dome = true;
         this.Level3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
         this.Level3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Level3.Location = new System.Drawing.Point(885, 69);
         this.Level3.Name = "Level3";
         this.Level3.Pushable = true;
         this.Level3.PushedColor = System.Drawing.Color.LawnGreen;
         this.Level3.RadioGroup = 3;
         this.Level3.RecessDepth = 0;
         this.Level3.Size = new System.Drawing.Size(40, 24);
         this.Level3.TabIndex = 60;
         this.Level3.Text = "3";
         this.Level3.UseVisualStyleBackColor = false;
         this.Level3.Click += new System.EventHandler(this.roundButton4_Click);
         // 
         // rbParallel
         // 
         this.rbParallel.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.rbParallel.Checked = true;
         this.rbParallel.Cursor = System.Windows.Forms.Cursors.Hand;
         this.rbParallel.Dome = true;
         this.rbParallel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
         this.rbParallel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.rbParallel.Location = new System.Drawing.Point(655, 27);
         this.rbParallel.Name = "rbParallel";
         this.rbParallel.Pushable = true;
         this.rbParallel.PushedColor = System.Drawing.Color.LawnGreen;
         this.rbParallel.RadioGroup = 2;
         this.rbParallel.RecessDepth = 0;
         this.rbParallel.Size = new System.Drawing.Size(50, 32);
         this.rbParallel.TabIndex = 59;
         this.rbParallel.Text = "Par";
         this.rbParallel.UseVisualStyleBackColor = false;
         this.rbParallel.Click += new System.EventHandler(this.rbParallel_Click);
         // 
         // rbSerial
         // 
         this.rbSerial.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.rbSerial.Checked = false;
         this.rbSerial.Cursor = System.Windows.Forms.Cursors.Hand;
         this.rbSerial.Dome = true;
         this.rbSerial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
         this.rbSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.rbSerial.Location = new System.Drawing.Point(708, 27);
         this.rbSerial.Name = "rbSerial";
         this.rbSerial.Pushable = true;
         this.rbSerial.PushedColor = System.Drawing.Color.LawnGreen;
         this.rbSerial.RadioGroup = 2;
         this.rbSerial.RecessDepth = 0;
         this.rbSerial.Size = new System.Drawing.Size(50, 32);
         this.rbSerial.TabIndex = 58;
         this.rbSerial.Text = "Ser";
         this.rbSerial.UseVisualStyleBackColor = false;
         this.rbSerial.Click += new System.EventHandler(this.rbParallel_Click);
         // 
         // rbStart
         // 
         this.rbStart.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.rbStart.Checked = true;
         this.rbStart.Cursor = System.Windows.Forms.Cursors.Hand;
         this.rbStart.Dome = true;
         this.rbStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
         this.rbStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.rbStart.Location = new System.Drawing.Point(822, 27);
         this.rbStart.Name = "rbStart";
         this.rbStart.Pushable = true;
         this.rbStart.PushedColor = System.Drawing.Color.LawnGreen;
         this.rbStart.RadioGroup = 1;
         this.rbStart.RecessDepth = 0;
         this.rbStart.Size = new System.Drawing.Size(50, 32);
         this.rbStart.TabIndex = 57;
         this.rbStart.Text = "Start";
         this.rbStart.UseVisualStyleBackColor = false;
         // 
         // rbRaise
         // 
         this.rbRaise.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.rbRaise.Checked = false;
         this.rbRaise.Cursor = System.Windows.Forms.Cursors.Hand;
         this.rbRaise.Dome = true;
         this.rbRaise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
         this.rbRaise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.rbRaise.Location = new System.Drawing.Point(875, 27);
         this.rbRaise.Name = "rbRaise";
         this.rbRaise.Pushable = true;
         this.rbRaise.PushedColor = System.Drawing.Color.LawnGreen;
         this.rbRaise.RadioGroup = 1;
         this.rbRaise.RecessDepth = 0;
         this.rbRaise.Size = new System.Drawing.Size(50, 32);
         this.rbRaise.TabIndex = 56;
         this.rbRaise.Text = "Raise";
         this.rbRaise.UseVisualStyleBackColor = false;
         // 
         // Delay
         // 
         this.Delay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.Delay.Location = new System.Drawing.Point(852, 106);
         this.Delay.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
         this.Delay.Name = "Delay";
         this.Delay.Size = new System.Drawing.Size(65, 20);
         this.Delay.TabIndex = 54;
         // 
         // Mask
         // 
         this.Mask.BackColor = System.Drawing.Color.Snow;
         this.Mask.BitsNum = 0;
         this.Mask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.Mask.Font = new System.Drawing.Font("LCD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.Mask.Location = new System.Drawing.Point(55, 25);
         this.Mask.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
         this.Mask.Name = "Mask";
         this.Mask.Padding = new System.Windows.Forms.Padding(4);
         this.Mask.Size = new System.Drawing.Size(586, 48);
         this.Mask.TabIndex = 43;
         this.Mask.Value = 0;
         // 
         // label21
         // 
         this.label21.AutoSize = true;
         this.label21.Location = new System.Drawing.Point(814, 108);
         this.label21.Name = "label21";
         this.label21.Size = new System.Drawing.Size(34, 13);
         this.label21.TabIndex = 53;
         this.label21.Text = "Delay";
         this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // Value
         // 
         this.Value.BackColor = System.Drawing.Color.AliceBlue;
         this.Value.BitsNum = 0;
         this.Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.Value.Font = new System.Drawing.Font("LCD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.Value.Location = new System.Drawing.Point(55, 77);
         this.Value.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
         this.Value.Name = "Value";
         this.Value.Padding = new System.Windows.Forms.Padding(4);
         this.Value.Size = new System.Drawing.Size(586, 49);
         this.Value.TabIndex = 44;
         this.Value.Value = 0;
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(14, 46);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(33, 13);
         this.label10.TabIndex = 45;
         this.label10.Text = "Mask";
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Location = new System.Drawing.Point(14, 94);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(34, 13);
         this.label11.TabIndex = 46;
         this.label11.Text = "Value";
         // 
         // label18
         // 
         this.label18.AutoSize = true;
         this.label18.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.label18.Location = new System.Drawing.Point(661, 74);
         this.label18.Name = "label18";
         this.label18.Size = new System.Drawing.Size(31, 14);
         this.label18.TabIndex = 47;
         this.label18.Text = "Arm";
         this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // Trigger
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.panel1);
         this.Name = "Trigger";
         this.Size = new System.Drawing.Size(947, 136);
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize) (this.SerialChannel)).EndInit();
         ((System.ComponentModel.ISupportInitialize) (this.Delay)).EndInit();
         this.ResumeLayout(false);

         }

      #endregion

      private System.Windows.Forms.Label label21;
      private System.Windows.Forms.Label label18;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.Label label10;
      private BitsEditor Value;
      private BitsEditor Mask;
      private InstrumentPanel panel1;
      private System.Windows.Forms.Label lblSerialChannel;
      public System.Windows.Forms.NumericUpDown Delay;
      public GaryPerkin.UserControls.Buttons.RoundButton rbParallel;
      public GaryPerkin.UserControls.Buttons.RoundButton rbSerial;
      public GaryPerkin.UserControls.Buttons.RoundButton rbStart;
      public GaryPerkin.UserControls.Buttons.RoundButton rbRaise;
      public GaryPerkin.UserControls.Buttons.RoundButton lvlImmediate;
      public GaryPerkin.UserControls.Buttons.RoundButton Level1;
      public GaryPerkin.UserControls.Buttons.RoundButton Level2;
      public GaryPerkin.UserControls.Buttons.RoundButton Level3;
      public System.Windows.Forms.NumericUpDown SerialChannel;
      }
   }
