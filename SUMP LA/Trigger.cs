using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SUMPLA_net
   {
   public partial class Trigger :UserControl
      {
      private int sn = 0;

      // gets byte array from int value ( MSB First)
      public static List<byte> GetBytes ( int v, int Count )
         {
         List<byte> bb = new List<byte>();


         for (int i = Count-1 ; i >= 0 ; i--)
            {
            bb.Add((byte) ((v >> (i * 8)) & 0xff));
            }
         return bb;
         }

      public static List<byte> LSBFirstGetBytes ( int v, int Count )
         {
         List<byte> bb = new List<byte>();


         for (int i = 0 ;i<Count  ; i++)
            {
            bb.Add((byte) ((v >> (i * 8)) & 0xff));
            }
         return bb;
         }
      

      public Color HeaderFG
         {
         get
            {
            return panel1.ForeColor;
            }

         set
            {
            panel1.ForeColor = value;
            }
         }

      public Color HeaderBG
         {
         get
            {
            return panel1.BackColor;
            }

         set
            {
            panel1.BackColor = value;
            }
         }


      public int StageNum
         {
         get
            {
            return sn;
            }
         set
            {
            sn = value;
            panel1.Caption = string.Format("Stage {0}", sn);
            }
         }




      public List<byte> MaskBytes
         {
         get
            {
            return GetBytes(Mask.LSBFirstValue,4);
            }
         }


      public List<byte> ValueBytes
         {
         get
            {
            return GetBytes(Value.LSBFirstValue,4);
            }
         }


      public List<byte> DelayBytes
         {
         get
            {
            return GetBytes((int) Delay.Value, 2);
            }
         
         }

      
      public byte Level
         {
         get
            {
            if (Level1.Checked)
               return (byte) 1;

            if (Level2.Checked)
               return (byte) 2;
            if (Level3.Checked)
               return (byte) 3;
            return (byte) 0;
            }
         set
            {
            switch (value)
               {
               case 1:
                  Level1.Checked = true;
                  break;
               case 2:
                  Level2.Checked = true;
                  break;
               case 3:
                  Level3.Checked = true;
                  break;
               default:
                  lvlImmediate.Checked = true;
                  break;
               }
            
            
            
            }
         
         }   
      public Trigger ()
         {
         InitializeComponent();
         }

      private void rbParallel_Click ( object sender, EventArgs e )
         {
         SerialChannel.Visible = lblSerialChannel.Visible = rbSerial.Checked;
         }

      private void roundButton3_Click ( object sender, EventArgs e )
         {

         }

      private void roundButton4_Click ( object sender, EventArgs e )
         {

         }


      }
   }
