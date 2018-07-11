using System.Text;

namespace GLMonitoringSystem.Devices.Meta.CTL_NJZJ
{
    public class DeviceField : Meta.DeviceField
    {
        protected StringBuilder sb = new StringBuilder();

        /// <summary>
        /// byte数组 低位在前高位在后
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public override bool haveValue(params byte[] bytes)
        {
            int i = bytes[0]  | (bytes[1] << 8) ;

            if (0x7FFF == i)
                return false;

            sb.Clear();
            if(null != ValueMap)
            {
                var v = (bytes[1] | 0x3F);
                if(0xC0 == (v & 0xC0))
                {
                    sb.Append(ValueMap[0xC0]);
                    sb.Append('/');
                }
                else
                {
                    sb.Append(ValueMap[0x3F]);
                    sb.Append('/');
                }
                v = (bytes[1] | 0xCF);
                if (0x30 == (v & 0x30))
                {
                    sb.Append(ValueMap[0x30]);
                    sb.Append('/');
                }
                else
                {
                    sb.Append(ValueMap[0xCF]);
                    sb.Append('/');
                }
                v = (bytes[1] | 0xF0);
                if (0x0F == (v & 0x0F))
                {
                    sb.Append(ValueMap[0x0F]);
                }
                else
                {
                    sb.Append(ValueMap[0xF0]);
                }
            }

            value = bytes[0];
            return true;
        }

        public override string getValueString()
        {
            return sb.ToString();
        }
    }
}
