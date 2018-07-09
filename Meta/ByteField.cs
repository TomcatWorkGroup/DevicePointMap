using System.Collections.Generic;
/**
 * Created by jialiang on 2018/4/19.
 */
namespace GLMonitoringSystem.Devices.Meta
{
    public abstract class ByteField
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Title { get; set; }
        public int StartIndex { get; set; }
        public int BytesLength { get; set; }
        public int BaseNumber { get; set; }
        public int Bit { get; set; }

        public Dictionary<int, string> ValueMap { get; set; }

        public abstract dynamic getValue();
        public virtual string getValueString()
        {
            return string.Format("{0}{1}",getValue(),Unit);
        }
        public abstract bool haveValue(params byte[] bytes);

        public abstract void setDeviceFieldForUIKey(DeviceFieldForUI fieldForUI);
        
        public DeviceFieldForUI getDeviceFieldForUI()
        {
            DeviceFieldForUI fieldForUI = new DeviceFieldForUI();
            setDeviceFieldForUIKey(fieldForUI);
            fieldForUI.Name = Name;
            fieldForUI.Title = Title;
            fieldForUI.Value = getValue();
            fieldForUI.ValueString = getValueString();
            //fieldForUI.Field = this;
            return fieldForUI;
        }

        public static ByteField Init(ByteField field, string name, int startIndex, int bytesLength, string title)
        {
            field.Name = name;
            field.StartIndex = startIndex;
            field.BytesLength = bytesLength;
            field.Title = title;
            return field;
        }

        public static ByteField Init(ByteField field, string name, int startIndex, int bytesLength, string title,Dictionary<int,string> valueMap)
        {
            Init(field, name, startIndex, bytesLength, title);
            field.ValueMap = valueMap;
            return field;
        }

        public static ByteField Init(ByteField field, string name, int startIndex, int bytesLength, string title, string unit)
        {
            Init(field, name, startIndex, bytesLength, title);
            field.Unit = unit;
            return field;
        }
        public static ByteField Init(ByteField field, string name, int startIndex, int bytesLength, string title, int bit)
        {
            Init(field, name, startIndex, bytesLength, title);
            field.Bit = bit;
            return field;
        }
        public static ByteField Init(ByteField field, string name, int startIndex, int bytesLength, string title, string unit, int baseNumber)
        {
            Init(field, name, startIndex, bytesLength, title, unit);
            field.BaseNumber = baseNumber;
            return field;
        }
    }
}