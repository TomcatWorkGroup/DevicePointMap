/**
 * Created by jialiang on 2018/4/20.
 */
namespace GLMonitoringSystem.Devices.Meta
{
    public class DeviceFieldForUI
    {
        /// <summary>
        /// 关联的数据点位
        /// </summary>
        public ByteField Field { get; set; }


        public dynamic Value { get; set; }
        public string Name { get; set; }
        public string ValueString { get; set; }
        public string Key { get; set; }
        public string Title { get; set; }
    }
}
