using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Squido.JungleMCP.Editor.Helpers;
using UnityEngine;

namespace Squido.JungleMCP.Editor.Resources.Project
{
    /// <summary>
    /// Provides dictionary of layer indices to layer names.
    /// </summary>
    [JungleMcpResource("get_layers")]
    public static class Layers
    {
        private const int TotalLayerCount = 32;

        public static object HandleCommand(JObject @params)
        {
            try
            {
                var layers = new Dictionary<int, string>();
                for (int i = 0; i < TotalLayerCount; i++)
                {
                    string layerName = LayerMask.LayerToName(i);
                    if (!string.IsNullOrEmpty(layerName))
                    {
                        layers.Add(i, layerName);
                    }
                }

                return new SuccessResponse("Retrieved current named layers.", layers);
            }
            catch (Exception e)
            {
                return new ErrorResponse($"Failed to retrieve layers: {e.Message}");
            }
        }
    }
}
