namespace GLMonitoringSystem.Devices.Meta.CTL_NJZJ
{
    public class RunDaysField : BaseInfoField
    {
        public override bool haveValue(params byte[] bytes)
        {
            value = bytes[0] | (bytes[1] << 8);
            return true;
        }
    }
}
