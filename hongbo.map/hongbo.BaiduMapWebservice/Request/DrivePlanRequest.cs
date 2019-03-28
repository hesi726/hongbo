using hongbo.BaiduMapWebservice.Request.Models;
using hongbo.BaiduMapWebservice.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace hongbo.BaiduMapWebservice.Request
{
    public class DrivePlanRequest : BaiduRequest<DrivePlanResponse, DrivePlanModel>
    {
        public DrivePlanRequest(DrivePlanModel model): base(model)
        {
            this.Address = "/direction/v2/driving";

            this.RequiredTimestamp = true;
        }
    }
}
