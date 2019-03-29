using hongbao.WebExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace hongbao.Sms
{
    
    /// <summary>
    /// 使用飞信发送短讯的类
    /// </summary>
    public class FeisionSmsUtil
    {
        /// <summary>
        /// 发送短讯给某一个手机号码,
        /// 走飞信的接口，所以接受手机号码必须在本人联系人列表里面； 
        /// 飞信已经不可用； 
        /// </summary>
        /// <param name="sjhm"></param>
        /// <param name="content"></param>
        public static void SendMsg(string from, string password,  string to, string content)
        {
            var url = $"https://quanapi.sinaapp.com/fetion.php?u={from }&p={password}&to={to}&m={content}";
            var result = HttpUtil.ReadWeb(url);

        }
    }
}
