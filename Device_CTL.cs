using GLMonitoringSystem.Devices.Meta;

namespace GLMonitoringSystem.Devices
{
    internal abstract class Device_CTL : SdcSoftDevice
    {
        public override void handleByteFileds(ByteField field, byte[] bytes)
        {
            if (field.haveValue(bytes[field.StartIndex], bytes[field.StartIndex + 1]))
            {
                this.AddField(field.getDeviceFieldForUI());
            }
        }
    }
}
