using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegUI.models
{
    public class Service
    {
        public string registry {  get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string version { get; set; }
        public string depends { get; set; }
        public Dictionary<string, string> envVariables { get; set; }
        public Dictionary<int, int> portsBinding { get; set; }
        public static string tab = "  ";

        public string getComposeName()
        {
            return registry + "/" + image + ":" + version;
        }

        public string getComposeService()
        {
            // return compose service as a string
            MessageBox.Show("Oui\n\boui");
            return "  ";
        }
    }
}
