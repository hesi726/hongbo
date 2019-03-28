using System;
using hongbo.CoreMapWebservice;
using hongbo.CoreMapWebservice.Attributes;

namespace hongbo.BaiduMapWebservice.Request.Models
{
    public class PlaceRectangeModel: PlaceModel
    {
        [Required]
        public string Bounds { get; set; }
    }
}
