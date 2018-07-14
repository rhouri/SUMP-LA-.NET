using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using SUMPLA_net.Properties;


// http://www.codeproject.com/useritems/pullaparttabpage.asp
namespace SUMPLA_net
   {
   #region my enums
   public enum TabMode
      {
      Dock,
      Float
      };
   #endregion

   public partial class PullApartTabPage :TabPage
      {
      #region my vars
      private TabMode mode;
      private Button btnchangemode;
      private Form myform;
      private TabControl mytabparent;
      #endregion



      #region data axcessors
      [System.ComponentModel.Browsable(false)]
      public TabMode TabMode
         {
         get
            {
            return mode;
            }
         set
            {
            /// this prevents erroes from someone going 
            /// TabMode = TabMode.Dock;
            /// TabMode = TabMode.Dock;
            /// TabMode = TabMode.Dock;
            /// TabMode = TabMode.Dock;
            if (mode == value)
               return;
            /// we always want to flip the arrow around when we chance back and forth. 
            /// it make it look nicer
            btnchangemode.Image.RotateFlip(System.Drawing.RotateFlipType.RotateNoneFlipXY);

            mode = value;
            if (value == TabMode.Float)
               {
               /// resize the form prior to moving the controls to it to avoid position 
               /// and anchor issues
               myform.Size = this.Size;
               /// put the text of the tab on the form as its title
               myform.Text = "Wis International: "+Text;

               /// decide who your parent is and remember it since you probably want to re-dock 
               /// eventually
               mytabparent = (TabControl) Parent;
              
               mytabparent.TabPages.Remove(this);

               #region transfer controls
               /// you can't remove from a collection inside a foreach over the same collection 
               /// so you have to make a temp collection
               List<Control> lcontrols = new List<Control>();
               foreach (Control c in this.Controls)
                  lcontrols.Add(c);
               foreach (Control c in lcontrols)
                  this.Controls.Remove(c);
               foreach (Control c in lcontrols)
                  myform.Controls.Add(c);
               #endregion

               /// not all of the form space is available to us
               /// see the code project article


               btnchangemode.Location = new System.Drawing.Point(myform.Width - btnchangemode.Width - 8, Height - btnchangemode.Height - 8);

               /// show the form and bring it to the front
               myform.Show();
               myform.Focus();
               }
            else if (value == TabMode.Dock)
               {
               if (mytabparent != null)
                  {
                  mytabparent.TabPages.Add(this);
                  /// resize the form prior to moving the controls to it to avoid position 
                  /// and anchor issues
                  myform.Size = this.Size;
                  mytabparent.SelectedTab = this;
                  }

               /// hide the form, don't get rid of it, we will want to reuse it later
               myform.Hide();

               #region transfer controls
               /// you can't remove from a collection inside a foreach over the same collection 
               /// so you have to make a temp collection
               List<Control> controls = new List<Control>();
               foreach (Control c in myform.Controls)
                  controls.Add(c);
               foreach (Control c in controls)
                  myform.Controls.Remove(c);
               foreach (Control c in controls)
                  this.Controls.Add(c);
               #endregion

               /// not all of the form space is available to us
               /// see the code project article
               btnchangemode.Location = new System.Drawing.Point(this.Width - btnchangemode.Width - 8,  Height - btnchangemode.Height - 8);
               }
            else
               throw new ApplicationException("unknown TabMode enum");
            }
         }
      #endregion

      #region constructor
      public PullApartTabPage ()
         {
         
         /// normally vs2005 dose all this stuff for us, but since a tabpage doesn't have a nice 
         /// viewable interface we have to do most of the construction by hand

         /// we will be using the same form over and over for simplicity
         myform = new Form();
         /// prevent accidental closure
         myform.FormClosing += new FormClosingEventHandler(myform_FormClosing);
         /// we don't want all the separate windows appearing in the task bar
         myform.ShowInTaskbar = false;

         /// make the button we use to tell the app to dock/undock
         btnchangemode = new Button();
         btnchangemode.Image = Resources.arrow;
         btnchangemode.Size = btnchangemode.Image.Size;
         btnchangemode.Click += new EventHandler(btnchangemode_Click);
         btnchangemode.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
         /// a studious observer will note that there is no btnchangemode.Location. 
         /// see the code project article  for an explanation
         Controls.Add(btnchangemode);

         mode = TabMode.Dock;
         
         this.SizeChanged += new EventHandler(PullApartTabPage_SizeChanged);
         this.ResizeRedraw = true;
         }
         
      private void PullApartTabPage_SizeChanged ( object sender, EventArgs e )
         {
         /// this is an artifact of using the vs2005 designer. see the code project 
         /// article  for an explanation
         if (btnchangemode.Parent == this)
            btnchangemode.Location = new System.Drawing.Point(Width - btnchangemode.Width - 3, Height-btnchangemode.Height-3);
         this.Invalidate();
         }
      #endregion

      #region change mode
      private void myform_FormClosing ( object sender, FormClosingEventArgs e )
         {
         /// you don't want the user to close the undocked form then not be 
         /// able to get to all the controls that were on the form. so cancel 
         /// the close and dock the tabpage. this hides the form too.
         e.Cancel = true;
         TabMode = TabMode.Dock;
         }
         
         
         
         
         
      private void btnchangemode_Click ( object sender, EventArgs e )
         {
         if (TabMode == TabMode.Dock)
            TabMode = TabMode.Float;
         else
            TabMode = TabMode.Dock;
         }
      #endregion


      }
   }
 
