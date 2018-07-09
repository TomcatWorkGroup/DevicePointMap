using GLMonitoringSystem.Devices.Meta;
using System;
using System.Collections.Generic;

namespace GLMonitoringSystem.Devices
{
    [Serializable]
    public abstract class SdcSoftDevice
    {
        public const string KEY_BASE = "baseInfo";
        public const string KEY_EXCEPTION = "exceptionInfo";
        public const string KEY_MOCK = "mockInfo";
        public const string KEY_SETTING = "settingInfo";
        public const string KEY_START_STOP = "startStopInfo";
        public const string KEY_DEVICE = "deviceInfo";

        protected Dictionary<string, List<DeviceFieldForUI>> fieldMap = new Dictionary<string, List<DeviceFieldForUI>>();

        public SdcSoftDevice()
        {
            fieldMap.Add(KEY_BASE, new List<DeviceFieldForUI>());
            fieldMap.Add(KEY_EXCEPTION, new List<DeviceFieldForUI>());
            fieldMap.Add(KEY_MOCK, new List<DeviceFieldForUI>());
            fieldMap.Add(KEY_SETTING, new List<DeviceFieldForUI>());
            fieldMap.Add(KEY_DEVICE, new List<DeviceFieldForUI>());
            fieldMap.Add(KEY_START_STOP, new List<DeviceFieldForUI>());
        }

        /// <summary>
        /// 设备字节长度
        /// </summary>
        protected int BYTE_ARRAY_LENGTH = 1024;

        public string DeviceNo { get; set; }
        public string DeviceType { get; set; }

        public Dictionary<string, List<DeviceFieldForUI>> getFieldMap()
        {
            return fieldMap;
        }



        public virtual int getExceptionCount()
        {
            return fieldMap[KEY_EXCEPTION].Count;
        }

        public void AddField(DeviceFieldForUI field)
        {
            if (fieldMap.ContainsKey(field.Key))
                fieldMap[field.Key].Add(field);
        }

        public List<DeviceFieldForUI> getFieldsByGroupKey(string key)
        {
            if (fieldMap.ContainsKey(key))
                return fieldMap[key];
            return null;
        }


        public Dictionary<string, DeviceFieldForUI> getBaseInfoFileds()
        {
            Dictionary<string, DeviceFieldForUI> map = new Dictionary<string, DeviceFieldForUI>();

            List<DeviceFieldForUI> list = fieldMap[KEY_BASE];
            for (int i = 0; i < list.Count; i++)
            {
                DeviceFieldForUI deviceFieldForUI = list[i];
                map.Add(deviceFieldForUI.Name, deviceFieldForUI);
            }
            return map;
        }

        public Dictionary<string, DeviceFieldForUI> getDeviceFileds()
        {
            Dictionary<string, DeviceFieldForUI> map = new Dictionary<string, DeviceFieldForUI>();
            List<DeviceFieldForUI> list = fieldMap[KEY_DEVICE];
            for (int i = 0; i < list.Count; i++)
            {
                DeviceFieldForUI deviceFieldForUI = list[i];
                map.Add(deviceFieldForUI.Name, deviceFieldForUI);
            }
            return map;
        }


        public Dictionary<string, DeviceFieldForUI> getExceptionFileds()
        {
            Dictionary<string, DeviceFieldForUI> map = new Dictionary<string, DeviceFieldForUI>();
            List<DeviceFieldForUI> list = fieldMap[KEY_EXCEPTION];
            for (int i = 0; i < list.Count; i++)
            {
                DeviceFieldForUI deviceFieldForUI = list[i];
                map.Add(deviceFieldForUI.Name, deviceFieldForUI);
            }
            return map;
        }


        public Dictionary<string, DeviceFieldForUI> getMockFileds()
        {
            Dictionary<string, DeviceFieldForUI> map = new Dictionary<string, DeviceFieldForUI>();
            List<DeviceFieldForUI> list = fieldMap[KEY_MOCK];
            for (int i = 0; i < list.Count; i++)
            {
                DeviceFieldForUI deviceFieldForUI = list[i];
                map.Add(deviceFieldForUI.Name, deviceFieldForUI);
            }
            return map;
        }

        public Dictionary<string, DeviceFieldForUI> getSettingFileds()
        {
            Dictionary<string, DeviceFieldForUI> map = new Dictionary<string, DeviceFieldForUI>();
            List<DeviceFieldForUI> list = fieldMap[KEY_SETTING];
            for (int i = 0; i < list.Count; i++)
            {
                DeviceFieldForUI deviceFieldForUI = list[i];
                map.Add(deviceFieldForUI.Name, deviceFieldForUI);
            }
            return map;
        }


        public Dictionary<string, DeviceFieldForUI> getStartStopFields()
        {
            Dictionary<string, DeviceFieldForUI> map = new Dictionary<string, DeviceFieldForUI>();
            List<DeviceFieldForUI> list = fieldMap[KEY_START_STOP];
            for (int i = 0; i < list.Count; i++)
            {
                DeviceFieldForUI deviceFieldForUI = list[i];
                map.Add(deviceFieldForUI.Name, deviceFieldForUI);
            }
            return map;
        }
        public abstract void handleByteFileds(ByteField field, byte[] bytes);

        public abstract string handleDeviceNo(byte[] bytes);

        public bool validate(int bytesLength)
        {
            return BYTE_ARRAY_LENGTH == bytesLength;
        }
    }
}
