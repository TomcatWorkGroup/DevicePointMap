using System.Text;
/**
* Created by jialiang on 2018/4/20.
*/
namespace GLMonitoringSystem.Devices.Meta
{
    public abstract class DeviceField : ByteField
    {
        protected int value = 0;
        protected string deviceName;
        //public int? Status { get { return status; } }
        public string DeviceName
        {
            get
            {
                if (string.IsNullOrEmpty(deviceName))
                {
                    return Title;
                }
                else
                    return string.Format("{0}({1})", Title, deviceName);
            }
        }
        public override dynamic getValue()
        {
            //return string.Format("{0} {1}", sb, value);
            return value;
        }

        public override void setDeviceFieldForUIKey(DeviceFieldForUI fieldForUI)
        {
            fieldForUI.Key = SdcSoftDevice.KEY_DEVICE;
        }
    }
}