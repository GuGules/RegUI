using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RegUI.models
{
    public class Service
    {
        public string tab = "  ";
        public string registry {  get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string tag { get; set; }
        public Service depends { get; set; }
        public Dictionary<string, string> envVariables { get; set; }
        public Dictionary<string, string> portsBinding { get; set; }
        public Dictionary<string, string> volumes { get; set; }

        public string getComposeName()
        {
            return registry + "/" + image + ":" + tag;
        }

        public string getComposeService()
        {
            string composeService = "";
            composeService += tab + name + ":" + "\n";
            if (registry is null)
            {
                composeService += tab + tab + "image: " + image + ":" + tag + "\n";
            } else
            {
                composeService += tab + tab + "image: " + registry+"/"+image + ":" + tag + "\n";
            }
            if (depends is not null)
            {
                composeService += tab + tab + "depends_on:\n";
                composeService += tab + tab + tab + "- " + depends.name + "\n";
            }
            if (portsBinding != new Dictionary<string, string>())
            {
                composeService += tab + tab + "ports:\n";
                foreach (var affectation in portsBinding.Keys)
                {
                    composeService += tab + tab + tab + "- \"" + affectation + ":" + portsBinding[affectation] + "\"\n";
                }
            }
            if (volumes != new Dictionary<string, string>())
            {
                composeService += tab + tab + "volumes:\n";
                foreach (var loc in volumes.Keys)
                {
                    composeService += tab + tab + tab + "- \"" + loc + ":" + volumes[loc] + "\"\n";
                }
            }
            if (envVariables != new Dictionary<string, string>())
            {
                composeService += tab + tab + "environment:\n";
                foreach (var envVar in envVariables.Keys)
                {
                    composeService += tab + tab + tab + "- \"" + envVar + ":" + envVariables[envVar] + "\"\n";
                }
            }
            // return compose service as a string
            return composeService;
        }
    }
}
