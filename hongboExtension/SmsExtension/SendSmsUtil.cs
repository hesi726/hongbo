using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using hongbao.SecurityExtension;
using Systemt.Util.WebUtil;
using hongbao.WebExtension;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
//using Systemt.Util.WebUtil;

namespace hongbao.SmsExtension
{
    /// <summary>
    /// 发送短信的工具类;使用云测进行短信的发送;注意，需要在 config 文件中定义如下的几个类；
    /// 试用 云测 短信平台；
    /// smsApiKey  -- API KEY
    /// smsSecretKey - 用于加密的KEY；
    /// smsTemplateId -- 消息模板ID； 
    /// </summary>
    public class SendSmsUtil
    {
        private static string ApiKey = null;
        private static string SecretKey = null;
        private static string TemplateId = null; 
        private static string OP = "Sms.send";
        static SendSmsUtil()
        {
            ApiKey = System.Configuration.ConfigurationManager.AppSettings["smsApiKey"];
            SecretKey = System.Configuration.ConfigurationManager.AppSettings["smsSecretKey"];
            TemplateId = System.Configuration.ConfigurationManager.AppSettings["smsTemplateId"];
        }

        /// <summary>
        /// 计算短信 json 字符串的 MD5 码；只用于测试； 
        /// </summary>
        /// <returns></returns>
        public static string ComputeSig(string apikey, string templateid, string secretKey, string mobile, string content, long ts)
        {
             string contentForMd5 = string.Format("apiKey={0}content={1}op={2}phone={3}templateId={4}ts={5}{6}", new object[] {
                apikey, content, OP, mobile, templateid, ts.ToString(), secretKey
            });
            return SecurityUtil.PhpMD5(contentForMd5);
        }

        /// <summary>
        /// 计算短信 json 字符串的 MD5 码；此方法私有方法，无需测试； 
        /// </summary>
        /// <returns></returns>
        private static string ComputeSig(string mobile,string content,  long ts)
        {
            return ComputeSig(ApiKey, TemplateId, SecretKey, mobile, content, ts);
            /*
            string contentForMd5 = string.Format("apiKey={0}content={1}op={2}phone={3}templateId={4}ts={5}{6}", new object[] {
                ApiKey, content, OP, mobile, TemplateId, ts.ToString(), SecretKey 
            });
            //string testContent = "apiKey=00a5418a573a53c713831735ead24006content=Hello,你好,World，世界op=Sms.sendphone=18122449326templateId=1033ts=14429147759354F3B9E90EDE54E98";
            return SecurityUtil.PhpMD5(contentForMd5);
            */
        }

        /// <summary>
        /// 发送短信
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="sendContent"></param>
        /// <returns></returns>
        public static bool SendSms(string mobile, string sendContent)
        {
            long nowTs = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;  //DateTime.Now.Ticks / 10000;
            string contentSig = SendSmsUtil.ComputeSig(mobile, sendContent, nowTs);
            var jsonContent = JsonConvert.SerializeObject(new
            {
                op = OP,
                apiKey = ApiKey,
                ts = nowTs,
                phone = mobile,
                templateId = TemplateId,
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
