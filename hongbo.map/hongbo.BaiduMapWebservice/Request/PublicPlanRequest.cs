using hongbo.BaiduMapWebservice.Request.Models;
using hongbo.BaiduMapWebservice.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace hongbo.BaiduMapWebservice.Request
{
    public class PublicPlanRequest : BaiduRequest<PublicPlanResponse, PublicPlanModel>
    {
        public PublicPlanRequest(PublicPlanModel model) : base(model)
        {
            this.Address = "/direction/v2/transit";

            this.RequiredTimestamp = true;
        }

    }
}
