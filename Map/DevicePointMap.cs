using GLMonitoringSystem.Devices.Meta;
using System.Collections.Generic;

namespace GLMonitoringSystem.Devices.Map
{
    /**
    * Created by jialiang on 2018/4/20.
    */

    public abstract class DevicePointMap
    {
        protected Dictionary<string, ByteField> map = new Dictionary<string, ByteField>();

        public Dictionary<string, ByteField> getPointMap()
        {
            return map;
        }
    }
}
