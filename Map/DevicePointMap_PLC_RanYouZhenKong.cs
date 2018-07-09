using GLMonitoringSystem.Devices.Meta;

namespace GLMonitoringSystem.Devices.Map
{
    class DevicePointMap_PLC_RanYouZhenKong : DevicePointMap
    {
        public const string Key = "PLC_RanYouZhenKong";
        public DevicePointMap_PLC_RanYouZhenKong()
        {
            map.Add("ba_yunxingxiaoshishu", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_yunxingxiaoshishu", 9, 2, "运行小时数","时"));
            map.Add("ba_yunxingtianshu", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_yunxingtianshu", 11, 2, "运行天数","天"));
            map.Add("ba_xitongzhuangtai", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_xitongzhuangtai", 13, 2, "系统状态", DevicePointMap_PLC_DaoReYou.coms_status));
            map.Add("ba_ranliao", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_ranliao", 15, 2, "燃料", DevicePointMap_PLC_DaoReYou.coms_power));
            map.Add("ba_jiezhimeijie", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_jiezhimeijie", 17, 2, "介质", DevicePointMap_PLC_DaoReYou.coms_media));
            map.Add("ba_shuiweizhuangtai", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_shuiweizhuangtai", 19, 2, "水位状态", DevicePointMap_PLC_DaoReYou.coms_level));
            map.Add("ba_ranshaoqizhuangtai", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_ranshaoqizhuangtai", 21, 2, "燃烧器状态", DevicePointMap_PLC_DaoReYou.coms_ranshaoqi_status));

            map.Add("mo_remeishuiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_remeishuiwendu", 35, 4, "热媒水温度", "℃"));
            map.Add("mo_zhenkongyali", ByteField.Init(new Meta.PLC.MockField(), "mo_zhenkongyali", 39, 4, "真空压力", "Kpa"));
            map.Add("mo_jinyanwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_jinyanwendu", 43, 4, "进烟温度", "℃"));
            map.Add("mo_paiyanwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_paiyanwendu", 47, 4, "排烟温度", "℃"));
            map.Add("mo_shiwaiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_shiwaiwendu", 51, 4, "室外温度", "℃"));
            map.Add("mo_cainuanchushuiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_cainuanchushuiwendu", 55, 4, "采暖出水温度", "℃"));
            map.Add("mo_cainuanhuishuiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_cainuanhuishuiwendu", 59, 4, "采暖回水温度", "℃"));
            map.Add("mo_cainuanchushuiyali", ByteField.Init(new Meta.PLC.MockField(), "mo_cainuanchushuiyali", 63, 4, "采暖出水压力", "Mpa"));
            map.Add("mo_cainuanhuishuiyali", ByteField.Init(new Meta.PLC.MockField(), "mo_cainuanhuishuiyali", 67, 4, "采暖回水压力", "Mpa"));
            map.Add("mo_shenghuochushuiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_shenghuochushuiwendu", 71, 4, "生活出水温度", "℃"));
            map.Add("mo_shenghuohuishuiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_shenghuohuishuiwendu", 75, 4, "生活回水温度", "℃"));
            map.Add("mo_shenghuochushuiyali", ByteField.Init(new Meta.PLC.MockField(), "mo_shenghuochushuiyali", 79, 4, "生活出水压力", "Mpa"));
            map.Add("mo_shenghuohuishuiyali", ByteField.Init(new Meta.PLC.MockField(), "mo_shenghuohuishuiyali", 83, 4, "生活回水压力", "Mpa"));

            map.Add("se_qiluwendusheding", ByteField.Init(new Meta.PLC.SettingField(), "se_qiluwendusheding", 248, 4, "启炉温度设定", "℃"));
            map.Add("se_mubiaowendusheding", ByteField.Init(new Meta.PLC.SettingField(), "se_mubiaowendusheding", 252, 4, "目标温度设定", "℃"));
            map.Add("se_tingluwendusheding", ByteField.Init(new Meta.PLC.SettingField(), "se_tingluwendusheding", 256, 4, "停炉温度设定", "℃"));
            map.Add("se_zhenkongyalidisheding", ByteField.Init(new Meta.PLC.SettingField(), "se_zhenkongyalidisheding", 260, 4, "真空压力低设定", "KPa"));
            map.Add("se_zhenkongyaligaosheding", ByteField.Init(new Meta.PLC.SettingField(), "se_zhenkongyaligaosheding", 264, 4, "真空压力高设定", "KPa"));
            map.Add("se_paiyanwenduchaogaobaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_paiyanwenduchaogaobaojingsheding", 268, 4, "排烟温度超高报警设定", "℃"));
            map.Add("se_chukouwenduchaogaobaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_chukouwenduchaogaobaojingsheding", 272, 4, "出口温度超高报警设定", "℃"));
            map.Add("se_zhenkongyalichaogaobaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_zhenkongyalichaogaobaojingsheding", 276, 4, "真空压力超高报警设定", "KPa"));

            map.Add("de_ranshaojiqiting", ByteField.Init(new Meta.PLC.DeviceField(), "de_ranshaojiqiting", 368, 2, "燃烧机", DevicePointMap_PLC_DaoReYou.coms_atuo));
            map.Add("de_1#xunhuanbengshoudongzidong", ByteField.Init(new Meta.PLC.DeviceField(), "de_1#xunhuanbengshoudongzidong", 370, 2, "1#循环泵",DevicePointMap_PLC_DaoReYou.coms_atuo));
            map.Add("de_1#xunhuanbengqidongtingzhi", ByteField.Init(new Meta.PLC.DeviceField(), "de_1#xunhuanbengqidongtingzhi", 372, 2, "1#循环泵", DevicePointMap_PLC_DaoReYou.coms_start_stop));
            map.Add("de_2#xunhuanbengshoudongzidong", ByteField.Init(new Meta.PLC.DeviceField(), "de_2#xunhuanbengshoudongzidong", 374, 2, "2#循环泵",DevicePointMap_PLC_DaoReYou.coms_atuo));
            map.Add("de_2#xunhuanbengqidongtingzhi", ByteField.Init(new Meta.PLC.DeviceField(), "de_2#xunhuanbengqidongtingzhi", 376, 2, "2#循环泵", DevicePointMap_PLC_DaoReYou.coms_start_stop));
            map.Add("de_1#bushuibengshoudongzidong", ByteField.Init(new Meta.PLC.DeviceField(), "de_1#bushuibengshoudongzidong", 378, 2, "1#补水泵",DevicePointMap_PLC_DaoReYou.coms_atuo));
            map.Add("de_1#bushuibengqidongtingzhi", ByteField.Init(new Meta.PLC.DeviceField(), "de_1#bushuibengqidongtingzhi", 380, 2, "1#补水泵", DevicePointMap_PLC_DaoReYou.coms_start_stop));
            map.Add("de_2#bushuibengshoudongzidong", ByteField.Init(new Meta.PLC.DeviceField(), "de_2#bushuibengshoudongzidong", 382, 2, "2#补水泵",DevicePointMap_PLC_DaoReYou.coms_atuo));
            map.Add("de_2#bushuibengqidongtingzhi", ByteField.Init(new Meta.PLC.DeviceField(), "de_2#bushuibengqidongtingzhi", 384, 2, "2#补水泵", DevicePointMap_PLC_DaoReYou.coms_start_stop));
            map.Add("de_zhenkongbengshoudongzidong", ByteField.Init(new Meta.PLC.DeviceField(), "de_zhenkongbengshoudongzidong", 386, 2, "真空泵",DevicePointMap_PLC_DaoReYou.coms_atuo));
            map.Add("de_zhenkongbengqidongtingzhi", ByteField.Init(new Meta.PLC.DeviceField(), "de_zhenkongbengqidongtingzhi", 388, 2, "真空泵", DevicePointMap_PLC_DaoReYou.coms_start_stop));

            map.Add("ex_ranshaojiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_ranshaojiguzhang", 419, 2, "燃烧机故障", 0));
            map.Add("ex_ranqixielou", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_ranqixielou", 419, 2, "燃气泄漏", 1));
            map.Add("ex_ranqiyaliyichang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_ranqiyaliyichang", 419, 2, "燃气压力异常", 2));
            map.Add("ex_luneiyaligaobaojingshedingzhi", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_luneiyaligaobaojingshedingzhi", 419, 2, "炉内压力高报警（设定值）", 3));
            map.Add("ex_luneiyaligaobaojingyalikaiguan", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_luneiyaligaobaojingyalikaiguan", 419, 2, "炉内压力高报警（压力开关）", 4));
            map.Add("ex_paiyanwenduchaogaobaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_paiyanwenduchaogaobaojing", 419, 2, "排烟温度超高报警", 5));
            map.Add("ex_remeishuiwenduchaogaobaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_remeishuiwenduchaogaobaojing", 419, 2, "热媒水温度超高报警", 6));
            map.Add("ex_queshuibaohubaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_queshuibaohubaojing", 419, 2, "缺水保护报警", 7));
            map.Add("ex_lubichaowenbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_lubichaowenbaojing", 419, 2, "炉壁超温报警", 8));
            map.Add("ex_remeishuiwenduchuanganqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_remeishuiwenduchuanganqiguzhang", 419, 2, "热媒水温度传感器故障", 9));
            map.Add("ex_paiyanwenduchuanganqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_paiyanwenduchuanganqiguzhang", 419, 2, "排烟温度传感器故障", 10));
            map.Add("ex_cainuanchushuiwenduchuanganqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_cainuanchushuiwenduchuanganqiguzhang", 419, 2, "采暖出水温度传感器故障", 11));
            map.Add("ex_shenghuochushuiwenduchuanganqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_shenghuochushuiwenduchuanganqiguzhang", 419, 2, "生活出水温度传感器故障", 12));
            map.Add("ex_wendushedingcuowubaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_wendushedingcuowubaojing", 419, 2, "温度设定错误报警", 13));
            map.Add("ex_xunhuanbengliansuoduankaibaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_xunhuanbengliansuoduankaibaojing", 419, 2, "循环泵连锁断开报警", 14));
            map.Add("ex_waibuliansuoduankaibaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_waibuliansuoduankaibaojing", 419, 2, "外部连锁断开报警", 15));


        }
    }
}
