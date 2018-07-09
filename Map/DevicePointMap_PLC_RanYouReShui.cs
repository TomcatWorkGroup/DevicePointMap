using GLMonitoringSystem.Devices.Meta;

namespace GLMonitoringSystem.Devices.Map
{
    class DevicePointMap_PLC_RanYouReShui : DevicePointMap
    {
        public const string Key = "PLC_RanYouReShui";
        public DevicePointMap_PLC_RanYouReShui()
        {
            map.Add("ba_yunxingxiaoshishu", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_yunxingxiaoshishu", 9, 2, "运行小时数","时"));
            map.Add("ba_yunxingtianshu", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_yunxingtianshu", 11, 2, "运行天数","天"));
            map.Add("ba_xitongzhuangtai", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_xitongzhuangtai", 13, 2, "系统状态", DevicePointMap_PLC_DaoReYou.coms_status));
            map.Add("ba_ranliao", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_ranliao", 15, 2, "燃料", DevicePointMap_PLC_DaoReYou.coms_power));
            map.Add("ba_jiezhimeijie", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_jiezhimeijie", 17, 2, "介质", DevicePointMap_PLC_DaoReYou.coms_media));
            map.Add("ba_shuiweizhuangtai", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_shuiweizhuangtai", 19, 2, "水位状态", DevicePointMap_PLC_DaoReYou.coms_level));
            map.Add("ba_ranshaoqizhuangtai", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_ranshaoqizhuangtai", 21, 2, "燃烧器状态", DevicePointMap_PLC_DaoReYou.coms_ranshaoqi_status));

            map.Add("mo_chushuiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_chushuiwendu", 35, 4, "出水温度", "℃"));
            map.Add("mo_huishuiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_huishuiwendu", 39, 4, "回水温度", "℃"));
            map.Add("mo_paiyanwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_paiyanwendu", 43, 4, "排烟温度", "℃"));
            map.Add("mo_chushuiyali", ByteField.Init(new Meta.PLC.MockField(), "mo_chushuiyali", 47, 4, "出水压力", "Mpa"));
            map.Add("mo_huishuiyali", ByteField.Init(new Meta.PLC.MockField(), "mo_huishuiyali", 51, 4, "回水压力", "Mpa"));
            map.Add("mo_yacha", ByteField.Init(new Meta.PLC.MockField(), "mo_yacha", 55, 4, "压差", "Mpa"));
            map.Add("mo_lengningqijinyanwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_lengningqijinyanwendu", 59, 4, "冷凝器进烟温度", "℃"));
            map.Add("mo_lengningqijinyanyali", ByteField.Init(new Meta.PLC.MockField(), "mo_lengningqijinyanyali", 63, 4, "冷凝器进烟压力", "Pa"));
            map.Add("mo_jienengqijinyanwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_jienengqijinyanwendu", 67, 4, "节能器进烟温度", "℃"));
            map.Add("mo_jienengqijinyanyali", ByteField.Init(new Meta.PLC.MockField(), "mo_jienengqijinyanyali", 71, 4, "节能器进烟压力", "Pa"));
            map.Add("mo_lutangwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_lutangwendu", 75, 4, "炉膛温度", "℃"));
            map.Add("mo_lutangyali", ByteField.Init(new Meta.PLC.MockField(), "mo_lutangyali", 79, 4, "炉膛压力", "Pa"));
            map.Add("mo_kongyuqijinyanwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_kongyuqijinyanwendu", 83, 4, "空预器进烟温度", "℃"));
            map.Add("mo_kongyuqijinyanyali", ByteField.Init(new Meta.PLC.MockField(), "mo_kongyuqijinyanyali", 87, 4, "空预器进烟压力", "Pa"));
            map.Add("mo_kongyuqijinfengwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_kongyuqijinfengwendu", 91, 4, "空预器进风温度", "℃"));
            map.Add("mo_kongyuqijinfengyali", ByteField.Init(new Meta.PLC.MockField(), "mo_kongyuqijinfengyali", 95, 4, "空预器进风压力", "Kpa"));
            map.Add("mo_kongyuqichufengwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_kongyuqichufengwendu", 99, 4, "空预器出风温度", "℃"));
            map.Add("mo_zhufengjipinlüfankui", ByteField.Init(new Meta.PLC.MockField(), "mo_zhufengjipinlüfankui", 103, 4, "主风机频率反馈", "Hz"));
            map.Add("mo_xunhuanfengjipinlüfankui", ByteField.Init(new Meta.PLC.MockField(), "mo_xunhuanfengjipinlüfankui", 107, 4, "循环风机频率反馈", "Hz"));
            map.Add("mo_bushuibengpinlüfankui", ByteField.Init(new Meta.PLC.MockField(), "mo_bushuibengpinlüfankui", 111, 4, "补水泵频率反馈", "Hz"));
            map.Add("mo_shiwaiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_shiwaiwendu", 115, 4, "室外温度", "℃"));
            map.Add("mo_xunhuanbeng1pinlüfankui", ByteField.Init(new Meta.PLC.MockField(), "mo_xunhuanbeng1pinlüfankui", 119, 4, "循环泵1频率反馈", "Hz"));
            map.Add("mo_xunhuanbeng2pinlüfankui", ByteField.Init(new Meta.PLC.MockField(), "mo_xunhuanbeng2pinlüfankui", 123, 4, "循环泵2频率反馈", "Hz"));

            map.Add("se_qiluwendusheding", ByteField.Init(new Meta.PLC.SettingField(), "se_qiluwendusheding", 248, 4, "启炉温度设定", "℃"));
            map.Add("se_mubiaowendusheding", ByteField.Init(new Meta.PLC.SettingField(), "se_mubiaowendusheding", 252, 4, "目标温度设定", "℃"));
            map.Add("se_tingluwendusheding", ByteField.Init(new Meta.PLC.SettingField(), "se_tingluwendusheding", 256, 4, "停炉温度设定", "℃"));
            map.Add("se_yalidisheding", ByteField.Init(new Meta.PLC.SettingField(), "se_yalidisheding", 260, 4, "压力低设定", "Mpa"));
            map.Add("se_yaligaosheding", ByteField.Init(new Meta.PLC.SettingField(), "se_yaligaosheding", 264, 4, "压力高设定", "Mpa"));
            map.Add("se_paiyanwenduchaogaobaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_paiyanwenduchaogaobaojingsheding", 268, 4, "排烟温度超高报警设定", "℃"));
            map.Add("se_chukouwenduchaogaobaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_chukouwenduchaogaobaojingsheding", 272, 4, "出口温度超高报警设定", "℃"));
            map.Add("se_yalichaogaobaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_yalichaogaobaojingsheding", 276, 4, "压力超高报警设定", "Mpa"));
            map.Add("se_yalichaodibaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_yalichaodibaojingsheding", 280, 4, "压力超低报警设定", "Mpa"));


            map.Add("de_ranshaojiqiting", ByteField.Init(new Meta.PLC.DeviceField(), "de_ranshaojiqiting", 368, 2, "燃烧机", DevicePointMap_PLC_DaoReYou.coms_atuo));
            map.Add("de_1#bushuibengshoudong/zidong", ByteField.Init(new Meta.PLC.DeviceField(), "de_1#bushuibengshoudong/zidong", 370, 2, "1#补水泵", DevicePointMap_PLC_DaoReYou.coms_atuo));
            map.Add("de_1#bushuibengqidong/tingzhi", ByteField.Init(new Meta.PLC.DeviceField(), "de_1#bushuibengqidong/tingzhi", 372, 2, "1#补水泵", DevicePointMap_PLC_DaoReYou.coms_start_stop));
            map.Add("de_2#bushuibengshoudong/zidong", ByteField.Init(new Meta.PLC.DeviceField(), "de_2#bushuibengshoudong/zidong", 374, 2, "2#补水泵", DevicePointMap_PLC_DaoReYou.coms_atuo));
            map.Add("de_2#bushuibengqidong/tingzhi", ByteField.Init(new Meta.PLC.DeviceField(), "de_2#bushuibengqidong/tingzhi", 376, 2, "2#补水泵", DevicePointMap_PLC_DaoReYou.coms_start_stop));
            map.Add("de_1#xunhuanbengshoudong/zidong", ByteField.Init(new Meta.PLC.DeviceField(), "de_1#xunhuanbengshoudong/zidong", 378, 2, "1#循环泵", DevicePointMap_PLC_DaoReYou.coms_atuo));
            map.Add("de_1#xunhuanbengqidong/tingzhi", ByteField.Init(new Meta.PLC.DeviceField(), "de_1#xunhuanbengqidong/tingzhi", 380, 2, "1#循环泵", DevicePointMap_PLC_DaoReYou.coms_start_stop));
            map.Add("de_2#xunhuanbengshoudong/zidong", ByteField.Init(new Meta.PLC.DeviceField(), "de_2#xunhuanbengshoudong/zidong", 382, 2, "2#循环泵", DevicePointMap_PLC_DaoReYou.coms_atuo));
            map.Add("de_2#xunhuanbengqidong/tingzhi", ByteField.Init(new Meta.PLC.DeviceField(), "de_2#xunhuanbengqidong/tingzhi", 384, 2, "2#循环泵", DevicePointMap_PLC_DaoReYou.coms_start_stop));



            map.Add("ex_ranshaojiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_ranshaojiguzhang", 448, 2, "燃烧机故障", 0));
            map.Add("ex_ranqixielou", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_ranqixielou", 448, 2, "燃气泄漏", 0));
            map.Add("ex_ranqiyaliyichang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_ranqiyaliyichang", 448, 2, "燃气压力异常", 0));
            map.Add("ex_yalichaogaobaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_yalichaogaobaojing", 448, 2, "压力超高报警", 0));
            map.Add("ex_yalichaodibaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_yalichaodibaojing", 448, 2, "压力超低报警", 0));
            map.Add("ex_paiyanwenduchaogaobaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_paiyanwenduchaogaobaojing", 448, 2, "排烟温度超高报警", 0));
            map.Add("ex_chushuiwenduchaogaobaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_chushuiwenduchaogaobaojing", 448, 2, "出水温度超高报警", 0));
            map.Add("ex_queshuibaohubaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_queshuibaohubaojing", 448, 2, "缺水保护报警", 0));
            map.Add("ex_lubichaowenbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_lubichaowenbaojing", 448, 2, "炉壁超温报警", 0));
            map.Add("ex_chushuiwenduchuanganqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_chushuiwenduchuanganqiguzhang", 448, 2, "出水温度传感器故障", 0));
            map.Add("ex_huishuiwenduchuanganqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_huishuiwenduchuanganqiguzhang", 448, 2, "回水温度传感器故障", 0));
            map.Add("ex_paiyanwenduchuanganqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_paiyanwenduchuanganqiguzhang", 448, 2, "排烟温度传感器故障", 0));
            map.Add("ex_wendushedingcuowubaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_wendushedingcuowubaojing", 448, 2, "温度设定错误报警", 0));
            map.Add("ex_xunhuanbengliansuoduankaibaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_xunhuanbengliansuoduankaibaojing", 448, 2, "循环泵连锁断开报警", 0));
            map.Add("ex_waibuliansuoduankaibaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_waibuliansuoduankaibaojing", 448, 2, "外部连锁断开报警", 0));
            map.Add("ex_chushuiyalibiansongqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_chushuiyalibiansongqiguzhang", 448, 2, "出水压力变送器故障", 0));
            map.Add("ex_huishuiyalibiansongqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_huishuiyalibiansongqiguzhang", 448, 2, "回水压力变送器故障", 0));


        }
    }
}
