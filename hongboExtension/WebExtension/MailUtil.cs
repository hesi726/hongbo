// Decompiled by Jad v1.5.7g. Copyright 2000 Pavel Kouznetsov.
// Jad home page: http://www.geocities.com/SiliconValley/Bridge/8617/jad.html
// Decompiler options: packimports(3) fieldsfirst ansi 
// Source File Name:   DaiMsgSend.java
using System;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using OpenSmtp.Net;

namespace Systemt.Util.WebUtil
{
    /// <summary>
    /// 
    /// </summary>
	public class MailUtil
	{
	
	
	
		/// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
		public static void  main(System.String[] args)
		{
			System.Console.Out.WriteLine("Test Send Email start");
			System.String s = "<font color='red' size='4'><b>Test Java Stored Proc for send email !</b></font>";
			if (SendEmailMessage("superhsk@whadshel.com,daiwei@whadshel.com", "daiwei@whadshel.com", "it is a test", s, "superhsk@whadshel.com,daiwei@whadshel.com", "daiwei@whadshel.com") > 0)
				System.Console.WriteLine("成功发送邮件!");
			else
				System.Console.WriteLine("发送邮件失败!");
		}

        /// <summary>
        /// 
        /// </summary>
		public static void killExcelProgram()
		{
			try 
			{
				foreach (Process a in (Process.GetProcessesByName("EXCEL"))) 
				{
					try { a.Kill(); }
					catch
					{

					}
				}
			}
			catch
			{
			}
		}

        /// <param name="to">收件人地址，多个收件人之间使用 , 间隔</param>
        /// <param name="from">发件人地址</param>
        /// <param name="subject">主题</param>
        /// <param name="body">邮件内容</param>
        /// <param name="cc">抄送人地址，多个收件人之间使用 , 间隔</param>
        /// <param name="bcc">密送人地址，多个收件人之间使用 , 间隔</param>
        /// <param name="attachFiles">附件文件列表</param>
        /// <param name="toName"></param>
        /// <returns>发送成功返回 -1; 发送失败抛出异常</returns>
        public static MailMessage ConstrucEmailMessage(System.String to, System.String from, System.String subject, System.String body, System.String cc, System.String bcc,String[] attachFiles,
            string toName=null)
		{		
			MailMessage msg=new MailMessage();
			msg.From=new EmailAddress(from,from);

            string[] toaddrs = to.Split(new char[] { ',', ';' });
            string[] toNames = null;
            if (toName!=null)  toNames = toName.Split(new char[] { ',', ';' });
            for (int i = 0; i < toaddrs.Length; i++)
            {
                if (toaddrs[i].Length > 0)
                {
                   // var name = toNames != null && toNames.Length > i ? toNames[i] : toaddrs[i];
                   // if (name.IndexOf("@") >= 0) name =  name.Substring(0, name.IndexOf("@"));
                    msg.To.Add(new EmailAddress(toaddrs[i]));
                }
            }
			if (!string.IsNullOrEmpty(cc))
			{
				var ccaddrs = cc.Split(new char[]{',',';'});
                for (int i = 0; i < ccaddrs.Length; i++)
                {
                    var email = ccaddrs[i];
                    if (!string.IsNullOrEmpty(email))
                    {
                        msg.CC.Add(new EmailAddress(email)); // , email.Substring(0, email.IndexOf("@")))
                    }
                }
			}

			if (!string.IsNullOrEmpty(bcc))
            {
				var bccaddrs = bcc.Split(new char[]{',',';'});
                for (int i = 0; i < bccaddrs.Length; i++)
                {
                    var email = bccaddrs[i];
                    if (!string.IsNullOrEmpty(email))
                    {
                        msg.BCC.Add(new EmailAddress(bccaddrs[i]));//  , email.Substring(0, email.IndexOf("@"))
                    }
                }
			}

			msg.Subject = subject;
			msg.HtmlBody =body;			
       			
			if (attachFiles!=null) 
			{
				foreach (String i in attachFiles)
				{
					//File aFile = new File(i);
					msg.AddAttachment(i);
				}
			}		
			return msg;
		}

        /// <summary>
        /// 发送带附件的邮件,注意，将使用默认的 139 邮箱发送；
        /// </summary>
        /// <param name="to">收件人地址，多个收件人之间使用 , 间隔</param>
        /// <param name="subject">主题</param>
        /// <param name="body">邮件内容</param>
        /// <returns>发送成功返回 -1; 发送失败抛出异常</returns>
        public static int SendEmailMessage(System.String to, System.String subject, System.String body)
        {
            MailMessage msg = ConstrucEmailMessage(to, "support@iguest.cc", subject, body, null, null, null);
            return SendEmailMessage(msg);
        }

		/// <summary>
        /// 发送带附件的邮件,注意，将使用默认的 139 邮箱发送；
		/// </summary>
		/// <param name="to">收件人地址，多个收件人之间使用 , 间隔</param>
		/// <param name="from">发件人地址</param>
		/// <param name="subject">主题</param>
		/// <param name="body">邮件内容</param>
		/// <param name="cc">抄送人地址，多个收件人之间使用 , 间隔</param>
		/// <param name="bcc">密送人地址，多个收件人之间使用 , 间隔</param>
		/// <param name="attachFiles">附件文件列表</param>
		/// <returns>发送成功返回 -1; 发送失败抛出异常</returns>
		public static int SendEmailMessage(System.String to, System.String from, System.String subject, System.String body, System.String cc, System.String bcc,String[] attachFiles)
		{
            MailMessage msg = ConstrucEmailMessage(to,from,subject,body,cc,bcc,attachFiles);
			return SendEmailMessage(msg); 
		}

        /// <summary>
        /// 发送带附件的邮件
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="host"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>发送成功返回 -1; 发送失败抛出异常</returns>
        public static int SendEmailMessage(MailMessage msg, string host, string username, string password)
        {
            Smtp smtp = new Smtp { Host = host, Username = username, Password = password };
            smtp.SendMail(msg);
            return -1;
        }

        /// <summary>
        /// 发送带附件的邮件,注意，将使用默认的 139 邮箱发送；
        /// </summary>
        /// <param name="msg"></param>
        /// <returns>发送成功返回 -1; 发送失败抛出异常</returns>
        public static int SendEmailMessage(MailMessage msg)
		{
			Smtp smtp = new Smtp();
			smtp.SendMail(msg);
			return -1; 
		}

		/// <summary>
		/// 发送不带附件的邮件
		/// </summary>
		/// <param name="to">收件人地址，多个收件人之间使用 , 间隔</param>
		/// <param name="from">发件人地址</param>
		/// <param name="subject">主题</param>
		/// <param name="body">邮件内容</param>
		/// <param name="cc">抄送人地址，多个收件人之间使用 , 间隔</param>
		/// <param name="bcc">密送人地址，多个收件人之间使用 , 间隔</param>
		/// <returns>发送成功返回 -1; 发送失败抛出异常</returns>
		public static int SendEmailMessage(System.String to, System.String from, System.String subject, System.String body, System.String cc, System.String bcc)
		{
			return SendEmailMessage(to, from, subject, body, cc, bcc, null); 
		}
	
		
	}
}