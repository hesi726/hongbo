using hongbo.AMapWebservice.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace hongbo.AMapWebservice.Response
{
    public abstract class AMapSingleResponse<T> : AMapResponse
    {
        public T Result { get; set; }
    }
}
