﻿using hongbo.BaiduMapWebservice.Request.Models;
using hongbo.BaiduMapWebservice.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace hongbo.BaiduMapWebservice.Request
{
    /// <summary>
    /// 地点详情检索请求数据
    /// </summary>
    public class PlaceDetailRequest : BaiduRequest<PlaceDetailResponse, PlaceDetailModel>
    {
        public PlaceDetailRequest(PlaceDetailModel model) : base(model)
        {
            this.Address = "/place/v2/detail";
        }
    }
}
