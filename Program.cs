using System.Configuration;
using RegUI.localStorage;

namespace RegUI
{
    internal static class Program
    {
        public static string userLanguage = "fr-FR";
        public static bool history = false;
        public static string ia_provider = string.Empty;

        // Globalisation host registry address
        public static string host_registry = string.Empty;

        // Stockage des informations de connexion
        public static string authToken = string.Empty;

        /// <summary>
        ///  The main entry point for the application.
        ///  Load Configuration at startup
        /// </summary>
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
             
            // Loading Configuration
            ApplicationConfiguration.Initialize();
            // Chargement de la configuration de l'application

            LocalStorage localStorage = new LocalStorage();

            userLanguage = ConfigurationManager.AppSettings.Get("userLanguage");


            Application.Run(new gestReg());
        }
    }
}