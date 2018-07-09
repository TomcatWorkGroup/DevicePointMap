namespace GLMonitoringSystem.Devices.Meta.PLC
{

    public class BaseInfoField : Meta.BaseInfoField
    {

        /// <summary>
        /// byte数组 高位在前，低位在后
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public override bool haveValue(params byte[] bytes)
        {
            value = ((bytes[0] & 0xFF) << 8) | (bytes[1] & 0xFF);
            return 0x7FFF != value;
        }
        public override string getValueString()
        {
            if (null != ValueMap)
                return ValueMap[value];

            return base.getValueString();
        }
    }
}
