using System;
using System.Text;

namespace GLMonitoringSystem.Devices
{
    internal class Device_CTL_NJZJ_IPK2 : Device_CTL
    {
        public override string handleDeviceNo(byte[] bytes)
        {
            string deviceNo = Encoding.UTF8.GetString(bytes,10,10);
            DeviceNo = deviceNo;
            return deviceNo;
        }
        
    }
}
