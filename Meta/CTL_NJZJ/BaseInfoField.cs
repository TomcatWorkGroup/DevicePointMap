namespace GLMonitoringSystem.Devices.Meta.CTL_NJZJ
{
    public class BaseInfoField : Meta.BaseInfoField
    {
        /// <summary>
        /// byte数组，低位在前高位在后
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public override bool haveValue(params byte[] bytes)
        {
            if (0xff == bytes[0])
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
