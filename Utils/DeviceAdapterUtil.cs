using GLMonitoringSystem.Devices.Map;
using GLMonitoringSystem.Devices.Meta;
using System;

namespace GLMonitoringSystem.Devices.Utils
{
    public class DeviceAdapterUtil
    {
      
        /**
         * 获得plc数据信息
         *
         * @param bytes
         * @return
        **/
        public static SdcSoftDevice getDeviceFromByteArray(byte[] bytes, string typeName)
        {
            SdcSoftDevice device = null;
            try
            {
                //DevicePointMap devicePointMap = Activator.CreateInstance(null, string.Format("GLMonitoringSystem.Devices.Map.DevicePointMap__{0}", typeName)).Unwrap() as DevicePointMap;
                var devicePointMap = MapHelper.GetDevicePointMap(typeName);
                if (devicePointMap == null)
                    return null;

                device = Activator.CreateInstance(null, string.Format("GLMonitoringSystem.Devices.Device_{0}", typeName)).Unwrap() as SdcSoftDevice;
                if (!device.validate(bytes.Length))
                {
                    return null;
                }

                device.handleDeviceNo(bytes);

                foreach (string key in devicePointMap.getPointMap().Keys)
                {
                    ByteField f = devicePointMap.getPointMap()[key];
                    device.handleByteFileds(f, bytes);
                }
            }
            catch (Exception e)
            {
               Console.WriteLine(e.Message);
            }
            return device;
        }
    }
}
