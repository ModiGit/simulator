/**
 * Copyright (c) 2019 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */

using Simulator.Sensors;
using System.Collections.Generic;
using UnityEngine;

namespace Simulator.Utilities
{
    [CreateAssetMenu(fileName = "RuntimeSettings", menuName = "Simulator/Runtime Settings")]
    public class RuntimeSettings : ScriptableObject
    {
        static RuntimeSettings InstanceCache;

        public static RuntimeSettings Instance
            => InstanceCache != null ? InstanceCache : InstanceCache = Resources.Load<RuntimeSettings>("RuntimeSettings");


        [Tooltip("Shader to use for drawing wireframe boxes")]
        public Shader WireframeBoxShader;

        [Tooltip("Shader to use for drawing point cloud for lidar")]
        public Shader PointCloudShader;

        [Tooltip("Prefabs of usable Sensors in Backend API Configuration")]
        public List<SensorBase> SensorPrefabs;
    }
}
