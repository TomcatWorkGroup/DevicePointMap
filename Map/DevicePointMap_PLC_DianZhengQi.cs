using GLMonitoringSystem.Devices.Meta;
using System;
using System.Collections.Generic;

namespace GLMonitoringSystem.Devices.Map
{
    internal class DevicePointMap_PLC_DianZhengQi : DevicePointMap
    {
        public const string Key = "PLC_DianZhengQi";
        public DevicePointMap_PLC_DianZhengQi()
        {
            map.Add("ba_yunxingxiaoshishu", ByteField.Init(new Meta.PLC. BaseInfoField(), "ba_yunxingxiaoshishu", 9, 2, "运行小时数","时"));
            map.Add("ba_yunxingtianshu", ByteField.Init(new Meta.PLC. BaseInfoField(), "ba_yunxingtianshu", 11, 2, "运行天数","天"));
            map.Add("ba_xitongzhuangtai", ByteField.Init(new Meta.PLC. BaseInfoField(), "ba_xitongzhuangtai", 13, 2, "系统状态",DevicePointMap_PLC_DaoReYou.coms_status));
            map.Add("ba_ranliao", ByteField.Init(new Meta.PLC. BaseInfoField(), "ba_ranliao", 15, 2, "燃料", DevicePointMap_PLC_DaoReYou.coms_power));
            map.Add("ba_jiezhimeijie", ByteField.Init(new Meta.PLC. BaseInfoField(), "ba_jiezhimeijie", 17, 2, "介质", DevicePointMap_PLC_DaoReYou.coms_media));
            map.Add("ba_shuiweizhuangtai", ByteField.Init(new Meta.PLC. BaseInfoField(), "ba_shuiweizhuangtai", 19, 2, "水位状态", DevicePointMap_PLC_DaoReYou.coms_level));
            map.Add("ba_ranshaoqizhuangtai", ByteField.Init(new Meta.PLC. BaseInfoField(), "ba_ranshaoqizhuangtai", 21, 2, "燃烧器状态", DevicePointMap_PLC_DaoReYou.coms_ranshaoqi_status));

            map.Add("mo_zhengqiyali", ByteField.Init(new Meta.PLC. MockField(), "mo_zhengqiyali", 35, 4, "蒸汽压力", "MPa"));
            map.Add("mo_zhengqiwendu", ByteField.Init(new Meta.PLC. MockField(), "mo_zhengqiwendu", 39, 4, "蒸汽温度", "℃"));
            map.Add("mo_guolushuiwei", ByteField.Init(new Meta.PLC. MockField(), "mo_guolushuiwei", 43, 4, "锅炉水位", "mm"));
            map.Add("mo_zhengqishunshiliuliang", ByteField.Init(new Meta.PLC. MockField(), "mo_zhengqishunshiliuliang", 47, 4, "蒸汽瞬时流量", "T/H"));
            map.Add("mo_bushuishunshiliuliang", ByteField.Init(new Meta.PLC. MockField(), "mo_bushuishunshiliuliang", 51, 4, "补水瞬时流量", "T/H"));
            map.Add("mo_zhengqileijiliuliang", ByteField.Init(new Meta.PLC. MockField(), "mo_zhengqileijiliuliang", 55, 4, "蒸汽累计流量", "T"));
            map.Add("mo_bushuileijiliuliang", ByteField.Init(new Meta.PLC. MockField(), "mo_bushuileijiliuliang", 59, 4, "补水累计流量", "T"));
            map.Add("mo_jinshuiwendu", ByteField.Init(new Meta.PLC. MockField(), "mo_jinshuiwendu", 63, 4, "进水温度", "℃"));
            map.Add("mo_jinshuiyali", ByteField.Init(new Meta.PLC. MockField(), "mo_jinshuiyali", 67, 4, "进水压力", "MPa"));
            map.Add("mo_bushuibengpinlvfankui", ByteField.Init(new Meta.PLC. MockField(), "mo_bushuibengpinlvfankui", 71, 4, "补水泵频率反馈", "Hz"));
            map.Add("mo_ruanshuixiangyewei", ByteField.Init(new Meta.PLC. MockField(), "mo_ruanshuixiangyewei", 75, 4, "软水箱液位", "%"));
            map.Add("mo_qidongjiarezushu", ByteField.Init(new Meta.PLC. MockField(), "mo_qidongjiarezushu", 79, 4, "启动加热组数", "组"));
            map.Add("mo_qidongjiarezushubaifenbi", ByteField.Init(new Meta.PLC. MockField(), "mo_qidongjiarezushubaifenbi", 83, 4, "启动加热组数百分比", "%"));

            map.Add("se_chaoyabaojingsheding", ByteField.Init(new Meta.PLC. SettingField(), "se_chaoyabaojingsheding", 127, 4, "超压报警设定", "MPa"));
            map.Add("se_shiyongjiarezushusheding", ByteField.Init(new Meta.PLC. SettingField(), "se_shiyongjiarezushusheding", 131, 4, "使用加热组数设定", "组"));
            map.Add("se_touqiejiangeshijiansheding", ByteField.Init(new Meta.PLC. SettingField(), "se_touqiejiangeshijiansheding", 135, 4, "投切间隔时间设定", "S"));
            map.Add("se_kuaiqiejiangeshijiansheding", ByteField.Init(new Meta.PLC. SettingField(), "se_kuaiqiejiangeshijiansheding", 139, 4, "快切间隔时间设定", "S"));
            map.Add("se_tingluyalisheding", ByteField.Init(new Meta.PLC. SettingField(), "se_tingluyalisheding", 143, 4, "停炉压力设定", "MPa"));
            map.Add("se_shiyongyalisheding", ByteField.Init(new Meta.PLC. SettingField(), "se_shiyongyalisheding", 147, 4, "使用压力设定", "MPa"));
            map.Add("se_qiluyalisheding", ByteField.Init(new Meta.PLC. SettingField(), "se_qiluyalisheding", 151, 4, "启炉压力设定", "MPa"));
            map.Add("se_guolushuiweijidibaojingsheding", ByteField.Init(new Meta.PLC. SettingField(), "se_guolushuiweijidibaojingsheding", 155, 4, "锅炉水位极低报警设定", "mm"));
            map.Add("se_geishuibengshoudongpinlvsheding", ByteField.Init(new Meta.PLC. SettingField(), "se_geishuibengshoudongpinlvsheding", 159, 4, "给水泵手动频率设定", "Hz"));
            map.Add("se_bushuimubiaosheding", ByteField.Init(new Meta.PLC. SettingField(), "se_bushuimubiaosheding", 163, 4, "补水目标设定", "mm"));
            map.Add("se_guolushuiweijigaobaojingsheding", ByteField.Init(new Meta.PLC. SettingField(), "se_guolushuiweijigaobaojingsheding", 167, 4, "锅炉水位极高报警设定", "mm"));
            map.Add("se_qibengyeweisheding", ByteField.Init(new Meta.PLC. SettingField(), "se_qibengyeweisheding", 171, 4, "启泵液位设定", "mm"));
            map.Add("se_tingbengyeweisheding", ByteField.Init(new Meta.PLC. SettingField(), "se_tingbengyeweisheding", 175, 4, "停泵液位设定", "mm"));


            map.Add("de_1#bushuibengshoudongzidong", ByteField.Init(new Meta.PLC. DeviceField(), "de_1#bushuibengshoudongzidong", 199, 2, "1#补水泵", DevicePointMap_PLC_DaoReYou.coms_atuo));
            map.Add("de_1#bushuibengqidongtingzhi", ByteField.Init(new Meta.PLC.DeviceField(), "de_1#bushuibengqidongtingzhi", 201, 2, "1#补水泵", DevicePointMap_PLC_DaoReYou.coms_start_stop));
            map.Add("de_2#bushuibengshoudongzidong", ByteField.Init(new Meta.PLC.DeviceField(), "de_2#bushuibengshoudongzidong", 203, 2, "2#补水泵", DevicePointMap_PLC_DaoReYou.coms_atuo));
            map.Add("de_2#bushuibengqidongtingzhi", ByteField.Init(new Meta.PLC.DeviceField(), "de_2#bushuibengqidongtingzhi", 205, 2, "2#补水泵", DevicePointMap_PLC_DaoReYou.coms_start_stop));
            map.Add("de_baojingshuchuzhishi", ByteField.Init(new Meta.PLC.DeviceField(), "de_baojingshuchuzhishi", 207, 2, "报警输出指示", new Dictionary<int, string> { { 0,"关"},{ 1,"开"} }));


            map.Add("ex_shuiweiweidibaojing（dianji）", ByteField.Init(new Meta.PLC. ExceptionField(), "ex_shuiweiweidibaojing（dianji）", 233, 2, "水位危低报警（电极）", 0));
            map.Add("ex_shuiweijidibaojing（dianji）", ByteField.Init(new Meta.PLC. ExceptionField(), "ex_shuiweijidibaojing（dianji）", 233, 2, "水位极低报警（电极）", 1));
            map.Add("ex_shuiweijigaobaojing（dianji）", ByteField.Init(new Meta.PLC. ExceptionField(), "ex_shuiweijigaobaojing（dianji）", 233, 2, "水位极高报警（电极）", 2));
            map.Add("ex_shuiweijidibaojing（shedingzhi）", ByteField.Init(new Meta.PLC. ExceptionField(), "ex_shuiweijidibaojing（shedingzhi）", 233, 2, "水位极低报警（设定值）", 3));
            map.Add("ex_shuiweijigaobaojing（shedingzhi）", ByteField.Init(new Meta.PLC. ExceptionField(), "ex_shuiweijigaobaojing（shedingzhi）", 233, 2, "水位极高报警（设定值）", 4));
            map.Add("ex_chaoyabaojing（yalikaiguan）", ByteField.Init(new Meta.PLC. ExceptionField(), "ex_chaoyabaojing（yalikaiguan）", 233, 2, "超压报警（压力开关）", 5));
            map.Add("ex_chaoyabaojing（shedingzhi）", ByteField.Init(new Meta.PLC. ExceptionField(), "ex_chaoyabaojing（shedingzhi）", 233, 2, "超压报警（设定值）", 6));
            map.Add("ex_ruanshuixiangqueshuibaojing", ByteField.Init(new Meta.PLC. ExceptionField(), "ex_ruanshuixiangqueshuibaojing", 233, 2, "软水箱缺水报警", 7));
            map.Add("ex_shuidianjiluojicuobaojing", ByteField.Init(new Meta.PLC. ExceptionField(), "ex_shuidianjiluojicuobaojing", 233, 2, "水电极逻辑错报警", 8));
            map.Add("ex_yalibiansongqiguzhangbaojing", ByteField.Init(new Meta.PLC. ExceptionField(), "ex_yalibiansongqiguzhangbaojing", 233, 2, "压力变送器故障报警", 9));
            map.Add("ex_shuiweibiansongqiguzhangbaojing", ByteField.Init(new Meta.PLC. ExceptionField(), "ex_shuiweibiansongqiguzhangbaojing", 233, 2, "水位变送器故障报警", 10));
            map.Add("ex_geishuibengbianpinqiguzhang", ByteField.Init(new Meta.PLC. ExceptionField(), "ex_geishuibengbianpinqiguzhang", 233, 2, "给水泵变频器故障", 11));
            map.Add("ex_loudianbaojing", ByteField.Init(new Meta.PLC. ExceptionField(), "ex_loudianbaojing", 233, 2, "漏电报警", 12));
            map.Add("ex_qianyabaojing", ByteField.Init(new Meta.PLC. ExceptionField(), "ex_qianyabaojing", 233, 2, "欠压报警", 13));

        }
    }
}
