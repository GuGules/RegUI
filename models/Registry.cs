using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegUI.models;

public class Registry
{
    public int? Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Url { get; set; } = String.Empty;
    public bool Secured { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
}
