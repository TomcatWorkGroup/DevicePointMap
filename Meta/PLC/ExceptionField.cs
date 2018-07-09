using System;

namespace GLMonitoringSystem.Devices.Meta.PLC
{
    public class ExceptionField : Meta.ExceptionField
    {
        public override bool haveValue(params byte[] bytes)
        {
            byte[] bs = new byte[] { bytes[0], bytes[1] };
            int x = BitConverter.ToInt16(bs, 0);

            int i = 1 << Bit;
            if ((i & x) == i)
            {
                value = 1;
                return true;
            }
            else
            {
                value = 0;
                return false;
            }
        }
    }

}
