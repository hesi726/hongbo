using hongbo.BaiduMapWebservice.Request.Models;
using hongbo.BaiduMapWebservice.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace hongbo.BaiduMapWebservice.Request
{
    /// <summary>
    /// 逆向地理编码查询请求数据
    /// </summary>
    public class ReGeoCoderRequest : BaiduRequest<ReGeoCoderResponse, ReGeoCoderModel>
    {
        public ReGeoCoderRequest(ReGeoCoderModel model) : base(model)
        {
            this.Address = "/geocoder/v2/";
        }
    }
}
