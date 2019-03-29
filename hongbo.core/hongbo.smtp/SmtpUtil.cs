using OpenSmtp.Net;

namespace hongbo.smtp
{

    /******************************************************************************
        Copyright 2001, 2002, 2003 Ian Stallings
        OpenSmtp.Net is free software; you can redistribute it and/or modify
        it under the terms of the Lesser GNU General Public License as published by
        the Free Software Foundation; either version 2 of the License, or
        (at your option) any later version.

        OpenSmtp.Net is distributed in the hope that it will be useful,
        but WITHOUT ANY WARRANTY; without even the implied warranty of
        MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
        Lesser GNU General Public License for more details.

        You should have received a copy of the Lesser GNU General Public License
        along with this program; if not, write to the Free Software
        Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
    /*******************************************************************************/


    /// <summary>
    /// </summary>
    public static class SmtpUtil
    {
        /// <param name="to">�ռ��˵�ַ������ռ���֮��ʹ�� , ���</param>
        /// <param name="from">�����˵�ַ</param>
        /// <param name="subject">����</param>
        /// <param name="body">�ʼ�����</param>
        /// <param name="cc">�����˵�ַ������ռ���֮��ʹ�� , ���</param>
        /// <param name="bcc">�����˵�ַ������ռ���֮��ʹ�� , ���</param>
        /// <param name="attachFiles">�����ļ��б�</param>
        /// <param name="toName"></param>
        /// <returns>���ͳɹ����� -1; ����ʧ���׳��쳣</returns>
        public static MailMessage ConstrucEmailMessage(string to, string from, string subject, string body, string cc = null, string bcc = null, string[] attachFiles = null,
            string toName = null)
        {
            MailMessage msg = new MailMessage();
            msg.From = new EmailAddress(from, from);

            string[] toaddrs = to.Split(new char[] { ',', ';' });
            string[] toNames = null;
            if (toName != null) toNames = toName.Split(new char[] { ',', ';' });
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
                var ccaddrs = cc.Split(new char[] { ',', ';' });
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
                var bccaddrs = bcc.Split(new char[] { ',', ';' });
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
            msg.HtmlBody = body;

            if (attachFiles != null)
            {
                foreach (string i in attachFiles)
                {
                    //File aFile = new File(i);
                    msg.AddAttachment(i);
                }
            }
            return msg;
        }


        /// <summary>
        /// ���ʹ��������ʼ�
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="host"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>���ͳɹ����� -1; ����ʧ���׳��쳣</returns>
        public static int SendEmailMessage(MailMessage msg, string host, string username, string password)
        {
            Smtp smtp = new Smtp(new SmtpConfig { SmtpHost = host, Username = username, Password = password });
            smtp.SendMail(msg);
            return -1;
        }       

       
        /// <summary>Sends a mail message using supplied MailMessage and Smtp properties</summary>
        /// <param name="msg">MailMessage instance</param>
        /// <param name="host">SMTPsmtpConfig.SmtpHostaddress</param>
        /// <param name="port">Port used to connect to host</param>
        /// <example>
        /// <code>
        ///		MailMessage msg = new MailMessage("support@OpenSmtp.com", "recipient@OpenSmtp.com");
        ///		msg.Subject = "Hi";
        ///		msg.Body = "Hello Joe Smith."
        /// 	Smtp smtp = new Smtp();
        ///		smtp.SendMail(msg, "mail.OpenSmtp.com", 25);
        /// </code>
        /// </example>
        public static void SendMail(MailMessage msg, string host, int port = 25)
        {
            var smtp = new Smtp(new SmtpConfig { SmtpHost = host, SmtpPort = port });
            smtp.SendMail(msg);
        }

        /// <summary>Sends a mail message using supplied MailMessage and Smtp properties</summary>
        /// <param name="msg">MailMessage instance</param>
        /// <param name="host">SMTPsmtpConfig.SmtpHostaddress</param>
        /// <param name="port">Port used to connect to host</param>
        /// <example>
        /// <code>
        ///		MailMessage msg = new MailMessage("support@OpenSmtp.com", "recipient@OpenSmtp.com");
        ///		msg.Subject = "Hi";
        ///		msg.Body = "Hello Joe Smith."
        /// 	Smtp smtp = new Smtp();
        ///		smtp.SendMail(msg, "mail.OpenSmtp.com", 25);
        /// </code>
        /// </example>
        public static void SendMail(MailMessage msg, string username, string password, string host, int port = 25)
        {
            var smtp = new Smtp(new SmtpConfig { SmtpHost = host, SmtpPort = port, Username = username, Password = password });
            smtp.SendMail(msg);
        }

    }
}