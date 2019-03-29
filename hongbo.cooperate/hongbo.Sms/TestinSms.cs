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
    /// �Ʋ� ����ƽ̨ ���Ͷ��ŵĹ�����;ʹ���Ʋ���ж��ŵķ���;ע�⣬��Ҫ�� config �ļ��ж������µļ����ࣻ
    /// </summary>
    public class TestinSms
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="apiKey"> API KEY</param>
        /// <param name="secretKey">���ڼ��ܵ�KEY</param>
        public TestinSms(string apiKey, string secretKey)
        {
            this.ApiKey = apiKey;
            this.SecretKey = secretKey;
        }
        /// <summary>
        /// �Ʋ��ApiKey
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// �Ʋ��  ���ڼ��ܵ�KEY��
        /// </summary>
        public string SecretKey { get; set; }

        /// <summary>
        /// ���Ͷ��ţ��̶�
        /// </summary>

        public const string SMS_SEND = "Sms.send";


        /// <summary>
        /// ������� json �ַ����� MD5 �룻ֻ���ڲ��ԣ� 
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
        /// ���Ͷ���
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
