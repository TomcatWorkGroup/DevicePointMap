using GLMonitoringSystem.Devices.Meta;
using System.Collections.Generic;

namespace GLMonitoringSystem.Devices.Map
{
    /**
     * Created by jialiang on 2018/4/20.
     */
    class DevicePointMap_CTL_NJZJ_IPK2 : DevicePointMap
    {
        public const string Key = "CTL_NJZJ_IPK2";
        Dictionary<int, string> coms_open_close = new Dictionary<int, string> { { 0, "关" }, { 1, "开"} };
        Dictionary<int, string> coms_level = new Dictionary<int, string> { { 0, "缺水" }, { 1, "低报警" }, { 2, "低位" }, { 3, "正常" }, { 4, "高位" }, { 5, "超高位" }, { 6, "逻辑错" } };
        Dictionary<int, string> coms_device = new Dictionary<int, string> { { 0xC0, "手" }, { 0x3F, "自" }, { 0x30, "备" }, { 0xCF, "主" }, { 0x0F, "启" }, { 0xF0, "停" } };
        public DevicePointMap_CTL_NJZJ_IPK2()
        {
            map.Add("ba_yunxingzhuangtai", ByteField.Init(new Meta.CTL_NJZJ.BaseInfoField(), "ba_yunxingzhuangtai", 20, 1, "运行状态", new Dictionary<int, string> { { 0, "关机" }, { 1, "待机" }, { 2, "运行" }, { 3, "报警" } }));

            map.Add("ba_yunxingtianshu", ByteField.Init(new Meta.CTL_NJZJ.RunDaysField(), "ba_yunxingtianshu", 21, 2, "运行天数", "天"));

            map.Add("ba_yunxingxiaoshishu", ByteField.Init(new Meta.CTL_NJZJ.BaseInfoField(), "ba_yunxingxiaoshishu", 23, 1, "运行小时数", "时"));

            map.Add("ba_ranliaoleixing", ByteField.Init(new Meta.CTL_NJZJ.BaseInfoField(), "ba_ranliaoleixing", 24, 1, "燃料类型", new Dictionary<int, string> { { 0, "油气" }, { 1, "电" }, { 2, "煤" }, { 3, "生物质" } }));

            map.Add("ba_jiezhileixing", ByteField.Init(new Meta.CTL_NJZJ.BaseInfoField(), "ba_jiezhileixing", 25, 1, "介质类型", new Dictionary<int, string> { { 0, "热水" }, { 1, "蒸汽" }, { 2, "导热油" }, { 3, "热风" }, { 4, "真空" } }));

            map.Add("ba_guolushuiweizhuangtai", ByteField.Init(new Meta.CTL_NJZJ.BaseInfoField(), "ba_guolushuiweizhuangtai", 26, 1, "锅炉水位状态", coms_level));

            map.Add("ba_shuixiangshuiweizhuangtai", ByteField.Init(new Meta.CTL_NJZJ.BaseInfoField(), "ba_shuixiangshuiweizhuangtai", 27, 1, "水箱水位状态", coms_level));

            map.Add("ba_guoluyalizhuangtai", ByteField.Init(new Meta.CTL_NJZJ.BaseInfoField(), "ba_guoluyalizhuangtai", 28, 1, "锅炉压力状态", new Dictionary<int, string> { { 0, "常压" }, { 1, "低压" }, { 2, "中压" }, { 3, "高压" }, { 4, "超压" } }));

            map.Add("ba_moshibianhao", ByteField.Init(new Meta.CTL_NJZJ.BaseInfoField(), "ba_moshibianhao", 29, 1, "模式编号"));

            map.Add("ba_fangdongkaiguan", ByteField.Init(new Meta.CTL_NJZJ.BaseInfoField(), "ba_fangdongkaiguan", 30, 1, "防冻开关", coms_open_close));

            map.Add("ex_paiyanwendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_paiyanwendugaobaojing", 32, 1, "排烟温度高报警"));

            map.Add("ex_lushuiwendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_lushuiwendugaobaojing", 33, 1, "炉水温度高报警"));

            map.Add("ex_chukouwendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_chukouwendugaobaojing", 34, 1, "出口温度高报警"));

            map.Add("ex_chaoyabaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_chaoyabaojing", 35, 1, "超压报警"));

            map.Add("ex_jixiandishuiweibaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_jixiandishuiweibaojing", 36, 1, "极限低水位报警"));

            map.Add("ex_dishuiweibaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_dishuiweibaojing", 37, 1, "低水位报警"));

            map.Add("ex_gaoshuiweibaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_gaoshuiweibaojing", 38, 1, "高水位报警"));

            map.Add("ex_shuiweixinhaoluojicuobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_shuiweixinhaoluojicuobaojing", 39, 1, "水位信号逻辑错报警"));

            map.Add("ex_lubiwendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_lubiwendugaobaojing", 40, 1, "炉壁温度高报警"));

            map.Add("ex_fuyazhengqiwendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_fuyazhengqiwendugaobaojing", 41, 1, "负压蒸汽温度高报警"));

            map.Add("ex_ranshaoqiguzhangbaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_ranshaoqiguzhangbaojing", 42, 1, "燃烧器故障报警"));

            map.Add("ex_ranqixieloubaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_ranqixieloubaojing", 43, 1, "燃气泄漏报警"));

            map.Add("ex_ranqiyalidibaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_ranqiyalidibaojing", 44, 1, "燃气压力低报警"));

            map.Add("ex_ranqiyaliyichangbaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_ranqiyaliyichangbaojing", 45, 1, "燃气压力异常报警"));

            map.Add("ex_ranqiyaligaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_ranqiyaligaobaojing", 46, 1, "燃气压力高报警"));

            map.Add("ex_jishuibianpinqiguzhangbaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_jishuibianpinqiguzhangbaojing", 47, 1, "给水变频器故障报警"));

            map.Add("ex_xunhuanbianpinqiguzhangbaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_xunhuanbianpinqiguzhangbaojing", 48, 1, "循环变频器故障报警"));

            map.Add("ex_yinfengbianpinqiguzhangbaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_yinfengbianpinqiguzhangbaojing", 49, 1, "引风变频器故障报警"));

            map.Add("ex_gufengbianpinqiguzhangbaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_gufengbianpinqiguzhangbaojing", 50, 1, "鼓风变频器故障报警"));

            map.Add("ex_ecigufengbianpinqiguzhangbaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_ecigufengbianpinqiguzhangbaojing", 51, 1, "二次鼓风变频器故障报警"));

            map.Add("ex_lupaibianpinqiguzhangbaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_lupaibianpinqiguzhangbaojing", 52, 1, "炉排变频器故障报警"));

            map.Add("ex_jishuibengguzhangbaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_jishuibengguzhangbaojing", 53, 1, "给水泵故障报警"));

            map.Add("ex_xunhuanbengguzhangbaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_xunhuanbengguzhangbaojing", 54, 1, "循环泵故障报警"));

            map.Add("ex_qianyabaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_qianyabaojing", 55, 1, "欠压报警"));

            map.Add("ex_didianyabaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_didianyabaojing", 56, 1, "低电压报警"));

            map.Add("ex_gaodianyabaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_gaodianyabaojing", 57, 1, "高电压报警"));

            map.Add("ex_quexiangbaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_quexiangbaojing", 58, 1, "缺相报警"));

            map.Add("ex_loudianbaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_loudianbaojing", 59, 1, "漏电报警"));

            map.Add("ex_biansongqiguoyabaohu", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_biansongqiguoyabaohu", 60, 1, "变送器过压保护"));

            map.Add("ex_guanjiancanshuyichang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_guanjiancanshuyichang", 61, 1, "关键参数异常"));

            map.Add("ex_shedingcanshuyichang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_shedingcanshuyichang", 62, 1, "设定参数异常"));

            map.Add("ex_shizhongguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_shizhongguzhang", 63, 1, "时钟故障"));

            map.Add("ex_cunchuqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_cunchuqiguzhang", 64, 1, "存储器故障"));

            map.Add("ex_waibuliansuobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_waibuliansuobaojing", 65, 1, "外部连锁报警"));

            map.Add("ex_queyoubaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_queyoubaojing", 66, 1, "缺油报警"));

            map.Add("ex_diyouweibaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_diyouweibaojing", 67, 1, "低油位报警"));

            map.Add("ex_bentipaiyanwendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_bentipaiyanwendugaobaojing", 68, 1, "本体排烟温度高报警"));

            map.Add("ex_bianpinqiguzhangbaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_bianpinqiguzhangbaojing", 69, 1, "变频器故障报警"));

            map.Add("ex_meishuiwendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_meishuiwendugaobaojing", 70, 1, "媒水温度高报警"));

            map.Add("ex_1haoguoluguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_1haoguoluguzhang", 71, 1, "1号锅炉故障"));

            map.Add("ex_2haoguoluguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_2haoguoluguzhang", 72, 1, "2号锅炉故障"));

            map.Add("ex_3haoguoluguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_3haoguoluguzhang", 73, 1, "3号锅炉故障"));

            map.Add("ex_4haoguoluguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_4haoguoluguzhang", 74, 1, "4号锅炉故障"));

            map.Add("ex_5haoguoluguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_5haoguoluguzhang", 75, 1, "5号锅炉故障"));

            map.Add("ex_6haoguoluguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_6haoguoluguzhang", 76, 1, "6号锅炉故障"));

            map.Add("ex_7haoguoluguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_7haoguoluguzhang", 77, 1, "7号锅炉故障"));

            map.Add("ex_8haoguoluguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_8haoguoluguzhang", 78, 1, "8号锅炉故障"));

            map.Add("ex_bushuibianpinqiguzhangbaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_bushuibianpinqiguzhangbaojing", 79, 1, "补水变频器故障报警"));

            map.Add("ex_shuiliukaiguanbaohubaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_shuiliukaiguanbaohubaojing", 80, 1, "水流开关保护报警"));

            map.Add("ex_rukouwendudibaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_rukouwendudibaojing", 81, 1, "入口温度低报警"));

            map.Add("ex_xunhuanbengbianpinqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_xunhuanbengbianpinqiguzhang", 82, 1, "循环泵变频器故障"));

            map.Add("ex_ecixunhuanbengbianpinqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_ecixunhuanbengbianpinqiguzhang", 83, 1, "二次循环泵变频器故障"));

            map.Add("ex_reshuibengbianpinqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_reshuibengbianpinqiguzhang", 84, 1, "热水泵变频器故障"));

            map.Add("ex_buyoubengbianpinqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_buyoubengbianpinqiguzhang", 85, 1, "补油泵变频器故障"));

            map.Add("ex_ecigufengbianpinqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_ecigufengbianpinqiguzhang", 86, 1, "二次鼓风变频器故障"));

            map.Add("ex_songliaojibianpinqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_songliaojibianpinqiguzhang", 87, 1, "送料机变频器故障"));

            map.Add("ex_zhenkongbengbianpinqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_zhenkongbengbianpinqiguzhang", 88, 1, "真空泵变频器故障"));

            map.Add("ex_lengningbengbianpinqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_lengningbengbianpinqiguzhang", 89, 1, "冷凝泵变频器故障"));

            map.Add("ex_bushuibengguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_bushuibengguzhang", 90, 1, "补水泵故障"));

            map.Add("ex_buyoubengguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_buyoubengguzhang", 91, 1, "补油泵故障"));

            map.Add("ex_lengningbengguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_lengningbengguzhang", 92, 1, "冷凝泵故障"));

            map.Add("ex_reshuibengguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_reshuibengguzhang", 93, 1, "热水泵故障"));

            map.Add("ex_zhenkongbengguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_zhenkongbengguzhang", 94, 1, "真空泵故障"));

            map.Add("ex_ecixunhuanbengguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_ecixunhuanbengguzhang", 95, 1, "二次循环泵故障"));

            map.Add("ex_huilu1xunhuanbengguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_huilu1xunhuanbengguzhang", 96, 1, "回路1循环泵故障"));

            map.Add("ex_huilu2xunhuanbengguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_huilu2xunhuanbengguzhang", 97, 1, "回路2循环泵故障"));

            map.Add("ex_huilu3xunhuanbengguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_huilu3xunhuanbengguzhang", 98, 1, "回路3循环泵故障"));

            map.Add("ex_huilu4xunhuanbengguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_huilu4xunhuanbengguzhang", 99, 1, "回路4循环泵故障"));

            map.Add("ex_huilu5xunhuanbengguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_huilu5xunhuanbengguzhang", 100, 1, "回路5循环泵故障"));

            map.Add("ex_huilu1wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_huilu1wendugaobaojing", 101, 1, "回路1温度高报警"));

            map.Add("ex_huilu2wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_huilu2wendugaobaojing", 102, 1, "回路2温度高报警"));

            map.Add("ex_huilu3wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_huilu3wendugaobaojing", 103, 1, "回路3温度高报警"));

            map.Add("ex_huilu4wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_huilu4wendugaobaojing", 104, 1, "回路4温度高报警"));

            map.Add("ex_huilu5wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_huilu5wendugaobaojing", 105, 1, "回路5温度高报警"));

            map.Add("ex_panguan1wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_panguan1wendugaobaojing", 106, 1, "盘管1温度高报警"));

            map.Add("ex_panguan2wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_panguan2wendugaobaojing", 107, 1, "盘管2温度高报警"));

            map.Add("ex_panguan3wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_panguan3wendugaobaojing", 108, 1, "盘管3温度高报警"));

            map.Add("ex_panguan4wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_panguan4wendugaobaojing", 109, 1, "盘管4温度高报警"));

            map.Add("ex_panguan5wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_panguan5wendugaobaojing", 110, 1, "盘管5温度高报警"));

            map.Add("ex_panguan6wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_panguan6wendugaobaojing", 111, 1, "盘管6温度高报警"));

            map.Add("ex_panguan7wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_panguan7wendugaobaojing", 112, 1, "盘管7温度高报警"));

            map.Add("ex_panguan8wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_panguan8wendugaobaojing", 113, 1, "盘管8温度高报警"));

            map.Add("ex_panguan9wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_panguan9wendugaobaojing", 114, 1, "盘管9温度高报警"));

            map.Add("ex_panguan10wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_panguan10wendugaobaojing", 115, 1, "盘管10温度高报警"));

            map.Add("ex_shanzhengguanchaoyabaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_shanzhengguanchaoyabaojing", 116, 1, "闪蒸罐超压报警"));

            map.Add("ex_lengningguanchaoyabaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_lengningguanchaoyabaojing", 117, 1, "冷凝罐超压报警"));

            map.Add("ex_pengzhangguanchaoyabaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_pengzhangguanchaoyabaojing", 118, 1, "膨胀罐超压报警"));

            map.Add("ex_shanzhengguanyeweigaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_shanzhengguanyeweigaobaojing", 119, 1, "闪蒸罐液位高报警"));

            map.Add("ex_shanzhengguanyeweidibaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_shanzhengguanyeweidibaojing", 120, 1, "闪蒸罐液位低报警"));

            map.Add("ex_lengningguanyeweigaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_lengningguanyeweigaobaojing", 121, 1, "冷凝罐液位高报警"));

            map.Add("ex_lengningguanyeweidibaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_lengningguanyeweidibaojing", 122, 1, "冷凝罐液位低报警"));

            map.Add("ex_pengzhangguanyeweigaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_pengzhangguanyeweigaobaojing", 123, 1, "膨胀罐液位高报警"));

            map.Add("ex_pengzhangguanyeweidibaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_pengzhangguanyeweidibaojing", 124, 1, "膨胀罐液位低报警"));

            map.Add("ex_jinchukouyachadibaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_jinchukouyachadibaojing", 125, 1, "进出口压差低报警"));

            map.Add("ex_jinchukouyachagaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_jinchukouyachagaobaojing", 126, 1, "进出口压差高报警"));

            map.Add("ex_zhenkongyalibuzubaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_zhenkongyalibuzubaojing", 127, 1, "真空压力不足报警"));

            map.Add("ex_jinchukouwenchadibaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_jinchukouwenchadibaojing", 128, 1, "进出口温差低报警"));

            map.Add("ex_jinchukouwenchagaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_jinchukouwenchagaobaojing", 129, 1, "进出口温差高报警"));

            map.Add("ex_guoluhuohuiluchukouyaligaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_guoluhuohuiluchukouyaligaobaojing", 130, 1, "出口压力高报警（锅炉或回路）"));

            map.Add("ex_guoluhuohuiluchukouyalidibaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_guoluhuohuiluchukouyalidibaojing", 131, 1, "出口压力低报警（锅炉或回路）"));

            map.Add("ex_guoluhuohuilurukouyaligaobaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_guoluhuohuilurukouyaligaobaojing", 132, 1, "入口压力高报警（锅炉或回路）"));

            map.Add("ex_guoluhuohuilurukouyalidibaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_guoluhuohuilurukouyalidibaojing", 133, 1, "入口压力低报警（锅炉或回路）"));


            map.Add("ex_dongzuofankuiyichangyinfengjiguzhangbaojing", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_dongzuofankuiyichangyinfengjiguzhangbaojing", 134, 1, "引风机故障报警（动作反馈异常）"));


            map.Add("ex_bentipaiyanwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_bentipaiyanwenduchuanganqiguzhang", 181, 1, "本体排烟温度传感器故障"));

            map.Add("ex_paiyanwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_paiyanwenduchuanganqiguzhang", 182, 1, "排烟温度传感器故障"));

            map.Add("ex_lushuiwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_lushuiwenduchuanganqiguzhang", 183, 1, "炉水温度传感器故障"));

            map.Add("ex_chukouwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_chukouwenduchuanganqiguzhang", 184, 1, "出口温度传感器故障"));

            map.Add("ex_rukouwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_rukouwenduchuanganqiguzhang", 185, 1, "入口温度传感器故障"));

            map.Add("ex_jienengqichukouwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_jienengqichukouwenduchuanganqiguzhang", 186, 1, "节能器出口温度传感器故障"));

            map.Add("ex_jienengqirukouwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_jienengqirukouwenduchuanganqiguzhang", 187, 1, "节能器入口温度传感器故障"));

            map.Add("ex_jishuiwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_jishuiwenduchuanganqiguzhang", 188, 1, "给水温度传感器故障"));

            map.Add("ex_lutangwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_lutangwenduchuanganqiguzhang", 189, 1, "炉膛温度传感器故障"));

            map.Add("ex_lutangchukouwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_lutangchukouwenduchuanganqiguzhang", 190, 1, "炉膛出口温度传感器故障"));

            map.Add("ex_lubiwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_lubiwenduchuanganqiguzhang", 191, 1, "炉壁温度传感器故障"));

            map.Add("ex_ranliaowenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_ranliaowenduchuanganqiguzhang", 192, 1, "燃料温度传感器故障"));

            map.Add("ex_refengwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_refengwenduchuanganqiguzhang", 193, 1, "热风温度传感器故障"));

            map.Add("ex_fuyazhengqiwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_fuyazhengqiwenduchuanganqiguzhang", 194, 1, "负压蒸汽温度传感器故障"));

            map.Add("ex_guorezhengqiwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_guorezhengqiwenduchuanganqiguzhang", 195, 1, "过热蒸汽温度传感器故障"));

            map.Add("ex_huilu1wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_huilu1wenduchuanganqiguzhang", 196, 1, "回路1温度传感器故障"));

            map.Add("ex_huilu2wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_huilu2wenduchuanganqiguzhang", 197, 1, "回路2温度传感器故障"));

            map.Add("ex_huilu3wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_huilu3wenduchuanganqiguzhang", 198, 1, "回路3温度传感器故障"));

            map.Add("ex_huilu4wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_huilu4wenduchuanganqiguzhang", 199, 1, "回路4温度传感器故障"));

            map.Add("ex_huilu5wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_huilu5wenduchuanganqiguzhang", 200, 1, "回路5温度传感器故障"));

            map.Add("ex_shiwaiwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_shiwaiwenduchuanganqiguzhang", 201, 1, "室外温度传感器故障"));

            map.Add("ex_zhengqiyalichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_zhengqiyalichuanganqiguzhang", 202, 1, "蒸汽压力传感器故障"));

            map.Add("ex_jishuiyalichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_jishuiyalichuanganqiguzhang", 203, 1, "给水压力传感器故障"));

            map.Add("ex_chukouyalichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_chukouyalichuanganqiguzhang", 204, 1, "出口压力传感器故障"));

            map.Add("ex_rukouyalichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_rukouyalichuanganqiguzhang", 205, 1, "入口压力传感器故障"));

            map.Add("ex_lutangyalichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_lutangyalichuanganqiguzhang", 206, 1, "炉膛压力传感器故障"));

            map.Add("ex_lutangchukouyalichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_lutangchukouyalichuanganqiguzhang", 207, 1, "炉膛出口压力传感器故障"));

            map.Add("ex_ranqiyalichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_ranqiyalichuanganqiguzhang", 208, 1, "燃气压力传感器故障"));

            map.Add("ex_yicifengyachuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_yicifengyachuanganqiguzhang", 209, 1, "一次风压传感器故障"));

            map.Add("ex_ecifengyachuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_ecifengyachuanganqiguzhang", 210, 1, "二次风压传感器故障"));

            map.Add("ex_ranliaoliangchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_ranliaoliangchuanganqiguzhang", 211, 1, "燃料量传感器故障"));

            map.Add("ex_zhengqiliuliangchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_zhengqiliuliangchuanganqiguzhang", 212, 1, "蒸汽流量传感器故障"));

            map.Add("ex_jishuiliuliangchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_jishuiliuliangchuanganqiguzhang", 213, 1, "给水流量传感器故障"));

            map.Add("ex_xunhuanliuliangchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_xunhuanliuliangchuanganqiguzhang", 214, 1, "循环流量传感器故障"));

            map.Add("ex_bushuiliuliangchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_bushuiliuliangchuanganqiguzhang", 215, 1, "补水流量传感器故障"));

            map.Add("ex_guoluyeweichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_guoluyeweichuanganqiguzhang", 216, 1, "锅炉液位传感器故障"));

            map.Add("ex_shuixiangyeweichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_shuixiangyeweichuanganqiguzhang", 217, 1, "水箱液位传感器故障"));

            map.Add("ex_paiyanyanghanliangchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_paiyanyanghanliangchuanganqiguzhang", 218, 1, "排烟氧含量传感器故障"));

            map.Add("ex_lupaisudufankuichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_lupaisudufankuichuanganqiguzhang", 219, 1, "炉排速度反馈传感器故障"));

            map.Add("ex_yinfengshuchufankuichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_yinfengshuchufankuichuanganqiguzhang", 220, 1, "引风输出反馈传感器故障"));

            map.Add("ex_gufengshuchufankuichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_gufengshuchufankuichuanganqiguzhang", 221, 1, "鼓风输出反馈传感器故障"));

            map.Add("ex_jishuishuchufankuichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_jishuishuchufankuichuanganqiguzhang", 222, 1, "给水输出反馈传感器故障"));

            map.Add("ex_meishuiwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_meishuiwenduchuanganqiguzhang", 223, 1, "媒水温度传感器故障"));

            map.Add("ex_shuixiangwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_shuixiangwenduchuanganqiguzhang", 224, 1, "水箱温度传感器故障"));

            map.Add("ex_pengzhangguanyeweichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_pengzhangguanyeweichuanganqiguzhang", 225, 1, "膨胀罐液位传感器故障"));

            map.Add("ex_shanzhengguanyeweichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_shanzhengguanyeweichuanganqiguzhang", 226, 1, "闪蒸罐液位传感器故障"));

            map.Add("ex_lengningyeguanyeweichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_lengningyeguanyeweichuanganqiguzhang", 227, 1, "冷凝液罐液位传感器故障"));

            map.Add("ex_chuguanyeweichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_chuguanyeweichuanganqiguzhang", 228, 1, "储罐液位传感器故障"));

            map.Add("ex_pengzhangguanwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_pengzhangguanwenduchuanganqiguzhang", 229, 1, "膨胀罐温度传感器故障"));

            map.Add("ex_shanzhengguanwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_shanzhengguanwenduchuanganqiguzhang", 230, 1, "闪蒸罐温度传感器故障"));

            map.Add("ex_lengningyeguanwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_lengningyeguanwenduchuanganqiguzhang", 231, 1, "冷凝液罐温度传感器故障"));

            map.Add("ex_chuguanwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_chuguanwenduchuanganqiguzhang", 232, 1, "储罐温度传感器故障"));

            map.Add("ex_guoluyalichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_guoluyalichuanganqiguzhang", 233, 1, "锅炉压力传感器故障"));

            map.Add("ex_guorezhengqiyalichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_guorezhengqiyalichuanganqiguzhang", 234, 1, "过热蒸汽压力传感器故障"));

            map.Add("ex_paiyanchuyalichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_paiyanchuyalichuanganqiguzhang", 235, 1, "排烟处压力传感器故障"));

            map.Add("ex_fengshifengyachuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_fengshifengyachuanganqiguzhang", 236, 1, "风室风压传感器故障"));

            map.Add("ex_yinfengjidianliuchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_yinfengjidianliuchuanganqiguzhang", 237, 1, "引风机电流传感器故障"));

            map.Add("ex_gufengjidianliuchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_gufengjidianliuchuanganqiguzhang", 238, 1, "鼓风机电流传感器故障"));

            map.Add("ex_jiliaojisudufankuichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_jiliaojisudufankuichuanganqiguzhang", 239, 1, "给料机速度反馈传感器故障"));

            map.Add("ex_panguan1wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_panguan1wenduchuanganqiguzhang", 240, 1, "盘管1温度传感器故障"));

            map.Add("ex_panguan2wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_panguan2wenduchuanganqiguzhang", 241, 1, "盘管2温度传感器故障"));

            map.Add("ex_panguan3wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_panguan3wenduchuanganqiguzhang", 242, 1, "盘管3温度传感器故障"));

            map.Add("ex_panguan4wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_panguan4wenduchuanganqiguzhang", 243, 1, "盘管4温度传感器故障"));

            map.Add("ex_panguan5wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_panguan5wenduchuanganqiguzhang", 244, 1, "盘管5温度传感器故障"));

            map.Add("ex_panguan6wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_panguan6wenduchuanganqiguzhang", 245, 1, "盘管6温度传感器故障"));

            map.Add("ex_panguan7wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_panguan7wenduchuanganqiguzhang", 246, 1, "盘管7温度传感器故障"));

            map.Add("ex_panguan8wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_panguan8wenduchuanganqiguzhang", 247, 1, "盘管8温度传感器故障"));

            map.Add("ex_panguan9wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_panguan9wenduchuanganqiguzhang", 248, 1, "盘管9温度传感器故障"));

            map.Add("ex_panguan10wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ.ExceptionField(), "ex_panguan10wenduchuanganqiguzhang", 249, 1, "盘管10温度传感器故障"));

            map.Add("mo_bentipaiyanwendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_bentipaiyanwendu", 277, 2, "本体排烟温度", "℃"));

            map.Add("mo_paiyanwendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_paiyanwendu", 279, 2, "排烟温度", "℃"));

            map.Add("mo_lushuiwendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_lushuiwendu", 281, 2, "炉水温度", "℃"));

            map.Add("mo_chukouwendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_chukouwendu", 283, 2, "出口温度", "℃"));

            map.Add("mo_rukouwendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_rukouwendu", 285, 2, "入口温度", "℃"));

            map.Add("mo_jienengqichukouwendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_jienengqichukouwendu", 287, 2, "节能器出口温度", "℃"));

            map.Add("mo_jienengqirukouwendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_jienengqirukouwendu", 289, 2, "节能器入口温度", "℃"));

            map.Add("mo_jishuiwendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_jishuiwendu", 291, 2, "给水温度", "℃"));

            map.Add("mo_lutangwendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_lutangwendu", 293, 2, "炉膛温度", "℃"));

            map.Add("mo_lutangchukouwendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_lutangchukouwendu", 295, 2, "炉膛出口温度", "℃"));

            map.Add("mo_lubiwendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_lubiwendu", 297, 2, "炉壁温度", "℃"));

            map.Add("mo_ranliaowendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_ranliaowendu", 299, 2, "燃料温度", "℃"));

            map.Add("mo_refengwendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_refengwendu", 301, 2, "热风温度", "℃"));

            map.Add("mo_fuyazhengqiwendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_fuyazhengqiwendu", 303, 2, "负压蒸汽温度", "℃"));

            map.Add("mo_guorezhengqiwendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_guorezhengqiwendu", 305, 2, "过热蒸汽温度", "℃"));

            map.Add("mo_huilu1wendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_huilu1wendu", 307, 2, "回路1温度", "℃"));

            map.Add("mo_huilu2wendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_huilu2wendu", 309, 2, "回路2温度", "℃"));

            map.Add("mo_huilu3wendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_huilu3wendu", 311, 2, "回路3温度", "℃"));

            map.Add("mo_huilu4wendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_huilu4wendu", 313, 2, "回路4温度", "℃"));

            map.Add("mo_huilu5wendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_huilu5wendu", 315, 2, "回路5温度", "℃"));

            map.Add("mo_shiwaiwendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_shiwaiwendu", 317, 2, "室外温度", "℃"));

            map.Add("mo_zhengqiyali", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_zhengqiyali", 319, 2, "蒸汽压力", "MPa", 100));

            map.Add("mo_jishuiyali", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_jishuiyali", 321, 2, "给水压力", "MPa", 100));

            map.Add("mo_chukouyali", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_chukouyali", 323, 2, "出口压力", "MPa", 100));

            map.Add("mo_rukouyali", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_rukouyali", 325, 2, "入口压力", "MPa", 100));

            map.Add("mo_lutangyali", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_lutangyali", 327, 2, "炉膛压力", "Pa"));

            map.Add("mo_lutangchukouyali", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_lutangchukouyali", 329, 2, "炉膛出口压力", "Pa"));

            map.Add("mo_ranqiyali", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_ranqiyali", 331, 2, "燃气压力", "KPa"));

            map.Add("mo_yicifengya", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_yicifengya", 333, 2, "一次风压", "KPa"));

            map.Add("mo_ecifengya", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_ecifengya", 335, 2, "二次风压", "KPa"));

            map.Add("mo_ranliaoliang", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_ranliaoliang", 337, 2, "燃料量"));

            map.Add("mo_zhengqiliuliang", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_zhengqiliuliang", 339, 2, "蒸汽流量"));

            map.Add("mo_jishuiliuliang", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_jishuiliuliang", 341, 2, "给水流量"));

            map.Add("mo_xunhuanliuliang", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_xunhuanliuliang", 343, 2, "循环流量"));

            map.Add("mo_bushuiliuliang", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_bushuiliuliang", 345, 2, "补水流量"));

            map.Add("mo_guoluyewei", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_guoluyewei", 347, 2, "锅炉液位", "mm"));

            map.Add("mo_shuixiangyewei", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_shuixiangyewei", 349, 2, "水箱液位", "mm"));

            map.Add("mo_paiyanyanghanliang", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_paiyanyanghanliang", 351, 2, "排烟氧含量", "%", 10));

            map.Add("mo_lupaisudufankui", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_lupaisudufankui", 353, 2, "炉排速度反馈", "%"));

            map.Add("mo_yinfengshuchufankui", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_yinfengshuchufankui", 355, 2, "引风输出反馈", "%"));

            map.Add("mo_gufengshuchufankui", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_gufengshuchufankui", 357, 2, "鼓风输出反馈", "%"));

            map.Add("mo_jishuishuchufankui", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_jishuishuchufankui", 359, 2, "给水输出反馈", "%"));

            map.Add("mo_meishuiwendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_meishuiwendu", 361, 2, "媒水温度", "℃"));

            map.Add("mo_shuixiangwendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_shuixiangwendu", 363, 2, "水箱温度", "℃"));

            map.Add("mo_pengzhangguanyewei", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_pengzhangguanyewei", 365, 2, "膨胀罐液位", "mm"));

            map.Add("mo_shanzhengguanyewei", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_shanzhengguanyewei", 367, 2, "闪蒸罐液位", "mm"));

            map.Add("mo_lengningyeguanyewei", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_lengningyeguanyewei", 369, 2, "冷凝液罐液位", "mm"));

            map.Add("mo_chuguanyewei", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_chuguanyewei", 371, 2, "储罐液位", "mm"));

            map.Add("mo_pengzhangguanwendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_pengzhangguanwendu", 373, 2, "膨胀罐温度", "℃"));

            map.Add("mo_shanzhengguanwendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_shanzhengguanwendu", 375, 2, "闪蒸罐温度", "℃"));

            map.Add("mo_lengningyeguanwendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_lengningyeguanwendu", 377, 2, "冷凝液罐温度", "℃"));

            map.Add("mo_chuguanwendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_chuguanwendu", 379, 2, "储罐温度", "℃"));

            map.Add("mo_guoluyali", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_guoluyali", 381, 2, "锅炉压力", "MPa", 100));

            map.Add("mo_guorezhengqiyali", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_guorezhengqiyali", 383, 2, "过热蒸汽压力", "MPa", 100));

            map.Add("mo_paiyanchuyali", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_paiyanchuyali", 385, 2, "排烟处压力", "Pa"));

            map.Add("mo_fengshifengya", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_fengshifengya", 387, 2, "风室风压", "KPa"));

            map.Add("mo_yinfengjidianliu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_yinfengjidianliu", 389, 2, "引风机电流", "A"));

            map.Add("mo_gufengjidianliu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_gufengjidianliu", 391, 2, "鼓风机电流", "A"));

            map.Add("mo_jiliaojisudufankui", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_jiliaojisudufankui", 393, 2, "给料机速度反馈", "%"));

            map.Add("mo_panguan1wendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_panguan1wendu", 395, 2, "盘管1温度", "℃"));

            map.Add("mo_panguan2wendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_panguan2wendu", 397, 2, "盘管2温度", "℃"));

            map.Add("mo_panguan3wendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_panguan3wendu", 399, 2, "盘管3温度", "℃"));

            map.Add("mo_panguan4wendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_panguan4wendu", 401, 2, "盘管4温度", "℃"));

            map.Add("mo_panguan5wendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_panguan5wendu", 403, 2, "盘管5温度", "℃"));

            map.Add("mo_panguan6wendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_panguan6wendu", 405, 2, "盘管6温度", "℃"));

            map.Add("mo_panguan7wendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_panguan7wendu", 407, 2, "盘管7温度", "℃"));

            map.Add("mo_panguan8wendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_panguan8wendu", 409, 2, "盘管8温度", "℃"));

            map.Add("mo_panguan9wendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_panguan9wendu", 411, 2, "盘管9温度", "℃"));

            map.Add("mo_panguan10wendu", ByteField.Init(new Meta.CTL_NJZJ.MockField(), "mo_panguan10wendu", 413, 2, "盘管10温度", "℃"));

            map.Add("se_paiyanwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_paiyanwendu", 465, 2, "排烟温度", "℃"));

            map.Add("se_baojingwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_baojingwendu", 467, 2, "报警温度", "℃"));

            map.Add("se_tingluwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_tingluwendu", 469, 2, "停炉温度", "℃"));

            map.Add("se_mubiaowendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_mubiaowendu", 471, 2, "目标温度", "℃"));

            map.Add("se_qiluwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_qiluwendu", 473, 2, "启炉温度", "℃"));

            map.Add("se_zhuanhuohuichawendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_zhuanhuohuichawendu", 475, 2, "转火回差温度", "℃"));

            map.Add("se_qiluhuichawendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_qiluhuichawendu", 477, 2, "启炉回差温度", "℃"));

            map.Add("se_kaibengwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_kaibengwendu", 479, 2, "开泵温度", "℃"));

            map.Add("se_guanbengwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_guanbengwendu", 481, 2, "关泵温度", "℃"));

            map.Add("se_baojingyali", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_baojingyali", 483, 2, "报警压力", "MPa", 100));

            map.Add("se_tingluyali", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_tingluyali", 485, 2, "停炉压力", "MPa", 100));

            map.Add("se_mubiaoyali", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_mubiaoyali", 487, 2, "目标压力", "MPa", 100));

            map.Add("se_qiluyali", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_qiluyali", 489, 2, "启炉压力", "MPa", 100));

            map.Add("se_zhuanhuohuichayali", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_zhuanhuohuichayali", 491, 2, "转火回差压力", "MPa", 100));

            map.Add("se_qiluhuichayali", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_qiluhuichayali", 493, 2, "启炉回差压力", "MPa", 100));

            map.Add("se_qianyanshi", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_qianyanshi", 495, 2, "前延时", "S"));

            map.Add("se_houyanshimiao", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_houyanshimiao", 497, 2, "后延时秒", "S"));

            map.Add("se_qianchuisao", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_qianchuisao", 499, 2, "前吹扫", "S"));

            map.Add("se_houchuisao", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_houchuisao", 501, 2, "后吹扫", "S"));

            map.Add("se_lubibaojingwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_lubibaojingwendu", 503, 2, "炉壁报警温度", "℃"));

            map.Add("se_lutangchukoubaojingwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_lutangchukoubaojingwendu", 505, 2, "炉膛出口报警温度", "℃"));

            map.Add("se_baohuwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_baohuwendu", 507, 2, "保护温度", "℃"));

            map.Add("se_bentipaiyanwendubaojingzhi", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_bentipaiyanwendubaojingzhi", 509, 2, "本体排烟温度报警值", "℃"));

            map.Add("se_jiarezushu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_jiarezushu", 511, 2, "加热组数"));

            map.Add("se_jianceyalishijian", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_jianceyalishijian", 513, 2, "检测压力时间"));

            map.Add("se_houyanshifen", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_houyanshifen", 515, 2, "后延时分", "m"));

            map.Add("se_shedingwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_shedingwendu", 517, 2, "设定温度", "℃"));

            map.Add("se_mokuailutaishu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_mokuailutaishu", 519, 2, "模块炉台数"));

            map.Add("se_gufenghouyanshi", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_gufenghouyanshi", 521, 2, "鼓风后延时", "S"));

            map.Add("se_yinfenghouyanshi", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_yinfenghouyanshi", 523, 2, "引风后延时", "S"));

            map.Add("se_shuixiangkaibengwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_shuixiangkaibengwendu", 525, 2, "水箱开泵温度", "℃"));

            map.Add("se_shuixiangguanbengwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_shuixiangguanbengwendu", 527, 2, "水箱关泵温度", "℃"));

            map.Add("se_lushuibaojingwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_lushuibaojingwendu", 529, 2, "炉水报警温度", "℃"));

            map.Add("se_buchangxishu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_buchangxishu", 531, 2, "补偿系数"));

            map.Add("se_cankaowendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_cankaowendu", 533, 2, "参考温度", "℃"));

            map.Add("se_tingluzuidazhi", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_tingluzuidazhi", 535, 2, "停炉最大值", "℃"));

            map.Add("se_qiluzuixiaozhi", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_qiluzuixiaozhi", 537, 2, "启炉最小值", "℃"));

            map.Add("se_cankaohuicha", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_cankaohuicha", 539, 2, "参考回差", "℃"));

            map.Add("se_tingluwendu1", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_tingluwendu1", 541, 2, "停炉温度1", "℃"));

            map.Add("se_qiluwendu1", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_qiluwendu1", 543, 2, "启炉温度1", "℃"));

            map.Add("se_tingluwendu2", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_tingluwendu2", 545, 2, "停炉温度2", "℃"));

            map.Add("se_qiluwendu2", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_qiluwendu2", 547, 2, "启炉温度2", "℃"));

            map.Add("se_yusongliaoshijian", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_yusongliaoshijian", 549, 2, "预送料时间", "S"));

            map.Add("se_dianhuoshijian", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_dianhuoshijian", 551, 2, "点火时间", "S"));

            map.Add("se_songliaoqidongshijian", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_songliaoqidongshijian", 553, 2, "送料启动时间", "S"));

            map.Add("se_songliaotingzhishijian", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_songliaotingzhishijian", 555, 2, "送料停止时间", "S"));

            map.Add("se_dianhuojiange", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_dianhuojiange", 557, 2, "点火间隔", "m"));

            map.Add("se_dianhuochenggongwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_dianhuochenggongwendu", 559, 2, "点火成功温度", "℃"));

            map.Add("se_lushuitingluwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_lushuitingluwendu", 561, 2, "炉水停炉温度", "℃"));

            map.Add("se_lushuiqiluwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_lushuiqiluwendu", 563, 2, "炉水启炉温度", "℃"));

            map.Add("se_meishuibaojingwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_meishuibaojingwendu", 565, 2, "媒水报警温度", "℃"));

            map.Add("se_meishuitingluwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_meishuitingluwendu", 567, 2, "媒水停炉温度", "℃"));

            map.Add("se_meishuiqiluwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_meishuiqiluwendu", 569, 2, "媒水启炉温度", "℃"));

            map.Add("se_kaibengyali", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_kaibengyali", 571, 2, "开泵压力", "MPa", 100));

            map.Add("se_guanbengyali", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_guanbengyali", 573, 2, "关泵压力", "MPa", 100));

            map.Add("se_panguanbaojingwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_panguanbaojingwendu", 575, 2, "盘管报警温度", "℃"));

            map.Add("se_huilu1baojingwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_huilu1baojingwendu", 577, 2, "回路1报警温度", "℃"));

            map.Add("se_huilu1kaibengwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_huilu1kaibengwendu", 579, 2, "回路1开泵温度", "℃"));

            map.Add("se_huilu1guanbengwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_huilu1guanbengwendu", 581, 2, "回路1关泵温度", "℃"));

            map.Add("se_huilu2baojingwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_huilu2baojingwendu", 583, 2, "回路2报警温度", "℃"));

            map.Add("se_huilu2kaibengwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_huilu2kaibengwendu", 585, 2, "回路2开泵温度", "℃"));

            map.Add("se_huilu2guanbengwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_huilu2guanbengwendu", 587, 2, "回路2关泵温度", "℃"));

            map.Add("se_huilu3baojingwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_huilu3baojingwendu", 589, 2, "回路3报警温度", "℃"));

            map.Add("se_huilu3kaibengwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_huilu3kaibengwendu", 591, 2, "回路3开泵温度", "℃"));

            map.Add("se_huilu3guanbengwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_huilu3guanbengwendu", 593, 2, "回路3关泵温度", "℃"));

            map.Add("se_huilu4baojingwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_huilu4baojingwendu", 595, 2, "回路4报警温度", "℃"));

            map.Add("se_huilu4kaibengwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_huilu4kaibengwendu", 597, 2, "回路4开泵温度", "℃"));

            map.Add("se_huilu4guanbengwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_huilu4guanbengwendu", 599, 2, "回路4关泵温度", "℃"));

            map.Add("se_huilu5baojingwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_huilu5baojingwendu", 601, 2, "回路5报警温度", "℃"));

            map.Add("se_huilu5kaibengwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_huilu5kaibengwendu", 603, 2, "回路5开泵温度", "℃"));

            map.Add("se_huilu5guanbengwendu", ByteField.Init(new Meta.CTL_NJZJ.SettingField(), "se_huilu5guanbengwendu", 605, 2, "回路5关泵温度", "℃"));

            map.Add("st_qidongshijian1", ByteField.Init(new Meta.CTL_NJZJ.StartStopField(), "st_qidongshijian1", 607, 2, "启动时间1"));

            map.Add("st_tingzhishijian1", ByteField.Init(new Meta.CTL_NJZJ.StartStopField(), "st_tingzhishijian1", 609, 2, "停止时间1"));

            map.Add("st_qidongshijian2", ByteField.Init(new Meta.CTL_NJZJ.StartStopField(), "st_qidongshijian2", 611, 2, "启动时间2"));

            map.Add("st_tingzhishijian2", ByteField.Init(new Meta.CTL_NJZJ.StartStopField(), "st_tingzhishijian2", 613, 2, "停止时间2"));

            map.Add("st_qidongshijian3", ByteField.Init(new Meta.CTL_NJZJ.StartStopField(), "st_qidongshijian3", 615, 2, "启动时间3"));

            map.Add("st_tingzhishijian3", ByteField.Init(new Meta.CTL_NJZJ.StartStopField(), "st_tingzhishijian3", 617, 2, "停止时间3"));

            map.Add("st_qidongshijian4", ByteField.Init(new Meta.CTL_NJZJ.StartStopField(), "st_qidongshijian4", 619, 2, "启动时间4"));

            map.Add("st_tingzhishijian4", ByteField.Init(new Meta.CTL_NJZJ.StartStopField(), "st_tingzhishijian4", 621, 2, "停止时间4"));

            map.Add("st_qidongshijian5", ByteField.Init(new Meta.CTL_NJZJ.StartStopField(), "st_qidongshijian5", 623, 2, "启动时间5"));

            map.Add("st_tingzhishijian5", ByteField.Init(new Meta.CTL_NJZJ.StartStopField(), "st_tingzhishijian5", 625, 2, "停止时间5"));

            map.Add("st_qidongshijian6", ByteField.Init(new Meta.CTL_NJZJ.StartStopField(), "st_qidongshijian6", 627, 2, "启动时间6"));

            map.Add("st_tingzhishijian6", ByteField.Init(new Meta.CTL_NJZJ.StartStopField(), "st_tingzhishijian6", 629, 2, "停止时间6"));

            map.Add("de_ranshaoqi", ByteField.Init(new Meta.CTL_NJZJ.RanShaoQiField(), "de_ranshaoqi", 681, 2, "燃烧器", new Dictionary<int, string> { { 0, "停" }, { 1, "小火" }, { 2, "大火" } }));

            map.Add("de_jiarezu", ByteField.Init(new Meta.CTL_NJZJ.DeviceField(), "de_jiarezu", 683, 2, "加热组", coms_device));

            map.Add("de_bushuibeng", ByteField.Init(new Meta.CTL_NJZJ.DeviceField(), "de_bushuibeng", 685, 2, "补水泵", coms_device));

            map.Add("de_jishuibeng", ByteField.Init(new Meta.CTL_NJZJ.DeviceField(), "de_jishuibeng", 687, 2, "给水泵", coms_device));

            map.Add("de_buyoubeng", ByteField.Init(new Meta.CTL_NJZJ.DeviceField(), "de_buyoubeng", 689, 2, "补油泵", coms_device));

            map.Add("de_xunhuanbeng", ByteField.Init(new Meta.CTL_NJZJ.DeviceField(), "de_xunhuanbeng", 691, 2, "循环泵", coms_device));

            map.Add("de_lengningbeng", ByteField.Init(new Meta.CTL_NJZJ.DeviceField(), "de_lengningbeng", 693, 2, "冷凝泵", coms_device));

            map.Add("de_reshuibeng", ByteField.Init(new Meta.CTL_NJZJ.DeviceField(), "de_reshuibeng", 695, 2, "热水泵", coms_device));

            map.Add("de_zhenkongbeng", ByteField.Init(new Meta.CTL_NJZJ.DeviceField(), "de_zhenkongbeng", 697, 2, "真空泵", coms_device));

            map.Add("de_ecixunhuanbeng", ByteField.Init(new Meta.CTL_NJZJ.DeviceField(), "de_ecixunhuanbeng", 699, 2, "二次循环泵", coms_device));

            map.Add("de_yinfengji", ByteField.Init(new Meta.CTL_NJZJ.DeviceField(), "de_yinfengji", 701, 2, "引风机", coms_device));

            map.Add("de_gufengji", ByteField.Init(new Meta.CTL_NJZJ.DeviceField(), "de_gufengji", 703, 2, "鼓风机", coms_device));

            map.Add("de_lupai", ByteField.Init(new Meta.CTL_NJZJ.DeviceField(), "de_lupai", 705, 2, "炉排", coms_device));

            map.Add("de_chuzhaji", ByteField.Init(new Meta.CTL_NJZJ.DeviceField(), "de_chuzhaji", 707, 2, "出渣机", coms_device));

            map.Add("de_ecigufengji", ByteField.Init(new Meta.CTL_NJZJ.DeviceField(), "de_ecigufengji", 709, 2, "二次鼓风机", coms_device));

            map.Add("de_dianhuoqi", ByteField.Init(new Meta.CTL_NJZJ.DeviceField(), "de_dianhuoqi", 711, 2, "点火器", coms_device));

            map.Add("de_shangmeiji", ByteField.Init(new Meta.CTL_NJZJ.DeviceField(), "de_shangmeiji", 713, 2, "上煤机", coms_device));

            map.Add("de_songliaoji", ByteField.Init(new Meta.CTL_NJZJ.DeviceField(), "de_songliaoji", 715, 2, "送料机", coms_device));

            map.Add("de_jiayaobeng", ByteField.Init(new Meta.CTL_NJZJ.DeviceField(), "de_jiayaobeng", 717, 2, "加药泵", coms_device));

            map.Add("de_paiwufa", ByteField.Init(new Meta.CTL_NJZJ.DeviceField(), "de_paiwufa", 719, 2, "排污阀", coms_device));

            map.Add("de_huilu1xunhuanbeng", ByteField.Init(new Meta.CTL_NJZJ.DeviceField(), "de_huilu1xunhuanbeng", 721, 2, "回路1循环泵", coms_device));

            map.Add("de_huilu2xunhuanbeng", ByteField.Init(new Meta.CTL_NJZJ.DeviceField(), "de_huilu2xunhuanbeng", 723, 2, "回路2循环泵", coms_device));

            map.Add("de_huilu3xunhuanbeng", ByteField.Init(new Meta.CTL_NJZJ.DeviceField(), "de_huilu3xunhuanbeng", 725, 2, "回路3循环泵", coms_device));

            map.Add("de_huilu4xunhuanbeng", ByteField.Init(new Meta.CTL_NJZJ.DeviceField(), "de_huilu4xunhuanbeng", 727, 2, "回路4循环泵", coms_device));

            map.Add("de_huilu5xunhuanbeng", ByteField.Init(new Meta.CTL_NJZJ.DeviceField(), "de_huilu5xunhuanbeng", 729, 2, "回路5循环泵", coms_device));

        }
    }
}
