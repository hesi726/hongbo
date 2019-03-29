#hongbo.sms
hongbo 公司的短信发送平台;

//飞信(已经不可用)
FeisionSmsUtil.SendMsg("15512345678", "1234567890", "15512345679", "你好");

// 云测短信平台
TestinSms sms = new TestinSms("youAppKey", "youAppSecret");  
var contentTemplateId = "135";  
sms.SendSms(contentTemplateId, "15512345678", "你好,Hongbo");  