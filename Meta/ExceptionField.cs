/**
* Created by jialiang on 2018/4/19.
*/
namespace GLMonitoringSystem.Devices.Meta
{
    public abstract class ExceptionField : ByteField
    {
        protected int value;

        public override dynamic getValue()
        {
            return value;
        }

        public override void setDeviceFieldForUIKey(DeviceFieldForUI fieldForUI)
        {
            fieldForUI.Key = SdcSoftDevice.KEY_EXCEPTION;
        }
    }
}
