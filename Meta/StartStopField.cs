/**
* Created by jialiang on 2018/4/20.
*/
namespace GLMonitoringSystem.Devices.Meta
{
    /// <summary>
    /// 启停信息
    /// </summary>
    public abstract class StartStopField : ByteField
    {
        /// <summary>
        /// 低字节小时数，高字节分钟数
        /// </summary>
        protected short value;
        public override dynamic getValue()
        {
            return value;
            //return string.Format("{0:D2}:{1:D2}", hour, minute);
        }

        public override void setDeviceFieldForUIKey(DeviceFieldForUI fieldForUI)
        {
            fieldForUI.Key = SdcSoftDevice.KEY_START_STOP;
        }
    }
}

