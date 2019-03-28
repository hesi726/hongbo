using System;
using System.Collections.Generic;
using hongbo.BaiduMapWebservice.Request.Models;
using hongbo.BaiduMapWebservice.Response.Place;
using hongbo.BaiduMapWebservice.Utils;

namespace hongbo.BaiduMapWebservice.Request
{
    /// <summary>
    /// 地点区域检索请求数据
    /// </summary>
    public class PlaceSearchRequest<T> : BaiduRequest<PlaceSearchResponse, T> where T : PlaceModel
    {
        public PlaceSearchRequest(T placeModel) : base(placeModel)
        {
            this.Address = "/place/v2/search";
        }
    }
}
