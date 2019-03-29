using hongbao.SystemExtension;
using hongbao.WebExtension;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.LbsExtension
{
    /// <summary>
    /// 利用高德WEB SERVICE 来根据地理位置解析的类；
    /// </summary>
    public class GpsUtil
    {
        /// <summary>
        /// 地球半径； 
        /// </summary>
        public double EARTH_RADIUS = 6378137; // 地球米

        /// <summary>
        /// 地球周长；
        /// </summary>
        public double EARTH_AA = Math.PI * 6378137;

        /// <summary>
        ///  //每1纬度的距离（米)；
        /// </summary>
        public static decimal jl_wd = 111712.691506m;

        /// <summary>
        /// //每1经度的距离（米)；
        /// </summary>
        public static decimal jl_jd = 102834.742580m;

        /// <summary>
        /// 返回给定坐标点距离内的坐标；
        /// </summary>
        /// <returns></returns>
        public static GpsRectangle GetRectange(Gps gps, decimal distance)
        {
            return new GpsRectangle
            {
                Top = gps.Latitude - distance/jl_wd,
                Bottom = gps.Latitude + distance / jl_wd,
                Left = gps.Longtitude - distance / jl_wd,
                Right = gps.Longtitude + distance / jl_wd
            };
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="longitude"></param>
        /// <param name="latitude"></param>
        /// <param name="distance"></param>
        /// <returns></returns>
        public static GpsRectangle GetRectange(decimal longitude, decimal latitude, decimal distance)
        {
            return GetRectange(new Gps { Latitude = latitude, Longtitude = longitude }, distance);
        }

        /// <summary>
        /// 
        /// </summary>
        static GpsUtil()
        {
            //http://lbs.amap.com/api/webservice/reference/georegeo/
            AMAP_GEO_URL = ConfigurationUtil.AppSetting("amap_geocode_geo");
            AMAP_REGEO_URL = ConfigurationUtil.AppSetting("amap_geocode_regeo");
            AMAP_APP_KEY = ConfigurationUtil.AppSetting("amap_webservice_appkey");
        }
        

        /// <summary>
        /// 高德地图地址解析的 url; 
        /// </summary>
        public static string AMAP_GEO_URL = null;
        /// <summary>
        /// 高德地图坐标解析的 url; 
        /// </summary>
        public static string AMAP_REGEO_URL = null;
        /// <summary>
        /// 高德地图的 APP KEY; 
        /// </summary>
        public static string AMAP_APP_KEY = null;

        /// <summary>
        /// 认为是同一地址的最小经度或者维度的偏差； 
        /// http://www.360doc.com/content/11/0414/16/6426559_109617436.shtml
        /// 如果是中国常用的WGS1984的经纬度坐标，1秒相当于33米
        /// 经度1度=85.39km
        /// 经度1分 = 1.42km 
        /// 经度1秒 = 23.6m
        /// 纬度1度 = 大约111km 
        /// 纬度1分 = 大约1.85km 
        /// 纬度1秒 = 大约30.9m
        /// 109.90581 转为 109度54分21秒
        /// 经纬度转换公式
        ///打开excel在首行首列单元格中输入经纬度值 如109.90581
        ///将公式 =INT(A1) "度" INT((A1-INT(A1))*60) "分" ROUND(((A1-INT(A1))*60-INT((A1-INT(A1))*60))*60,0) "秒" 
        /// 变为109度54分21秒.
        /// 整数部分表述度，1度等于3600秒,
        /// 所以 0.0001表示大约3分之1秒;
        ///      0.0005表示大约1.5秒,即50米和35米左右;  
        ///      广州市天河区天河软件园建中路44号4楼整层
        ///      和 
        ///      广州市天河区天河软件园建中路42号
        ///      相隔在 0.0005 之下，所以再缩小到 0.00005;
        /// </summary>
        public static readonly decimal MIN_DISTANCE = 0.0002m;

        /// <summary>
        /// 计算两个地方的距离;
        /// </summary>
        public static int CalculateDistance(Gps gpsa, Gps gpsb)
        {
            return (int)Math.Sqrt(( Math.Pow((double) (jl_wd * Math.Abs(gpsa.Longtitude - gpsb.Longtitude)), 2)
                  + Math.Pow((double) (jl_jd * Math.Abs(gpsa.Latitude - gpsb.Latitude)), 2)));
        }

        /// <summary>
        /// 根据地址获得GPS的地理信息
        /// 根据地址获得 坐标；注意，无法获取到建筑物,        
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static Gps GetGpsByAddress(string address)
        {            
            string url = "{0}?address={2}&key={1}";
            string urlreq = string.Format(url, new string[] { AMAP_GEO_URL, AMAP_APP_KEY, address });
            string result = HttpUtil.ReadWeb(urlreq);
            /*System.Web.Script.Serialization.JavaScriptSerializer ser
                = new System.Web.Script.Serialization.JavaScriptSerializer();
            {"status":"1","info":"OK","infocode":"10000","count":"1",
            "geocodes":[{"formatted_address":"北京市朝阳区方恒国际中心A座","province":"北京市","citycode":"010","city":"北京市",
            "district":"朝阳区","township":[],"neighborhood":{"name":[],"type":[]},
            "building":{"name":[],"type":[]},"adcode":"110105","street":[],"number":[],"location":"116.480690,39.989777","level":"门牌号"}]}
            */
            /*
             * 注意上面的建筑物有问题，所以需要根据坐标去进行重新解析;
             */
            //ser.
            var urlResult = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, object>>(result);           
            if (urlResult["status"].ToString() == "1")
            {
                var gps = new Gps();
                var dic = (JArray) urlResult["geocodes"];
                if (dic.Count > 0)
                {                    
                    var jobject = (JObject)dic.First();
                    gps.address = (string) jobject["formatted_address"];
                    gps.province = (string) jobject["province"];
                    gps.city = (string)     jobject["city"];
                    
                    JToken district  = jobject.GetValue("district");
                    if (district != null)
                    {
                        if (district.ToArray().Length > 0 || district.ToString()!="[]")
                        {
                            //"广东省东莞市南城区东莞大道11号台商大厦57楼" 居然无法获得地区;
                            gps.district = (string) jobject["district"];
                        }
                    }
                   if (gps.district==null)
                    {
                        gps.district = gps.city;
                    }
                    var location = ((string) jobject["location"]).Split(new char[] { ',' });
                    gps.Longtitude = Convert.ToDecimal(location[0]);
                    gps.Latitude = Convert.ToDecimal(location[1]);
                }
                return gps;
            }
            return null;
        }

        private static Dictionary<string, Gps> cooperateDictionary = new Dictionary<string, Gps>(); 

        /// <summary>
        /// 根据坐标获得GPS的地理信息 
        /// </summary>
        /// <param name="longitude">坐标经度</param>
        /// <param name="latitude">坐标纬度</param>
        /// <returns></returns>
        public static Gps GetGpsByCoodinate(decimal longitude, decimal latitude)
        {
            try
            {
                var coopirate = longitude.ToString() + "," + latitude.ToString();
                //http://restapi.amap.com/v3/geocode/regeo?key=8726e94e521325daaee5b4738d83bb56&location=116.481488%2C39.990464
                string url = "{0}?location={2}&key={1}";                
                if (!cooperateDictionary.ContainsKey(coopirate))
                {
                    string urlreq = string.Format(url, new string[] { AMAP_REGEO_URL, AMAP_APP_KEY, coopirate });
                    string result = HttpUtil.ReadWeb(urlreq);
                    //System.Web.Script.Serialization.JavaScriptSerializer ser = new System.Web.Script.Serialization.JavaScriptSerializer();
                    var urlResult = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, object>>(result);

                    if (urlResult["status"].ToString() == "1")
                    {
                        /* {"status":"1","info":"OK","infocode":"10000",
                            "regeocode":{"formatted_address":"北京市朝阳区望京街道阜通东大街6号",
                            "addressComponent":{"province":"北京市","city":[],"citycode":"010","district":"朝阳区","adcode":"110105",
                            "township":"望京街道","towncode":"110105026000",
                            "neighborhood":{"name":"方恒国际中心","type":"商务住宅;楼宇;商住两用楼宇"},
                            "building":{"name":"方恒国际中心B座","type":"商务住宅;楼宇;商务写字楼"},
                            "streetNumber":{"street":"阜通东大街","number":"6号","location":"116.481077,39.9904942","direction":"西","distance":"35.1865"},
                        "businessAreas":[{"location":"116.47089234140496,39.9976009239991","name":"望京","id":"110105"}]}}} 
                        */
                        var gps = new Gps();
                        var dic = (JObject) (urlResult["regeocode"]);
                        gps.address = (string) dic["formatted_address"];
                        var addressComponent = (JObject) (dic["addressComponent"]);
                        gps.province = (string) addressComponent["province"];
                        var city = GetValue(addressComponent["city"]);
                        gps.city = city ?? gps.province;

                        if (addressComponent["district"] is JArray)
                        {
                            var district = (JArray)addressComponent["district"];
                            if (district.Count() == 0)
                            {
                                gps.district = gps.city;
                            }
                            else
                            {
                                gps.district = (string)district[0];
                            }
                        }
                        else
                        {
                            gps.district = (string)addressComponent["district"];
                        }
                        // gps.township = (string) addressComponent["township"];
                        gps.Longtitude = longitude;
                        gps.Latitude =  latitude;
                        var building = (JObject) (addressComponent["building"]);
                        /*{ "status":"1","info":"OK","infocode":"10000","regeocode":{ "formatted_address":"安徽省安庆市岳西县巍岭乡三道河","addressComponent":{ "province":"安徽省","city":"安庆市","citycode":"0556","district":"岳西县","adcode":"340828","township":"巍岭乡","towncode":"340828210000","neighborhood":{ "name":[],"type":[]
            },"building":{"name":[],"type":[]
        },"streetNumber":{"street":[],"number":[],"direction":[],"distance":[]},"businessAreas":[[]]}}}*/
                        gps.building = GetValue(building["name"]);
                        gps.buildingType = GetValue(building["type"]);

                        cooperateDictionary[coopirate] = gps;
                        return gps;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return cooperateDictionary[coopirate];
                }                               
            }
            catch
            {
                return null; 
            }
        }
        


        /// <summary>
        /// AMAP的辅助方法，老是有类似这样的结果出现，
        /// 例如 "building":{"name":[],"type":[] }  或者，
        ///  "building":{"name":"方恒国际中心B座","type":"商务住宅;楼宇;商务写字楼"},
        ///  不使用 null , 而使用 空数组； 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private static string GetValue(object obj)
        {
            if (obj is JArray)
            {
                var jry = (JArray)obj;
                if (jry.Count == 0) return null;
                return (string) ((JArray)obj).First();
            }
            else if (obj is ArrayList)
            {
                var objList = (ArrayList)obj;
                if (objList.Count == 0) return null;
                return (string)objList[0];
            }
            else if (obj is string)
            {
                return (string)obj;
            }
            else if (obj is JValue)
            {
                return (string)((JValue)obj).Value;
            }
            return null; 
        }
        
    }

   

   
}
