/**
* Created by jialiang on 2018/4/20.
*/
namespace GLMonitoringSystem.Devices.Meta
{
    /// <summary>
    /// ��ʱ�������ã�����ʶϵͳ��Ӧ�����ò�����
    /// Ŀǰ���ò����Ľ���������ģ������ͬ�����������ԣ���˸���Ӧ�ñ����Ա�������չ
    /// ���������ò�����ģ������ͬ���豸ʱ�����ཫ���뵽�̳�ϵͳ��
    /// </summary>
    public abstract class SettingField : MockField
    {

        public override void setDeviceFieldForUIKey(DeviceFieldForUI fieldForUI)
        {
            fieldForUI.Key = SdcSoftDevice.KEY_SETTING;
        }
    }
}
