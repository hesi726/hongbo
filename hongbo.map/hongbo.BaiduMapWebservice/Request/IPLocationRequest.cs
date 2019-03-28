using hongbo.BaiduMapWebservice.Request.Models;
using hongbo.BaiduMapWebservice.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace hongbo.BaiduMapWebservice.Request
{
    public class IPLocationRequest : BaiduRequest<IPLocationResponse, IPModel>
    {
        public IPLocationRequest(IPModel model) : base(model)
        {
            this.Address = "/location/ip";
        }
    }
}
