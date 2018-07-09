/**
 * Created by jialiang on 2018/4/19.
 */
namespace GLMonitoringSystem.Devices.Meta.NJZJ
{
    public class BaseInfoField : Meta.BaseInfoField
    {
        public override bool haveValue(byte hByte, byte lByte)
        {
            value = (int)lByte;
            var flag = value != 0xFF;
            return flag;
        }
    }
}
