namespace Squido.JungleMCP.Editor.Constants
{
    /// <summary>
    /// Centralized list of EditorPrefs keys used by the MCP for Unity package.
    /// Keeping them in one place avoids typos and simplifies migrations.
    /// </summary>
    internal static class EditorPrefKeys
    {
        internal const string UseHttpTransport = "JungleMCP.UseHttpTransport";
        internal const string HttpTransportScope = "JungleMCP.HttpTransportScope"; // "local" | "remote"
        internal const string LastLocalHttpServerPid = "JungleMCP.LocalHttpServer.LastPid";
        internal const string LastLocalHttpServerPort = "JungleMCP.LocalHttpServer.LastPort";
        internal const string LastLocalHttpServerStartedUtc = "JungleMCP.LocalHttpServer.LastStartedUtc";
        internal const string LastLocalHttpServerPidArgsHash = "JungleMCP.LocalHttpServer.LastPidArgsHash";
        internal const string LastLocalHttpServerPidFilePath = "JungleMCP.LocalHttpServer.LastPidFilePath";
        internal const string LastLocalHttpServerInstanceToken = "JungleMCP.LocalHttpServer.LastInstanceToken";
        internal const string DebugLogs = "JungleMCP.DebugLogs";
        internal const string ValidationLevel = "JungleMCP.ValidationLevel";
        internal const string UnitySocketPort = "JungleMCP.UnitySocketPort";
        internal const string ResumeHttpAfterReload = "JungleMCP.ResumeHttpAfterReload";
        internal const string ResumeStdioAfterReload = "JungleMCP.ResumeStdioAfterReload";

        internal const string UvxPathOverride = "JungleMCP.UvxPath";
        internal const string ClaudeCliPathOverride = "JungleMCP.ClaudeCliPath";

        internal const string HttpBaseUrl = "JungleMCP.HttpUrl";
        internal const string SessionId = "JungleMCP.SessionId";
        internal const string WebSocketUrlOverride = "JungleMCP.WebSocketUrl";
        internal const string GitUrlOverride = "JungleMCP.GitUrlOverride";
        internal const string DevModeForceServerRefresh = "JungleMCP.DevModeForceServerRefresh";
        internal const string ProjectScopedToolsLocalHttp = "JungleMCP.ProjectScopedTools.LocalHttp";

        internal const string PackageDeploySourcePath = "JungleMCP.PackageDeploy.SourcePath";
        internal const string PackageDeployLastBackupPath = "JungleMCP.PackageDeploy.LastBackupPath";
        internal const string PackageDeployLastTargetPath = "JungleMCP.PackageDeploy.LastTargetPath";
        internal const string PackageDeployLastSourcePath = "JungleMCP.PackageDeploy.LastSourcePath";

        internal const string ServerSrc = "JungleMCP.ServerSrc";
        internal const string UseEmbeddedServer = "JungleMCP.UseEmbeddedServer";
        internal const string LockCursorConfig = "JungleMCP.LockCursorConfig";
        internal const string AutoRegisterEnabled = "JungleMCP.AutoRegisterEnabled";
        internal const string ToolEnabledPrefix = "JungleMCP.ToolEnabled.";
        internal const string ToolFoldoutStatePrefix = "JungleMCP.ToolFoldout.";
        internal const string EditorWindowActivePanel = "JungleMCP.EditorWindow.ActivePanel";

        internal const string SetupCompleted = "JungleMCP.SetupCompleted";
        internal const string SetupDismissed = "JungleMCP.SetupDismissed";

        internal const string CustomToolRegistrationEnabled = "JungleMCP.CustomToolRegistrationEnabled";

        internal const string LastUpdateCheck = "JungleMCP.LastUpdateCheck";
        internal const string LatestKnownVersion = "JungleMCP.LatestKnownVersion";
        internal const string LastStdIoUpgradeVersion = "JungleMCP.LastStdIoUpgradeVersion";

        internal const string TelemetryDisabled = "JungleMCP.TelemetryDisabled";
        internal const string CustomerUuid = "JungleMCP.CustomerUUID";
    }
}
