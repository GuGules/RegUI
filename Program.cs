using Microsoft.Extensions.Configuration;
using Microsoft.Toolkit.Uwp.Notifications;
using RegUI.localStorage;
using RegUI.models.APIConnector.GitHub;
using System.Net.Http.Json;
using System.Text.Json;
namespace RegUI
{
    internal static class Program
    {
        public static string userLanguage = "fr-FR";
        public static bool history = false;
        public static string ia_provider = string.Empty;
        public static IConfiguration config = new ConfigurationBuilder().SetBasePath(AppContext.BaseDirectory).AddJsonFile("appconfig.json", optional: false).Build();

        //Repositories pour le localStorage
        public static RegistryRepository registryRepository = new RegistryRepository();

        // Globalisation host registry address
        public static string host_registry = string.Empty;

        // Stockage des informations de connexion
        public static string authToken = string.Empty;

        public async static Task checkUpdate()
        {
            HttpClient http = new();
            http.DefaultRequestHeaders.Add("Accept", "application/vnd.github+json");
            http.DefaultRequestHeaders.Add("X-GitHub-Api-Version", "2022-11-28");
            http.DefaultRequestHeaders.Add("User-Agent", "ReguiWindows");

            HttpResponseMessage res = await http.GetAsync("https://api.github.com/repos/GuGules/RegUI/releases");

            if (res.IsSuccessStatusCode)
            {
                HttpContent content = res.Content;
                string stringReleasesData = await content.ReadAsStringAsync();
                List<GithubRelease> releasesData = JsonSerializer.Deserialize<List<GithubRelease>>(stringReleasesData) ?? [];

                string lastVersionOnline = releasesData[0].Name;
                string appVersion = config.GetSection("appdata")["version"] ?? String.Empty;

                if (lastVersionOnline != appVersion)
                {
                    new ToastContentBuilder().AddText("Nos versions diffèrent 😢").AddText("Réfléchissez à faire la mise à jour pour profiter de toutes les nouvelles fonctionnalités 🎉").Show();
                }
            }
            else
            {
                MessageBox.Show("nope\n", res.StatusCode.ToString());
            }

        }


        /// <summary>
        ///  The main entry point for the application.
        ///  Load Configuration at startup
        /// </summary>
        /// 
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            // Loading Configuration
            ApplicationConfiguration.Initialize();
            checkUpdate();

            Application.Run(new gestReg());
        }
    }
}