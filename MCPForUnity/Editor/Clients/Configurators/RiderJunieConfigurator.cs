using System;
using System.Collections.Generic;
using System.IO;
using MCPForUnity.Editor.Models;

namespace MCPForUnity.Editor.Clients.Configurators
{
    public class RiderJunieConfigurator : JsonFileMcpConfigurator
    {
        public RiderJunieConfigurator() : base(new McpClient
        {
            name = "Rider Junie",
            windowsConfigPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                ".junie", "mcp", "mcp.json"),
            macConfigPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                ".junie", "mcp", "mcp.json"),
            linuxConfigPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                ".junie", "mcp", "mcp.json"),
            DefaultUnityFields = new Dictionary<string, object>
            {
                { "type", "command" },
                { "enabled", true }
            }
        })
        { }

        public override IList<string> GetInstallationSteps() => new List<string>
        {
            "Install the Junie plugin in Rider (Settings > Plugins)",
            "Go to Settings > Tools > Junie > MCP Settings",
            "Paste the configuration JSON into mcp.json",
            "Save and restart Rider"
        };
    }
}
