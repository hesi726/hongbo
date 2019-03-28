using System;
using hongbo.CoreMapWebservice;
using hongbo.CoreMapWebservice.Attributes;

namespace hongbo.BaiduMapWebservice.Request.Models
{
    public class PlaceCircumModel : PlaceModel
    {
        
        [Required]
        public string Location { get; set; }
        public string Radius { get; set; }
        public string Radius_Limit { get; set; }

    }
}
