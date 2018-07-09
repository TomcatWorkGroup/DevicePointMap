/**
 * Created by jialiang on 2018/4/19.
 */
namespace GLMonitoringSystem.Devices.Meta.NJZJ
{
    public class RunDaysField : Base.RunDaysField {

    public override bool haveValue(byte hByte, byte lByte) {
            days = lByte | (hByte << 8) ;
            return true;
        }

    }
}