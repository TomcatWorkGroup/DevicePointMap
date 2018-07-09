

using System;
/**
* Created by jialiang on 2018/4/20.
*/
namespace GLMonitoringSystem.Devices.Meta.NJZJ
{
    public class StartStopField : Base.StartStopField
    {
        public override bool haveValue(byte hByte, byte lByte)
        {

            var bs = new byte[] { lByte, hByte };
            var value = BitConverter.ToInt16(bs, 0);
            bool flag = 0x7FFF != value;
            if (flag)
            {
                hour = value / 60;
                minute = value % 60;
            }
            return flag;
        }
    }
}
