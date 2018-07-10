using System;
namespace GLMonitoringSystem.Devices.Meta.CTL_NJZJ
{
    public class MockField : Meta.MockField
    {
        public override bool haveValue(params byte[] bytes)
        {
            value = BitConverter.ToInt16(bytes, 0);
            if (0x7FFF == value)
                return false;

            if (BaseNumber > 0)
                value = value / BaseNumber;
            return true;
        }
    }
}
