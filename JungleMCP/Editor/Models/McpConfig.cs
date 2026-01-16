using System;
using Newtonsoft.Json;

namespace Squido.JungleMCP.Editor.Models
{
    [Serializable]
    public class McpConfig
    {
        [JsonProperty("mcpServers")]
        public McpConfigServers mcpServers;
    }
}
