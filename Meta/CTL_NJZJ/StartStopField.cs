using System;

namespace GLMonitoringSystem.Devices.Meta.CTL_NJZJ
{
    public class StartStopField : Meta.StartStopField
    {
        public override bool haveValue(params byte[] bytes)
        {
            value = BitConverter.ToInt16(bytes, 0);           
            return value != 0x7FFF;

            // 解析算法
            //hour = value / 60;
            //minute = value % 60;
        }

        public override string getValueString()
        {
            return string.Format("{0:D2}:{1:D2}", value / 60, value % 60);
        }
    
}
}
