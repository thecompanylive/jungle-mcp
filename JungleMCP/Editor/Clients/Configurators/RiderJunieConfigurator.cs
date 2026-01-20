using System;
using System.Collections.Generic;
using System.IO;
using Squido.JungleMCP.Editor.Constants;
using Squido.JungleMCP.Editor.Models;
using UnityEditor;

namespace Squido.JungleMCP.Editor.Clients.Configurators
{
    /// <summary>
    /// Configures MCP for JetBrains Junie (inside Rider).
    /// Junie currently supports only stdio transport and stores global config in ~/.junie/mcp/mcp.json.
    /// </summary>
    public class RiderJunieConfigurator : JsonFileMcpConfigurator
    {
        public const string ClientName = "Rider Junie";

        public RiderJunieConfigurator() : base(new McpClient
        {
            name = ClientName,

            // Junie global config path (applies to all JetBrains IDEs running Junie).
            // JetBrains docs: ~/.junie/mcp/mcp.json (and equivalent on Windows).
            windowsConfigPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                ".junie", "mcp", "mcp.json"
            ),
            macConfigPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                ".junie", "mcp", "mcp.json"
            ),
            linuxConfigPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                ".junie", "mcp", "mcp.json"
            ),

            // Junie supports stdio only (no HTTP transport).
            SupportsHttpTransport = false,

            // Keep configs tidy when env isn't needed for the selected transport.
            StripEnvWhenNotRequired = true
        })
        {
        }

        public override IList<string> GetInstallationSteps() => new List<string>
        {
            "Install/enable the Junie plugin in Rider",
            "Open Rider Settings/Preferences > Tools > Junie > MCP Settings, then click Add (this opens mcp.json)\nOR open the config file at the path above",
            "Paste the configuration JSON under the \"mcpServers\" key",
            "Save and restart Rider"
        };

        public override void Configure()
        {
            bool useHttp = EditorPrefs.GetBool(EditorPrefKeys.UseHttpTransport, true);
            if (useHttp)
            {
                throw new InvalidOperationException(
                    "Junie currently supports only stdio transport. Switch to stdio in settings before configuring."
                );
            }

            base.Configure();
        }

        public override string GetManualSnippet()
        {
            bool useHttp = EditorPrefs.GetBool(EditorPrefKeys.UseHttpTransport, true);
            if (useHttp)
            {
                return "# Junie currently supports only stdio transport.\n" +
                       "# Open Advanced Settings and disable HTTP transport to use stdio, then regenerate.";
            }

            return base.GetManualSnippet();
        }
    }
}
