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








   [System.ComponentModel.DefaultBindingProperty("ARGBColor")]
   public partial class ColorChooser :UserControl, INotifyPropertyChanged
      {

      public event PropertyChangedEventHandler PropertyChanged;
      private void NotifyPropertyChanged ( String C )
         {
         if (PropertyChanged != null)
            {
            PropertyChanged(this, new PropertyChangedEventArgs(C));
            }
         }




      private Color fColor;
      public string Caption
         {
         set
            {
            label1.Text = value;
            }
         get
            {
            return label1.Text;
            }
         }

      private Color Dim ( Color C )
         {
         return Color.FromArgb((C.R - 50 > 0) ? C.R - 50 : 0
                                    , (C.G + 50 < 255) ? C.G + 50 : 255
                                    , (C.B - 50 > 0) ? C.B - 50 : 0);
         }



      private Color Lighten ( Color C )
         {
         return Color.FromArgb((C.R + 50 < 255) ? C.R + 50 : 255
                                    , (C.G + 50 < 255) ? C.G + 50 : 255
                                    , (C.B + 50 < 255) ? C.B + 50 : 255);
         }



      public Color SelectedColor
         {
         get
            {
            return fColor;
            }
         set
            {
            fColor = value;
            button1.BackColor = fColor;
            }
         }
         
      public int ARGBColor
         {
         get
            {
            return fColor.ToArgb();
            }
         set
            {
            fColor = Color.FromArgb(value);
            button1.BackColor = fColor;
            }
         }


      public ColorChooser ()
         {
         InitializeComponent();
         }

      private void roundButton1_Click ( object sender, EventArgs e )
         {
         using (ColorDialog colorDialog1 = new ColorDialog())
            {
            colorDialog1.Color = fColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
               {
               ARGBColor = colorDialog1.Color.ToArgb();
               NotifyPropertyChanged("SelectedColor");
               }
            }
         }
      }
   }
