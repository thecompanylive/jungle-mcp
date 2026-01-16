using System;
using System.IO;
using Newtonsoft.Json.Linq;
using Squido.JungleMCP.Editor.Helpers;
using UnityEditor;
using UnityEngine;

namespace Squido.JungleMCP.Editor.Resources.Project
{
    /// <summary>
    /// Provides static project configuration information.
    /// </summary>
    [JungleMcpResource("get_project_info")]
    public static class ProjectInfo
    {
        public static object HandleCommand(JObject @params)
        {
            try
            {
                string assetsPath = Application.dataPath.Replace('\\', '/');
                string projectRoot = Directory.GetParent(assetsPath)?.FullName.Replace('\\', '/');
                string projectName = Path.GetFileName(projectRoot);

                var info = new
                {
                    projectRoot = projectRoot ?? "",
                    projectName = projectName ?? "",
                    unityVersion = Application.unityVersion,
                    platform = EditorUserBuildSettings.activeBuildTarget.ToString(),
                    assetsPath = assetsPath
                };

                return new SuccessResponse("Retrieved project info.", info);
            }
            catch (Exception e)
            {
                return new ErrorResponse($"Error getting project info: {e.Message}");
            }
        }
    }
}
