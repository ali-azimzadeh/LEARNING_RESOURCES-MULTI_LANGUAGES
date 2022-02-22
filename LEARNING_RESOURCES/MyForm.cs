using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARNING_RESOURCES
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
          
            ResourceManager resourceManager = 
                new ResourceManager("Resources.Captions",
                typeof(Resources.Captions).Assembly);
            ///
            userNameLabel.Text = resourceManager
                .GetString(name: nameof(userNameLabel));
                //Resources.Captions.UserName;

            passwordLabel.Text = resourceManager
                .GetString(name: nameof(passwordLabel));

            LoginButton.Text = resourceManager
                .GetString(name: nameof(LoginButton));

            exitButton.Text = resourceManager
                .GetString(name: nameof(exitButton));
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
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            if(ApplicationSettings.CurrentCulture ==
                ApplicationSettings.Languages.Farsi)
            {
                this.RightToLeft = RightToLeft.Yes;
                this.RightToLeftLayout = true;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool loginFlag = false;

            //کدهای مربوط به لاگین کردن را اینجا می نویسیم


            ResourceManager resourceManager =
                       new ResourceManager("Resources.ErrorMessages",
                       typeof(Resources.ErrorMessages).Assembly);

            string message = string.Empty;

            if (loginFlag == true)
            {
             
                message =
                    resourceManager.GetString(name: "InfoMessage001");
            }
            else
            {
                //The username and/or password is incorrect!

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
