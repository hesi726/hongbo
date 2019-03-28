using hongbo.BaiduMapWebservice.Request.Models;
using hongbo.BaiduMapWebservice.Response;
using hongbo.CoreMapWebservice.Request;

namespace hongbo.BaiduMapWebservice.Request
{
    public abstract class BaiduRequest<TResponse, TRequestModel> : AbstractRequest<TResponse, TRequestModel>, 
        IBaiduRequest<TResponse>
        where TResponse: BaiduResponse 
        where TRequestModel: BaiduModel
    {
        public BaiduRequest(): base()
        {
            this.Host = "http://api.map.baidu.com";
        }
        public BaiduRequest(TRequestModel model): this()
        {
            this.model = model;
        }

       
       

        //public bool RequiredTimestamp { get; protected set; } = false;

        

      

    }
}
