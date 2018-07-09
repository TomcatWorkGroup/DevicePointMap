/**
 * Created by jialiang on 2018/4/20.
 */
namespace GLMonitoringSystem.Devices.Meta.NJZJ
{
    public class DeviceField : Base.DeviceField
    {
        public override bool haveValue(byte hByte, byte lByte)
        {
            int i = lByte | (hByte << 8);

            if (0x7FFF == i)
                return false;

            if (Name.Equals("de_ranshaoqi"))
            {
                value = lByte & 0xFF;
                status = value;
                switch (value)
                {
                    case 0:
                        sb.Append("停");
                        break;
                    case 1:
                        sb.Append("小火");
                        break;
                    case 2:
                        sb.Append("大火");
                        break;
                }
                return true;
            }

            if (0xC0 == (hByte & 0xC0))
                sb.Append("手/");
            else
                sb.Append("自/");
            if (0x30 == (hByte & 0x30))
            {
                sb.Append("备/");
                deviceName = "备";
            }
            else
            {
                sb.Append("主/");
                deviceName = "主";
            }
            if (0x0F == (hByte & 0x0F))
            {
                sb.Append("启");
                status = 1;
            }
            else
            {
                sb.Append("停");
                status = 0;
            }
            value = lByte;

            return true;
        }
    }
}