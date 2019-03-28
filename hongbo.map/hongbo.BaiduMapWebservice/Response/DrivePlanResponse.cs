using hongbo.BaiduMapWebservice.Response.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace hongbo.BaiduMapWebservice.Response
{
    public class DrivePlanResponse: BaiduSingleResponse<DrivePlanItem>
    {
        public string Type { get; set; }
    }
}
