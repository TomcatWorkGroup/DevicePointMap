using System;
using System.Collections.Generic;

namespace GLMonitoringSystem.Devices.Map
{
    class MapHelper
    {
        private static Dictionary<string, DevicePointMap> map = new Dictionary<string, DevicePointMap>(30);

        /// <summary>
        /// 获取设备点位映射表，线程安全的
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public static DevicePointMap GetDevicePointMap(string typeName)
        {
            DevicePointMap item = null;
            lock (map)
            {
                if (map.ContainsKey(typeName))
                    item = map[typeName];
                else
                {
                    DevicePointMap devicePointMap = Activator.CreateInstance(null, string.Format("GLMonitoringSystem.Devices.Map.DevicePointMap_{0}", typeName)).Unwrap() as DevicePointMap;
                    map.Add(typeName, devicePointMap);
                    item = devicePointMap;
                }
            }
            return item;
        }
    }
}
