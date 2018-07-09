using GetDataTest.Entity.Meta.Base;
using System;

namespace GLMonitoringSystem.Devices.Meta.NJZJ
{
    public class SettingField : Base.SettingField
    {
        public override void setDeviceFieldForUIKey(DeviceFieldForUI fieldForUI)
        {
            fieldForUI.Key = Device.KEY_SETTING;
        }

        public override bool haveValue(byte hByte, byte lByte)
        {
            var bs = new byte[] { lByte, hByte };
            var value = BitConverter.ToInt16(bs, 0);
            if (0x7FFF == value)
                return false;

            if (BaseNumber > 0)
                data = value * 1.0f / BaseNumber;
            else
                data = value;
            return true;
        }
    }
}