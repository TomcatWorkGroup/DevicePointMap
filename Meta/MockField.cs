/**
* Created by jialiang on 2018/4/19.
*/
namespace GLMonitoringSystem.Devices.Meta
{
    public abstract class MockField : ByteField
    {
        protected float value;
        //public float? Data { get { return value; } }
        public override dynamic getValue()
        {
            return value;
            //return string.Format("{0:N} {1}", value, Unit);
        }


        public override void setDeviceFieldForUIKey(DeviceFieldForUI fieldForUI)
        {
            fieldForUI.Key = SdcSoftDevice.KEY_MOCK;
        }
    }
}
