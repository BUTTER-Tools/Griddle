using System;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Griddle
{
    static class griddle
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            var versionInfo = FileVersionInfo.GetVersionInfo("BUTTER.exe");
            string VersionText = versionInfo.FileVersion.ToString();


            #region Check for Updates

            //check for updates
            try
            {
                MyWebClient client = new MyWebClient();
                client.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
                Stream stream = client.OpenRead("https://www.butter.tools/butterversion.txt");
                StreamReader reader = new StreamReader(stream);
                string[] content = reader.ReadToEnd().Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                if ((content[0] != VersionText) && (content[0].Length < 10))
                {
                    var result = MessageBox.Show("A new version of BUTTER (v" + content[0] + ") is available for download." + Environment.NewLine + Environment.NewLine + "Would you like to download the update now?", "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(content[1]);
                            Environment.Exit(0);
                        }
                        catch
                        {

                        }
                    }
                }
            }
            //run program if there's an error in the check
            catch
            {

            }

            #endregion



            System.Drawing.Image[] splashArray = new System.Drawing.Image[] {Griddle.Properties.Resources.AllieSplashArt_01,
                                                                             Griddle.Properties.Resources.AllieSplashArt_02 };


            Griddle.SplashForm splashForm = new Griddle.SplashForm(VersionText);
            splashForm.BackColor = System.Drawing.Color.Transparent;
            Random rand = new Random();
            splashForm.BackgroundImage = splashArray[rand.Next(splashArray.Length)];

            Application.Run(splashForm);

            Application.Run(new GriddleForm(VersionText));
        }



        //just setting that timeout to 5 seconds max
        private class MyWebClient : WebClient
        {
            protected override WebRequest GetWebRequest(Uri uri)
            {
                WebRequest w = base.GetWebRequest(uri);
                w.Timeout = 5000;
                return w;
            }
        }



    }
}
