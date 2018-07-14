using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SUMPLA_net
    {
    public partial class BitsEditor :UserControl
        {
        public int Value
            {
            get
                {
                return bitsBox1.Value;
                }
            set
                {
                bitsBox1.Value = value;
                DispHex();
                }
            }

        public int LSBFirstValue
            {
            get
                {
                return bitsBox1.LSBFirstValue;
                }
            }
        private List<Label> HexLabels = new List<Label>();


        [DefaultValue(32)]
        public int BitsNum
            {
            get;
            set;
            }


        public BitsEditor ()
            {
            InitializeComponent();
            }

        private void bitsBox1_ValueChanged ( object sender, BitboxValueChangedEventArgs e )
            {
            DispHex();
            }
        private void DispHex ()
            {
            int x = (int) bitsBox1.Value;
            foreach (Control lx in this.Controls)
                if (lx is Label)
                    if (lx.Name.StartsWith("hex"))
                        lx.Text = string.Format("{0:X}", (x >> (int) lx.Tag) & 0xf);

            // test.Text = string.Format("{0:X}", e.Value);
            }





        }
    }
