using hongbo.BaiduMapWebservice.Request.Models;
using hongbo.BaiduMapWebservice.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace hongbo.BaiduMapWebservice.Request
{
    public class RidePlanRequest : BaiduRequest<RidePlanResponse, RidePlanModel>
    {
        public RidePlanRequest(RidePlanModel model): base(model)
        {
            this.Address = "/direction/v2/riding";

            this.RequiredTimestamp = true;
        }
    }
}
