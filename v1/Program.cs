using System.Configuration;
using System.Collections.Specialized;

namespace RegUI
{
    internal static class Program
    {
        public static string userLanguage = "en-EN";
        public static bool history = false;
        public static string ia_provider = null²;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Chargement de la configuration de l'application
            userLanguage = ConfigurationManager.AppSettings.Get("userLanguage");


            Application.Run(new gestReg());
        }
    }
}