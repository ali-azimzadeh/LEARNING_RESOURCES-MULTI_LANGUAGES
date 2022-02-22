using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARNING_RESOURCES
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // CultureInfo.CurrentCulture = new CultureInfo("fa-IR", false);

            //Application.CurrentInputLanguage =
            //      InputLanguage.FromCulture(
            //          System.Globalization.CultureInfo
            //          .CreateSpecificCulture("fa-IR"));


            //System.Threading.Thread.CurrentThread.CurrentCulture =
            //    System.Globalization.CultureInfo.GetCultureInfo("fa");

     
            //این قسمت از کد بر اساس اینکه آخرین زبان انتخاب شده 
            //چه است کالچر جاری سیستم را تعیین و تنظیم می کند

            int currentCulture =
                AppSettings.Default.CurrentCulture;

            switch ((ApplicationSettings.Languages)currentCulture)
            {
                case ApplicationSettings.Languages.English:
                    {
                        ApplicationSettings.CurrentCulture =
                            ApplicationSettings.Languages.English;

                        Thread.CurrentThread.CurrentUICulture = 
                            new CultureInfo("en-US");

                        Application.CurrentInputLanguage =
                                  InputLanguage.FromCulture(
                                      System.Globalization.CultureInfo
                                      .CreateSpecificCulture("en-US"));

                        break;
                    }
                case ApplicationSettings.Languages.Farsi:
                    {
                        ApplicationSettings.CurrentCulture =
                            ApplicationSettings.Languages.Farsi;

                        Thread.CurrentThread.CurrentUICulture =
                            new CultureInfo("fa-IR");

                        Application.CurrentInputLanguage =
                                  InputLanguage.FromCulture(
                                      System.Globalization.CultureInfo
                                      .CreateSpecificCulture("fa-IR"));

                        break;
                    }
            }

            Application.Run(new MyForm());
          //  Application.Run(new SampleForm());
        }
    }
}
