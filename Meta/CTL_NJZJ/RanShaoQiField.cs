namespace GLMonitoringSystem.Devices.Meta.CTL_NJZJ
{
    public class RanShaoQiField : DeviceField
    {
        /// <summary>
        /// byte数组 高位在前，低位在后
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public override bool haveValue(params byte[] bytes)
        {
            int i = bytes[0]  | (bytes[1] << 8) ;

            if (0x7FFF == i)
                return false;

            value = bytes[0];
            return true;
        }

        public override string getValueString()
        {
            if (null != ValueMap)
                return ValueMap[value];

            return base.getValueString();
        }
    }
}
