using System;
using System.Windows.Forms;


namespace Griddle
{
    public partial class SplashForm : Form
    {

                
        public SplashForm(string VersionText)
        {

            //make sure that we can use a transparent background for the form
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;

            InitializeComponent();

            TitleLabel.Text = "BUTTER (v" + VersionText + ")";

            

        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            this.Close();

        }


    }
}
