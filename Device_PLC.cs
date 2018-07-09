using GLMonitoringSystem.Devices.Meta;
using System;

namespace GLMonitoringSystem.Devices
{
    internal class Device_PLC : SdcSoftDevice
    {
        public override void handleByteFileds(ByteField field, byte[] bytes)
        {
            if (field.BytesLength == 2)
            {
                if (field.haveValue(bytes[field.StartIndex + 1], bytes[field.StartIndex]))
                {
                    this.AddField(field.getDeviceFieldForUI());
                }
            }
            else if (field.BytesLength == 4)
            {
                if (field.haveValue(bytes[field.StartIndex + 3], bytes[field.StartIndex + 2], bytes[field.StartIndex + 1], bytes[field.StartIndex]))
                {
                    this.AddField(field.getDeviceFieldForUI());
                }
            }
        }


        public override string handleDeviceNo(byte[] bytes)
        {
            byte[] bs = new byte[] { bytes[5], bytes[6], bytes[7], bytes[8] };
            int x = BitConverter.ToInt32(bs, 0);
            string deviceNo = x.ToString(); ;
            DeviceNo = deviceNo;
            return deviceNo;
        }
    }
}
