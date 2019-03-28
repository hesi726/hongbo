using hongbao.WebExtension;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace hongbao.SystemExtension
{
    /// <summary>
    /// 天气信息获取类； 
    /// </summary>
    public class Weather
    {
        /// <summary>
        /// 获取城市天气信息
        /// 利用百度的天气接口，
        /// {"error":0,"status":"success","date":"2016-05-26","results":[{"currentCity":"广州","pm25":"54","index":[{"title":"穿衣","zs":"炎热","tipt":"穿衣指数","des":"天气炎热，建议着短衫、短裙、短裤、薄型T恤衫等清凉夏季服装。"},{"title":"洗车","zs":"不宜","tipt":"洗车指数","des":"不宜洗车，未来24小时内有雨，如果在此期间洗车，雨水和路上的泥水可能会再次弄脏您的爱车。"},{"title":"旅游","zs":"一般","tipt":"旅游指数","des":"天气较热，有微风，但较强降雨的天气将给您的出行带来很多的不便，若坚持旅行建议带上雨具。"},{"title":"感冒","zs":"少发","tipt":"感冒指数","des":"各项气象条件适宜，发生感冒机率较低。但请避免长期处于空调房间中，以防感冒。"},{"title":"运动","zs":"较不宜","tipt":"运动指数","des":"有较强降水，建议您选择在室内进行健身休闲运动。"},{"title":"紫外线强度","zs":"弱","tipt":"紫外线强度指数","des":"紫外线强度较弱，建议出门前涂擦SPF在12-15之间、PA+的防晒护肤品。"}],"weather_data":[{"date":"周四 05月26日 (实时：29℃)","dayPictureUrl":"http://api.map.baidu.com/images/weather/day/zhongyu.png","nightPictureUrl":"http://api.map.baidu.com/images/weather/night/zhongyu.png","weather":"小到中雨","wind":"微风","temperature":"33 ~ 24℃"},{"date":"周五","dayPictureUrl":"http://api.map.baidu.com/images/weather/day/dayu.png","nightPictureUrl":"http://api.map.baidu.com/images/weather/night/dayu.png","weather":"中到大雨","wind":"微风","temperature":"29 ~ 24℃"},{"date":"周六","dayPictureUrl":"http://api.map.baidu.com/images/weather/day/zhongyu.png","nightPictureUrl":"http://api.map.baidu.com/images/weather/night/zhongyu.png","weather":"小到中雨","wind":"微风","temperature":"29 ~ 24℃"},{"date":"周日","dayPictureUrl":"http://api.map.baidu.com/images/weather/day/zhenyu.png","nightPictureUrl":"http://api.map.baidu.com/images/weather/night/zhenyu.png","weather":"阵雨","wind":"微风","temperature":"31 ~ 26℃"}]}]}
        /// </summary>
        public WeatherData Query(string csm)
        {
            string format = String.Format("http://api.map.baidu.com/telematics/v3/weather?location={0}&output=json&ak=HOWbIMZV6T1EecW3nhscXPFwo529AvZ6",
                   HttpUtility.UrlEncode(csm));
            var result = HttpUtil.ReadWeb(format, Encoding.UTF8);
            var json = Newtonsoft.Json.JsonConvert.DeserializeObject<WeatherResult>(result);
            if (json.error == 0) return json.results[0];
            return null;
        }

    }

    /// <summary>
    /// 天气结果;
    /// </summary>
    public class WeatherResult
    {
        /// <summary>
        /// 错误代码， 0-表示成功
        /// </summary>
        public int error { get; set; }

        /// <summary>
        /// 状态值
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        public string date { get; set; }

        /// <summary>
        /// 天气结果;
        /// </summary>
        public List<WeatherData> results { get; set; }

    }

    /// <summary>
    /// 天气数据
    /// </summary>
    public class WeatherData
    {
        /// <summary>
        /// 城市
        /// </summary>
        public string currentCity { get; set; }

        /// <summary>
        /// pm25
        /// </summary>
        public string pm25 { get; set; }

        /// <summary>
        /// 天气指数列表，运动指数、穿衣指数等等;
        /// </summary>
        public List<WeatherTips> index { get; set; }

        /// <summary>
        /// 天气信息;当日以及未来几日的天气预报;
        /// </summary>
        public List<WeatherInfo> weather_data { get; set; }
    }
    /// <summary>
    /// 天气指数类
    /// </summary>
    public class WeatherTips
    {
        

        /// <summary>
        /// 洗车指数、运动指数等等
        /// </summary>
        public string tipt { get; set; }

        /// <summary>
        /// 洗车、运动
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 指数的值;
        /// </summary>
        public string zs { get; set; }

        /// <summary>
        /// 指数值的解释， 天气热，建议着短裙、短裤、短薄外套、T恤等夏季服装。"
        /// </summary>
        public string des { get; set; }

    }

    /// <summary>
    /// 天气信息； 
    /// </summary>
    public class WeatherInfo
    {
        /// <summary>
        /// 日期说明, "周三 09月12日 (实时：33℃)" 
        /// </summary>
        public string date { get; set; }

        /// <summary>
        /// 晚上温度的图片
        /// </summary>
        public string nightPictureUrl { get; set;  }

        /// <summary>
        /// 白天温度的图片
        /// </summary>
        public string dayPictureUrl { get; set; }

        /// <summary>
        /// 天气； 雷阵雨转中雨
        /// </summary>
        public string  weather { get; set;  }

        /// <summary>
        /// 风速和风向；东北风3-4级"
        /// </summary>
        public string wind { get; set;  }

        /// <summary>
        /// 温度, 33 ~ 25℃
        /// </summary>
        public string temperature { get; set; }


    }
}
