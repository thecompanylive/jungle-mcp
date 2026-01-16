using System;
using Squido.JungleMCP.Editor.Constants;
using Squido.JungleMCP.Editor.Services.Transport.Transports;
using UnityEditor;

namespace Squido.JungleMCP.Editor
{
    public static class McpCiBoot
    {
        public static void StartStdioForCi()
        {
            try 
            { 
                EditorPrefs.SetBool(EditorPrefKeys.UseHttpTransport, false); 
            }
            catch { /* ignore */ }

            StdioBridgeHost.StartAutoConnect();
        }
    }
}
