﻿using System;
using hongbo.CoreMapWebservice;
using hongbo.CoreMapWebservice.Attributes;

namespace hongbo.BaiduMapWebservice.Request.Models
{
    public class PlaceRegionModel: PlaceModel
    {
        [Required]
        public string Region { get; set; }
        public string City_Limit { get; set; }
    }
}
