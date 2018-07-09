using Boilers.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLMonitoringSystem.Devices.Meta.PLC
{
    public class SettingField : MockField
    {
        public override void setDeviceFieldForUIKey(DeviceFieldForUI fieldForUI)
        {
            fieldForUI.Key = SdcSoftDevice.KEY_SETTING;
        }

    }

}
