using System;
using Newtonsoft.Json;

namespace Squido.JungleMCP.Editor.Models
{
    [Serializable]
    public class McpConfigServers
    {
        [JsonProperty("unityMCP")]
        public McpConfigServer unityMCP;
    }
}
