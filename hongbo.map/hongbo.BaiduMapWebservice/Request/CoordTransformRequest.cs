using System;
using hongbo.BaiduMapWebservice.Request.Models;
using hongbo.BaiduMapWebservice.Response;

namespace hongbo.BaiduMapWebservice.Request
{
    /// <summary>
    /// 坐标转换查询请求数据
    /// </summary>
    public class CoordTransformRequest : BaiduRequest<CoordTransformResponse, CoordTransfModel>
    {
        public CoordTransformRequest(CoordTransfModel model) : base(model)
        {
            this.Address = "/geoconv/v1/";
        }
    }
}
