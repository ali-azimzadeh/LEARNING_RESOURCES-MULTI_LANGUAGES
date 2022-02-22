using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARNING_RESOURCES
{
    public partial class SampleForm : Form
    {
        public SampleForm()
        {
            // Sets the culture to French (France)  
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("fa-IR");
            //// Sets the UI culture to French (France)  
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("fa-IR");
            InitializeComponent();

     
        }

        private void farsiButton_Click(object sender, EventArgs e)
        {
            switch (ApplicationSettings.CurrentCulture)
            {
                case ApplicationSettings.Languages.English:
                    {
                        ApplicationSettings.CurrentCulture = 
                            ApplicationSettings.Languages.Farsi;

                        break;
                    }
                case ApplicationSettings.Languages.Farsi:
                    {
                        ApplicationSettings.CurrentCulture =
                            ApplicationSettings.Languages.English;

                        break;
                    }
            }

            AppSettings.Default.CurrentCulture =
                ((int)ApplicationSettings.CurrentCulture);

            AppSettings.Default.Save();

            Application.Restart();

            //ResourceManager rm = 
            //    new ResourceManager("Resources.Captions", typeof(Resources.Captions).Assembly);
            ////MessageBox.Show(rm.GetString("Exit"));
            //exitButton.Text = rm.GetString("Exit");

            //InitializeComponent();
            //this.Invalidate();
            //this.Refresh();
        }

        protected override void OnShown(EventArgs e)
        {
            //System.Threading.Thread.CurrentThread.CurrentCulture =
            //    System.Globalization.CultureInfo.GetCultureInfo("fa");

            base.OnShown(e);
        }
        private void SampleForm_Load(object sender, EventArgs e)
        {
          //   CultureInfo.CurrentCulture = new CultureInfo("fa-IR", false);

            //Application.CurrentInputLanguage =
            //          InputLanguage.FromCulture(
            //              System.Globalization.CultureInfo
            //              .CreateSpecificCulture("fa-IR"));

       
            
     
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool loginFlag = true;

            //کدهای مربوط به لاگین کردن را اینجا می نویسیم
           

            ResourceManager resourceManager =
                       new ResourceManager("LEARNING_RESOURCES.SampleForm",
                       typeof(SampleForm).Assembly);
            
            string message = string.Empty;

            if (loginFlag == true)
            {
                message =
                    resourceManager.GetString(name: "InfoMessage001");
            }
            else
            {
                message =
                    resourceManager.GetString(name: "ErrorMessage001");
            }

            MessageBox.Show(text: message);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
