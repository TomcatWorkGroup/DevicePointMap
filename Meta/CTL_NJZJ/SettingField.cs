using GLMonitoringSystem.Devices;

namespace GLMonitoringSystem.Devices.Meta.CTL_NJZJ
{
    public class SettingField : MockField
    {
       
    public override void setDeviceFieldForUIKey(DeviceFieldForUI fieldForUI)
    {
        fieldForUI.Key = SdcSoftDevice.KEY_SETTING;
    }
}

}
