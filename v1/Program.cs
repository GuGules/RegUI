using System.Configuration;

namespace RegUI
{
    internal static class Program
    {
        public static string userLanguage = "fr-FR";
        public static bool history = false;
        public static string ia_provider = null;

        // Globalisation host registry address
        public static string host_registry = null;

        // Stockage des informations de connexion
        public static string authToken = null;

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