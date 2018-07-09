namespace GLMonitoringSystem.Devices.Meta.CTL_NJZJ
{
    public class ExceptionField : Meta.ExceptionField
    {
        public override bool haveValue(params byte[] bytes)
        {
            value = bytes[0];
            return value > 0 && value < 0xFF;
        }
    }
}
