using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RegUI.models.APIConnector.GitHub;
public class GithubRelease
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = String.Empty;

    [JsonPropertyName("body")]
    public string Body { get; set; } = String.Empty;

    [JsonPropertyName("html_url")]
    public string Html_url { get; set; } = String.Empty;

    [JsonPropertyName("tag_name")]
    public string Tag_name { get; set; } = String.Empty;
}
