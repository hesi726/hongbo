using hongbo.BaiduMapWebservice.Request.Models;
using hongbo.BaiduMapWebservice.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace hongbo.BaiduMapWebservice.Request
{
    /// <summary>
    /// 地理编码查询请求数据
    /// </summary>
    public class GeoCoderRequest : BaiduRequest<GeoCoderResponse, GeoCoderModel>
    {
        public GeoCoderRequest(GeoCoderModel model) : base(model)
        {
            this.Address = "/geocoder/v2/";
        }
    }
}
