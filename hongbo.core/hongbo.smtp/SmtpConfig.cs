namespace OpenSmtp.Net
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


using System;
using System.IO;

	/// <summary>
	/// This type stores configuration information for the smtp component.
	/// WARNING: If you turn on logging the caller must have proper permissions
	/// and the log file will grow very quickly if a lot of email messages are 
	/// being sent. PLEASE USE THE LOGGING FEATURE FOR DEBUGGING ONLY.
	/// </summary>
	public class SmtpConfig
	{

        /// <summary>
        /// 当前线程中发送邮件所使用的 SMTP 配置类;
        /// </summary>
        [ThreadStatic]
        public static SmtpConfig Current;

		public SmtpConfig()
		{}
		
		///<value>Stores the default SMTP host</value>
		public string SmtpHost { get; set; } = "localhost";

		///<value>Stores the default SMTP port</value>
		public int 		SmtpPort { get; set; } = 25;

        /// <summary>
        /// 当邮箱需要认证时，认证用户名称;
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// 当邮箱需要认证时，认证用户密码;
        /// </summary>
        public string Password { get; set; }

        ///<value>Flag used to turn piplelining on and off. See RFC 2920 for more info</value>
        public bool		EnablePipelining { get; set; } = false;

		///<value>Flag used for turning on and off logging to a text file.
		/// The caller must have proper permissions for this to work</value>
		public bool LogToText { get; set; } = false;

		///<value>Path to use when logging to a text file. 
		/// The caller must have proper permissions for this to work</value>
		public string LogPath { get; set; } = @"../logs/SmtpLog.txt";

		public long LogMaxSize { get; set; } = 1048576; // one meg
		
		///<value>Path used to store temp files used when sending email messages.
		/// The default value is the temp directory specified in the Environment variables.</value>
		public string TempPath { get; set; } = Path.GetTempPath();
		
		///<value>Flag used to turn on and off address format verification.
		/// If it is turned on all addresses must meet RFC 822 format.
		/// The default value is false.
		/// WARNING: Turning this on will decrease performance.</value>
		public bool VerifyAddresses { get; set; } = false;
		
		///<value>Version of this OpenSmtp SMTP .Net component</value>
		//public static readonly string Version		= "OpenSmtp.net version 01.09.6";
		public string Version { get; set; } = "hongbo daiwei 1.00";
		
		///<value>Mailer header added to each message sent</value>
		//internal static string 	X_MAILER_HEADER		= "X-Mailer: OpenSmtp.net";
		internal string X_MAILER_HEADER { get; set; } = "X-Mailer: hxtt.net";

        /// <value>Stores send timeout for the connection to the SMTP server in milliseconds.
		/// The default value is 10000 milliseconds.</value>
		public int SendTimeout { get; set; }  = 50000;

        /// <value>Stores send timeout for the connection to the SMTP server in milliseconds.
        /// The default value is 10000 milliseconds.</value>
        public int RecieveTimeout { get; set; } = 50000;

        /// <value>Stores send timeout for the connection to the SMTP server in milliseconds.
		/// The default value is 10000 milliseconds.</value>
		public int ReceiveBufferSize { get; set; } = 1024;

        /// <value>Stores send timeout for the connection to the SMTP server in milliseconds.
        /// The default value is 10000 milliseconds.</value>
        public int SendBufferSize { get; set; } = 1024;


    }
}