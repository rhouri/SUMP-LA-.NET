using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SUMPLA_net
   {

   public delegate void ValueChangedHandler ( object sender, BitboxValueChangedEventArgs e );
   
   public partial class BitsBox :PictureBox
      {
      private Bit32 B=new Bit32();

      [DefaultValue(32)]
      public int BitLength
         {
         get;
         set;
         }

      public int Value   // MSB first
         {
         get
            {
            return B.IntegerValue;
            }
         set
            {
            B.IntegerValue = value;
            this.Invalidate();
            }
         }

      public int LSBFirstValue // LSB first
         {
         get
            {
            return B.LSBFirstIntegerValue;
            }
         }
         
         
         
      public Bitmap imgOn;
      public Bitmap imgOff;
      
      public BitsBox ()
         {
         InitializeComponent();
         if (BitLength == 0)
            BitLength = 32;
         Stream s1 = this.GetType().Assembly.GetManifestResourceStream("SUMPLA_net.bitOn.bmp");
         imgOn = new Bitmap(s1);
         Stream s2 = this.GetType().Assembly.GetManifestResourceStream("SUMPLA_net.bitOff.bmp");
         imgOff = new Bitmap(s2);
         }

      public event ValueChangedHandler ValueChanged;
      protected virtual void OnValueChanged ( BitboxValueChangedEventArgs e )
           {
           ValueChanged(this, e);
           }

      protected override void OnPaint ( PaintEventArgs pe )
         {
         if (B == null) // not set yet
            return;
         int l = BitLength;
         
         int k = 0;
         for (int i = l-1 ; i >=0 ; i--)
            {
            if (i % 8 == 7 && i!=l-1)
               {
               k += 8;
               }
            else
               if (i % 4 == 3 && i != l - 1)
                  {
                  k += 2;
                  }
            pe.Graphics.DrawImage((B.bits[i]) ? imgOn : imgOff, new Point(k, 0));
            k += 16;
            }
         }


      protected override void OnMouseClick ( MouseEventArgs e )
         {
         base.OnMouseClick(e);
         int X = 0;
         int K = 0;
         int bitPos = 31;
         while (X < e.X)
            {
            K++;
            if (K == 16)
               {
               bitPos--;
               K = 0;
               if (bitPos % 8 == 0)
                  X += 8;
               else
                  if (bitPos % 4 == 0)
                     X += 2;
               }
            X++;
            }
         bitPos = (bitPos > 31) ? 31 : bitPos;
         bitPos = (bitPos < 0) ? 0 : bitPos;

         B.bits.Set(bitPos, !B.bits[bitPos]);
         this.Invalidate();
        
         OnValueChanged(new BitboxValueChangedEventArgs(this.B.IntegerValue));
         }

      protected override void OnResize ( EventArgs e )
         {
         int l=BitLength;
         this.Width = (l * 16) + (l / 8 -1) * 8 + (l / 8 ) * 2; // 10 Pixels per bit
         this.Height = 16;
         
         }  
         
      }

   public class BitboxValueChangedEventArgs :EventArgs
      {
      public int Value;
      public BitboxValueChangedEventArgs ( int val )
         {
         this.Value = val;
         }
      }
   public class Bit32
      {
      public BitArray bits = new BitArray(32);

      public int IntegerValue
         {
         get
            {
            int[] array = new int[1];
            bits.CopyTo(array, 0);
            return array[0];
            }
         set
            {
            bits = new BitArray(new int[] { value });
            }
         }


      public int LSBFirstIntegerValue
         {
         get
            {
            int x = IntegerValue;
            int k = 0;
            for (int i = 0 ; i <4 ; i++)
               {
               k <<= 8;
               k += (x >> (i * 8)) & 0xff;
               }

            return k;
            }
         
         
         
         
         }
      }      
   }
