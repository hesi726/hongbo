using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace hongbo.CoreMapWebservice.Response
{
    public class AbstractResponse : IResponse
    {
        [JsonIgnore]
        public string Meta { get; set; }
    }
}
