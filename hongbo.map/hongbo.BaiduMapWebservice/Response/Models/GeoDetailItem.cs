﻿using System;
using System.Collections.Generic;
using System.Text;

namespace hongbo.BaiduMapWebservice.Response.Models
{
    public class GeoDetailItem
    {
        public Location Location { get; set; }
        public int Precise { get; set; }
        public int Confidence { get; set; }
        public string Level { get; set; }
    }
}
