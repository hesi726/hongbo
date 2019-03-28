using hongbo.BaiduMapWebservice.Request.Models;
using hongbo.BaiduMapWebservice.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace hongbo.BaiduMapWebservice.Request
{
    public class PlaceSuggestionRequest : BaiduRequest<PlaceSuggestionResponse, PlaceSuggestionModel>
    {
        public PlaceSuggestionRequest(PlaceSuggestionModel model) : base(model)
        {
            this.Address = "/place/v2/suggestion";
        }
    }
}
