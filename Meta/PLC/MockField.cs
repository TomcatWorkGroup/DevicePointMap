using Boilers.Util;

namespace GLMonitoringSystem.Devices.Meta.PLC
{
    public class MockField : Meta.MockField
    {
        public override bool haveValue(params byte[] bytes)
        {
            if (0x7FFFFFFF == ByteUtil.bytesToInt(bytes))
                return false;

            value = ByteUtil.bytesToFloat(bytes);

            return true;
        }
    }
}
