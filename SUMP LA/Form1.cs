using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;



namespace LA2
   {
   public partial class Form1 :Form
      {
      public Form1 ()
         {     
         InitializeComponent();
         serialPort1.Open();
         }
      
      private void numericUpDown1_ValueChanged_1 ( object sender, EventArgs e )
         {
         userControl11.Zoom = (float) numericUpDown1.Value;
         }

      private void button1_Click ( object sender, EventArgs e )
         {
         Random rnd = new Random();
         Byte[] b = new Byte[2048];
         rnd.NextBytes(b);
         userControl11.ClearSamples();

         for (int i = 10 ; i < 2000 ; i++)
            userControl11.AddSample(i, b[i]);


         /*         for (int i = 0 ; i < 5 ; i++)
                     {
                     userControl11.AddSample(i, 0x55);
                     userControl11.AddSample(i, 0xaa);
                     }
                  for (int i = 0; i < 10; i++)
                     userControl11.AddSample(i, 0xaa);

                  for (int i = 0; i < 5; i++)
                     {
                     userControl11.AddSample(i, 0x55);
                     userControl11.AddSample(i, 0xaa);
                     } */
         userControl11.Zoom = (float) 100;
         userControl11.SampleValid = true;
         userControl11.TickTime = 3; // nanoseconds
         userControl11.Invalidate(); // redraw
         }

      private void btStart_Click ( object sender, EventArgs e )
         {
         userControl11.ClearSamples();
         serialPort1.Write("A"); // Trigger the dsPIC
         while(serialPort1.BytesToRead==0);
         while (serialPort1.BytesToRead > 0)
            {
            int TStamp=serialPort1.ReadByte();
            TStamp=TStamp*256;
            TStamp+=serialPort1.ReadByte();
            userControl11.AddSample(TStamp,(byte) serialPort1.ReadByte());    
            }
         
         
         userControl11.Zoom = (float) 100;
         userControl11.SampleValid = true;
         userControl11.TickTime = 10000;
         userControl11.Invalidate(); // redraw
         }

     

    

      }


   }