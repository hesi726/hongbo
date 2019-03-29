using hongbao.SecurityExtension;
using hongbao.WebExtension;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
//using Systemt.Util.WebUtil;

namespace hongbao.Sms.Utils
{
    /// <summary>
    /// 云测 短信平台 发送短信的工具类;使用云测进行短信的发送;注意，需要在 config 文件中定义如下的几个类；
    /// </summary>
    public class TestinSms
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="apiKey"> API KEY</param>
        /// <param name="secretKey">用于加密的KEY</param>
        public TestinSms(string apiKey, string secretKey)
        {
            this.ApiKey = apiKey;
            this.SecretKey = secretKey;
        }
        /// <summary>
        /// 云测的ApiKey
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// 云测的  用于加密的KEY；
        /// </summary>
        public string SecretKey { get; set; }

        /// <summary>
        /// 发送短信，固定
        /// </summary>

        public const string SMS_SEND = "Sms.send";


        /// <summary>
        /// 计算短信 json 字符串的 MD5 码；只用于测试； 
        /// </summary>
        /// <returns></returns>
        private string ComputeSig(string templateid, string mobile, string content, long ts)
        {
            string contentForMd5 = string.Format("apiKey={0}content={1}op={2}phone={3}templateId={4}ts={5}{6}", new object[] {
                ApiKey, content, SMS_SEND, mobile, templateid, ts.ToString(), SecretKey
            });
            return SecurityUtil.PhpMD5(contentForMd5);
        }

        /// <summary>
        /// 发送短信
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="sendContent"></param>
        /// <returns></returns>
        public bool SendSms(string contentTemplateId, string mobile, string sendContent)
        {
            long nowTs = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;  //DateTime.Now.Ticks / 10000;
            string contentSig = ComputeSig(contentTemplateId, mobile, sendContent, nowTs);
            var jsonContent = JsonConvert.SerializeObject(new
            {
                op = SMS_SEND,
                apiKey = ApiKey,
                ts = nowTs,
                phone = mobile,
                templateId = contentTemplateId,
                content = sendContent,
                sig = contentSig
            });
            var retString = HttpUtil.PostRawDataAndGetResult("http://api.sms.testin.cn/sms", jsonContent);
            var result = JsonConvert.DeserializeObject(retString) as JObject;
            var resultCode = (int)(result["code"].Value<int>());

            return resultCode == 1000;
        }

    }
}
