/**
 * Created by jialiang on 2018/4/19.
 */
namespace GLMonitoringSystem.Devices.Meta.NJZJ
{
    public class ExceptionField : Base.ExceptionField {

    public override bool haveValue(byte hByte, byte lByte) {
            value = (int)lByte;
            return lByte > 0 && lByte < 0xFF;
        }
    }
}
