using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegUI.models.Utils
{
    public static class Randomer
    {
        public static List<string> adjectives = new List<string>
        {
             "Big", "Small", "Strong", "Weak", "Beautiful", "Ugly", "Old", "Young", "Tall", "Short",
            "Fast", "Slow", "Smart", "Dumb", "Clean", "Dirty", "Kind", "Mean", "Polite", "Rude",
            "Brave", "Scared", "Calm", "Nervous", "Rich", "Poor", "Happy", "Sad", "Angry", "Generous",
            "Greedy", "Funny", "Serious", "Loyal", "Disloyal", "Friendly", "Hostile", "Tired", "Energetic", "Lazy",
            "Busy", "Quiet", "Noisy", "Nice", "Nasty", "Helpful", "Selfish", "Honest", "Dishonest", "Clever",
            "Stupid", "Curious", "Bored", "Faithful", "Unfaithful", "Fair", "Unfair", "Soft", "Hard", "Cold",
            "Warm", "Hot", "Cool", "Dry", "Wet", "Bright", "Dark", "Shiny", "Dull", "Smooth",
            "Rough", "Sweet", "Bitter", "Sour", "Salty", "Spicy", "Fresh", "Stale", "Safe", "Dangerous",
            "Wide", "Narrow", "Thick", "Thin", "Deep", "Shallow", "Heavy", "Light", "Open", "Closed",
            "Early", "Late", "Modern", "Ancient", "Real", "Fake", "Organic", "Artificial", "Visible", "Invisible"
        };

        public static List<string> techNames = new List<string>(){
            "computer", "laptop", "desktop", "keyboard", "mouse", "monitor", "screen", "server", "router", "switch",
            "firewall", "database", "cloud", "network", "website", "browser", "tab", "window", "file", "folder",
            "directory", "path", "drive", "disk", "SSD", "HDD", "processor", "CPU", "GPU", "RAM",
            "port", "cable", "adapter", "hub", "script", "program", "application", "software", "firmware", "system",
            "OS", "kernel", "process", "thread", "task", "service", "package", "library", "framework", "API",
            "command", "terminal", "shell", "prompt", "editor", "IDE", "tool", "plugin", "extension", "debugger",
            "bug", "error", "issue", "crash", "fix", "patch", "update", "version", "release", "build",
            "repository", "commit", "branch", "merge", "pull", "push", "fork", "clone", "script", "function",
            "class", "object", "method", "variable", "constant", "type", "array", "list", "queue", "stack",
            "token", "session", "cookie", "log", "event", "request", "response", "protocol", "packet", "IP"
        };

        public static string genRandomName()
        {
            Random random = new Random();
            return adjectives[random.Next(adjectives.Count)] + "_" + techNames[random.Next(techNames.Count)];
        }
    }
}
