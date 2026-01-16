using Squido.JungleMCP.Editor.Setup;
using Squido.JungleMCP.Editor.Windows;
using UnityEditor;

namespace Squido.JungleMCP.Editor.MenuItems
{
    public static class JungleMcpMenu
    {
        [MenuItem("Tools/Squido/Jungle MCP/Toggle MCP Window %#m", priority = 1)]
        public static void ToggleMCPWindow()
        {
            if (JungleMcpEditorWindow.HasAnyOpenWindow())
            {
                JungleMcpEditorWindow.CloseAllOpenWindows();
            }
            else
            {
                JungleMcpEditorWindow.ShowWindow();
            }
        }

        [MenuItem("Tools/Squido/Jungle MCP/Local Setup Window", priority = 2)]
        public static void ShowSetupWindow()
        {
            SetupWindowService.ShowSetupWindow();
        }

        [MenuItem("internal:Tools/Squido/Jungle MCP/Edit EditorPrefs", priority = 3)]
        public static void ShowEditorPrefsWindow()
        {
            EditorPrefsWindow.ShowWindow();
        }
    }
}
