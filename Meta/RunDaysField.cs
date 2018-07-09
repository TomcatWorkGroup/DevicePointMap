using System;
using System.Text;
/**
* Created by jialiang on 2018/4/19.
*/
namespace GLMonitoringSystem.Devices.Meta
{
    [Obsolete(message: "过时的，请使用具体设备命名空间中的RunDaysField")]
    public abstract class RunDaysField : ByteField
    {
        protected StringBuilder sb = new StringBuilder();
        protected int value;


        public override dynamic getValue()
        {
            return value;
        }

        public override void setDeviceFieldForUIKey(DeviceFieldForUI fieldForUI)
        {
            fieldForUI.Key = SdcSoftDevice.KEY_BASE;
        }
    }
}
