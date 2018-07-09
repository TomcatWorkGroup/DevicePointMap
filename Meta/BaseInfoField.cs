using System.Text;

namespace GLMonitoringSystem.Devices.Meta
{
    public abstract class BaseInfoField : ByteField
    {
        //protected StringBuilder sb = new StringBuilder();
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