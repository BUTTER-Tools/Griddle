using System;
using System.Windows.Forms;
using System.Diagnostics;


namespace Griddle
{
    public partial class GriddleForm : Form
    {
        public GriddleForm(string VersionText)
        {
            InitializeComponent();


            ProgramDetailsLabel.Text = "Basic Unit-Transposable Text Experimentation Resource" + Environment.NewLine +
                                        "Version " + VersionText + Environment.NewLine +
                                        "(c) 2019-present" + Environment.NewLine +
                                        "Ryan L. Boyd, Ph.D.";

            this.MinimumSize = this.Size;
            this.BringToFront();
            this.TopMost = true;
            this.TopMost = false;
            griddleImageBox.Select();
        }

        private void LaunchButterButton_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.Hide();

            ProcessStartInfo start_info = new ProcessStartInfo("BUTTER.exe");
            Process proc = new Process();
            proc.StartInfo = start_info;
            proc.Start();
            Environment.Exit(0);
        }

        private void LaunchBlueberriesButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Before you update your plugins, it is VERY IMPORTANT that you do not have an instance of BUTTER currently running." + Environment.NewLine + Environment.NewLine + "If you are sure that you are not currently running BUTTER, click \"OK\" to continue. Otherwise, press the \"Cancel\" button and close all running copies of BUTTER before attempting to update.", "Update Plugins?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                //do something
                this.ShowInTaskbar = false;
                this.Hide();

                ProcessStartInfo start_info = new ProcessStartInfo("blueberries.exe");
                Process proc = new Process();
                proc.StartInfo = start_info;
                proc.Start();
                proc.WaitForExit();
                this.ShowInTaskbar = true;
                this.Show();
                this.BringToFront();
            }

        }
    }
}
