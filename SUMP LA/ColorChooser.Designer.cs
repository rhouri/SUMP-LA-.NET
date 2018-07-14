namespace SUMPLA_net
   {
   partial class ColorChooser
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
         this.label1 = new System.Windows.Forms.Label();
         this.button1 = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.label1.Location = new System.Drawing.Point(3, 8);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(137, 23);
         this.label1.TabIndex = 0;
         this.label1.Text = "Color";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.Color.AliceBlue;
         this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
         this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
         this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
         this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button1.Location = new System.Drawing.Point(168, 7);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 1;
         this.button1.Text = "Choose";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.roundButton1_Click);
         // 
         // ColorChooser
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.button1);
         this.Controls.Add(this.label1);
         this.Name = "ColorChooser";
         this.Size = new System.Drawing.Size(258, 37);
         this.ResumeLayout(false);

         }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button button1;
      }
   }
