using com.youzan.open.sdk.api;
using com.youzan.open.sdk.model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using youzan.com.youzan.open.sdk;
using YouZanSdkNetCore.Auth;

namespace youzan
{
    /// <summary>
    /// 有赞的配置定义;
    /// </summary>
    public class YouzanConfig
    {
        /// <summary>
        /// AppId
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// App Secret
        /// </summary>
        public string AppSecret { get; set; }

        /// <summary>
        /// 店铺Id
        /// </summary>
        public string KdtId { get; set; }

        /// <summary>
        /// 有赞的授权令牌;
        /// </summary>

        private YouzanAuthToken autoToken = null;

        /// <summary>
        /// 获取 Token
        /// </summary>
        public Token Token
        {
            get
            {
                if (autoToken == null || autoToken.isExpired) // string.IsNullOrEmpty(_token) || expireTime < DateTime.Now)
                {
                    InitiateToken();
                }
                return new Token(autoToken.access_token);
            }
        }

        /// <summary>
        /// 初始化Token
        /// </summary>
        private void InitiateToken()
        {
            IDictionary<string, string> par = new Dictionary<string, string>
            {
                { "client_id", AppId },
                { "client_secret", AppSecret },
                { "grant_type", "silent" },
                { "kdt_id",  KdtId },
            };
            this.autoToken = FormUrlEncodedPostGetResult<YouzanAuthToken>("https://open.youzan.com/oauth/token", par).Result;
        }


        /// <summary>
        /// 使用本配置 和 参数类访问有赞的接口;
        /// </summary>
        /// <param name="api"></param>
        /// <returns></returns>
        public TResult Invoke<TParam, TResult>(AbstractAPI<TParam,TResult> paramInsstance)
                where TParam : APIParams
        {
            return paramInsstance.Invoke(this);
        }
        /// <summary>
        /// 通过 POST 提交某些内容到服务器，并读取响应结果； 默认下将使用 utf8 编解码；
        /// 注意，content-type 为 application/x-www-form-urlencoded;
        /// 即将 请求参数编码为 client_id=testclient&client_secret=testclientsecret 的形式并 Post
        /// </summary>
        /// <param name="url">提交的url</param>
        /// <param name="postContent">需要提交的内容</param>
        /// <returns></returns>
        private static async Task<T> FormUrlEncodedPostGetResult<T>(string url, IEnumerable<KeyValuePair<string, string>> postContent)
        {
            System.Net.Http.FormUrlEncodedContent content = new System.Net.Http.FormUrlEncodedContent(postContent);
            content.Headers.Add("conent-type", "application/x-www-form-urlencoded");
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            var asyncResult = await client.PostAsync(url, content);
            var result = await asyncResult.Content.ReadAsStringAsync();
            if (string.IsNullOrEmpty(result)) return default(T);
            return JsonConvert.DeserializeObject<T>(result);
        }
    }
}
