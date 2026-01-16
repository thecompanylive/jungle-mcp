namespace Squido.JungleMCP.Editor.Constants
{
    /// <summary>
    /// Centralized list of EditorPrefs keys used by the MCP for Unity package.
    /// Keeping them in one place avoids typos and simplifies migrations.
    /// </summary>
    internal static class EditorPrefKeys
    {
        internal const string UseHttpTransport = "JungleMPC.UseHttpTransport";
        internal const string HttpTransportScope = "JungleMPC.HttpTransportScope"; // "local" | "remote"
        internal const string LastLocalHttpServerPid = "JungleMPC.LocalHttpServer.LastPid";
        internal const string LastLocalHttpServerPort = "JungleMPC.LocalHttpServer.LastPort";
        internal const string LastLocalHttpServerStartedUtc = "JungleMPC.LocalHttpServer.LastStartedUtc";
        internal const string LastLocalHttpServerPidArgsHash = "JungleMPC.LocalHttpServer.LastPidArgsHash";
        internal const string LastLocalHttpServerPidFilePath = "JungleMPC.LocalHttpServer.LastPidFilePath";
        internal const string LastLocalHttpServerInstanceToken = "JungleMPC.LocalHttpServer.LastInstanceToken";
        internal const string DebugLogs = "JungleMPC.DebugLogs";
        internal const string ValidationLevel = "JungleMPC.ValidationLevel";
        internal const string UnitySocketPort = "JungleMPC.UnitySocketPort";
        internal const string ResumeHttpAfterReload = "JungleMPC.ResumeHttpAfterReload";
        internal const string ResumeStdioAfterReload = "JungleMPC.ResumeStdioAfterReload";

        internal const string UvxPathOverride = "JungleMPC.UvxPath";
        internal const string ClaudeCliPathOverride = "JungleMPC.ClaudeCliPath";

        internal const string HttpBaseUrl = "JungleMPC.HttpUrl";
        internal const string SessionId = "JungleMPC.SessionId";
        internal const string WebSocketUrlOverride = "JungleMPC.WebSocketUrl";
        internal const string GitUrlOverride = "JungleMPC.GitUrlOverride";
        internal const string DevModeForceServerRefresh = "JungleMPC.DevModeForceServerRefresh";

        internal const string PackageDeploySourcePath = "JungleMPC.PackageDeploy.SourcePath";
        internal const string PackageDeployLastBackupPath = "JungleMPC.PackageDeploy.LastBackupPath";
        internal const string PackageDeployLastTargetPath = "JungleMPC.PackageDeploy.LastTargetPath";
        internal const string PackageDeployLastSourcePath = "JungleMPC.PackageDeploy.LastSourcePath";

        internal const string ServerSrc = "JungleMPC.ServerSrc";
        internal const string UseEmbeddedServer = "JungleMPC.UseEmbeddedServer";
        internal const string LockCursorConfig = "JungleMPC.LockCursorConfig";
        internal const string AutoRegisterEnabled = "JungleMPC.AutoRegisterEnabled";
        internal const string ToolEnabledPrefix = "JungleMPC.ToolEnabled.";
        internal const string ToolFoldoutStatePrefix = "JungleMPC.ToolFoldout.";
        internal const string EditorWindowActivePanel = "JungleMPC.EditorWindow.ActivePanel";

        internal const string SetupCompleted = "JungleMPC.SetupCompleted";
        internal const string SetupDismissed = "JungleMPC.SetupDismissed";

        internal const string CustomToolRegistrationEnabled = "JungleMPC.CustomToolRegistrationEnabled";

        internal const string LastUpdateCheck = "JungleMPC.LastUpdateCheck";
        internal const string LatestKnownVersion = "JungleMPC.LatestKnownVersion";
        internal const string LastStdIoUpgradeVersion = "JungleMPC.LastStdIoUpgradeVersion";
    }
}
