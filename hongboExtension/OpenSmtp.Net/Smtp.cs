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
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading;
    using System.Collections;
    using System.Data;
    using System.Configuration;
    using System.Collections.Generic;
    /// <summary>
    /// This Type sends a MailMessage using SMTP
    /// <seealso cref="EmailAddress"/>
    /// <seealso cref="MailMessage"/>
    /// <seealso cref="SmtpConfig"/>
    /// </summary>
    /// <example>
    /// <code>
    ///		from = new EmailAddress("support@OpenSmtp.com", "Support");
    ///		to = new EmailAddress("recipient@OpenSmtp.com", "Joe Smith");
    ///
    ///		msg = new MailMessage(from, to);
    ///		msg.Subject = "Testing OpenSmtp .Net SMTP component";
    ///		msg.Body = "Hello Joe Smith.";
    /// 
    ///		Smtp smtp = new Smtp("localhost", 25);
    ///		smtp.SendMail(msg);
    /// </code>
    /// </example>
    public class Smtp
	{
		internal TcpClient 	tcpc;
		internal string 	host     =  "smtp.iguest.cc";// "smtp.139.com"; //mail.whadshel.com";
		internal int 		port     = 25;
		internal string 	username =  "support@iguest.cc";//"13610239726@139.com"; //"symail@whadshel.com";
		private  string 	password =  "Daizhao1234"; // "daizhao1234";//12it#$";

		internal int 		sendTimeout = 50000;
		internal int 		recieveTimeout = 50000;
		internal int 		receiveBufferSize = 1024;
		internal int 		sendBufferSize = 1024;
		
        /// <summary>
        /// 
        /// </summary>
        public void initiateSmtp()
        {
            if (ConfigurationManager.AppSettings["smtp_server"] != null)
                host = ConfigurationManager.AppSettings["smtp_server"];
            if (ConfigurationManager.AppSettings["smtp_username"] != null)
                username = ConfigurationManager.AppSettings["smtp_username"];
            if (ConfigurationManager.AppSettings["smtp_password"] != null)
                password = ConfigurationManager.AppSettings["smtp_password"];
        }
		/// <summary>Default constructor</summary>
		/// <example>
		/// <code>
		/// 	Smtp smtp = new Smtp();
		/// 	smtp.Host = "mail.OpenSmtp.com";
		/// 	smtp.Port = 25;
		/// </code>
		/// </example>
		public Smtp()
		{
            initiateSmtp();
        }
		
		
		/// <summary>Finalizer</summary>
		~Smtp()
		{}
        

        /// <summary>Constructor specifying a host and port</summary>
        /// <example>
        /// <code>
        /// 	Smtp smtp = new Smtp("mail.OpenSmtp.com", 25);
        /// </code>
        /// </example>
        public Smtp(string host, int port) 
		{
			this.host = host;
			this.port = port;
		}

		//========================================================================
		// PROPERTIES
		//========================================================================

		/// <value>Stores the Host address SMTP server. The default value is "localhost"</value>
		/// <example>"mail.OpenSmtp.com"</example>
		public string Host
		{
			get { return(this.host); }
			set { this.host = value; }
		}		

		/// <value>Stores the Port of the host SMTP server. The default value is port 25</value>
		public int Port
		{
			get { return(this.port); }
			set { this.port = value; }
		}
		
		/// <value>Stores send timeout for the connection to the SMTP server in milliseconds.
		/// The default value is 10000 milliseconds.</value>
		public int SendTimeout
		{
			get { return this.sendTimeout; }
			set { sendTimeout = value; }
		}

		/// <value>Stores send timeout for the connection to the SMTP server in milliseconds.
		/// The default value is 10000 milliseconds.</value>
		public int RecieveTimeout
		{
			get { return this.recieveTimeout; }
			set { recieveTimeout = value; }
		}

		/// <value>Stores the username used to authenticate on the SMTP server.
		/// If no authentication is needed leave this value blank.</value>
		public string Username
		{
			get { return this.username; }
			set { username = value; }
		}

		/// <value>Stores the password used to authenticate on the SMTP server.
		/// If no authentication is needed leave this value blank.</value>
		public string Password
		{
			//			get { return this.password; }
			set { password = value; }
		}

		//========================================================================
		// EVENTS
		//========================================================================
		
		/// <value>Event that fires when connected with target SMTP server.</value>
		public event EventHandler Connected;
		
		/// <value>Event that fires when dicconnected with target SMTP server.</value>
		public event EventHandler Disconnected;
		
		/// <value>Event that fires when authentication is successful.</value>
		public event EventHandler Authenticated;
		
		/// <value>Event that fires when message transfer has begun.</value>
		public event EventHandler StartedMessageTransfer;
		
		/// <value>Event that fires when message transfer has ended.</value>
		public event EventHandler EndedMessageTransfer;
		
		internal void OnConnect(EventArgs e)
		{
			if (Connected != null)
				Connected(this, e);
		}

		internal void OnDisconnect(EventArgs e)
		{
			if (Disconnected != null)
				Disconnected(this, e);
		}
				
		internal void OnAuthenticated(EventArgs e)
		{
			if (Authenticated != null)
				Authenticated(this, e);
		}

		internal void OnStartedMessageTransfer(EventArgs e)
		{
			if (StartedMessageTransfer != null)
				StartedMessageTransfer(this, e);
		}
		
		internal void OnEndedMessageTransfer(EventArgs e)
		{
			if (EndedMessageTransfer != null)
				EndedMessageTransfer(this, e);
		}

		//========================================================================
		// METHODS
		//========================================================================
		
		/// <summary>Sends a mail message using supplied MailMessage properties as string params</summary>
		/// <param name="from">RFC 822 formatted email sender address</param>
		/// <param name="to">RFC 822 formatted email recipient address</param>
		/// <param name="subject">Subject of the email message</param>
		/// <param name="body">Text body of the email message</param>
		/// <example>
		/// <code>
		/// 	Smtp smtp = new Smtp("mail.OpenSmtp.com", 25);
		///		smtp.SendMail("support@OpenSmtp.com", "recipient@OpenSmtp.com", "Hi", "Hello Joe Smith");
		/// </code>
		/// </example>
		public void SendMail(string from, string to, string subject, string body)
		{
            if (string.IsNullOrEmpty(from)) from = username; 
			MailMessage msg = new MailMessage(from, to); 
			msg.subject = subject;
			msg.HtmlBody = body;
			
			SendMail(msg);
		}
		
		/// <summary>Sends a mail message using supplied MailMessage and Smtp properties</summary>
		/// <param name="msg">MailMessage instance</param>
		/// <param name="host">SMTP host address</param>
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
		public void SendMail(MailMessage msg, string host, int port)
		{
			this.host = host;
			this.port = port;
			SendMail(msg);
		}
		

		/// <summary>Sends a mail message using supplied MailMessage</summary>
		/// <param name="msg">MailMessage instance</param>
		/// <example>
		/// <code>
		///		MailMessage msg = new MailMessage("support@OpenSmtp.com", "recipient@OpenSmtp.com");
		///		msg.Subject = "Hi";
		///		msg.Body = "Hello Joe Smith."
		/// 	Smtp smtp = new Smtp("mail.OpenSmtp.com", 25);
		///		smtp.SendMail(msg);
		/// </code>
		/// </example>
		public void SendMail(MailMessage msg)
		{
			if (SmtpConfig.EnablePipelining) 
			{ 
				SendMailPipeline(msg); 
			}
			else
			{
				NetworkStream nwstream = GetConnection();
				CheckForError(ReadFromStream(ref nwstream), ReplyConstants.HELO_REPLY);

				WriteToStream(ref nwstream, "HELO " + host + "\r\n");
				CheckForError(ReadFromStream(ref nwstream), ReplyConstants.OK);

				// Authentication is used if the u/p are supplied
				AuthLogin(ref nwstream);

				WriteToStream(ref nwstream, "MAIL FROM: <" + msg.from.address + ">\r\n");
				CheckForError(ReadFromStream(ref nwstream), ReplyConstants.OK);

				SendRecipientList(ref nwstream, msg.recipientList);
				SendRecipientList(ref nwstream, msg.ccList);
				SendRecipientList(ref nwstream, msg.bccList);

				WriteToStream(ref nwstream, "DATA\r\n");
				CheckForError(ReadFromStream(ref nwstream), ReplyConstants.START_INPUT);


				OnStartedMessageTransfer(EventArgs.Empty);
				WriteToStream(ref nwstream, msg.ToString() + "\r\n.\r\n");
				CheckForError(ReadFromStream(ref nwstream), ReplyConstants.OK);
				OnEndedMessageTransfer(EventArgs.Empty);

				WriteToStream(ref nwstream, "QUIT\r\n");
				CheckForError(ReadFromStream(ref nwstream), ReplyConstants.QUIT);

				CloseConnection();
			}
		}

		/*public static string  saveMessage(System.Web.UI.Page page,MailMessage msg,string pk,string zt,string type)//PK值为sqh,hth之类,方便查询,zt 为当前状态,type为邮件类型
		{
			string bfid = "";
			string mailcc  = "";
			string mailbcc ="";
			string mailto  ="";
			string wjdz="";
			string strbody ="";
			string htmlbody ="";
			if(msg.body!=null&&msg.body!="") strbody =msg.body;

			string mailsender=page.Session["user_id"].ToString();
			string fromemail=PublicClass.getDs("413",new string[]{"人员ID",mailsender}).Tables[0].Rows[0][0].ToString();

			for (int i=0;i<msg.To.Count;i++)
			{
				mailto += msg.To[i]+",";
			}
			for (int i=0;i<msg.ccList.Count;i++)
			{
				mailcc += msg.ccList[i]+",";
			}
			for (int i=0;i<msg.bccList.Count;i++)
			{
				mailbcc += msg.bccList[i]+",";
			}
			if(msg.htmlBody!=null&&msg.htmlBody!="")
			{
				wjdz =saveMailtxt(msg.HtmlBody,pk);
				htmlbody = msg.HtmlBody;
			}
			DataTable bfdt = crm.csp.executeAssignQuery("1244",new string []{"pk",pk,"zt",zt,"body",htmlbody,"user",page.Session["user_id"].ToString(),"mailto",mailto,"mailfrom",fromemail,"mailcc",mailcc,"mailbcc",mailbcc,"yjlx",type,"wjdz",wjdz,"subject",msg.subject.ToString(),"strbody",strbody});
			if(bfdt.Rows.Count==1) bfid = bfdt.Rows[0][0].ToString();
			return bfid;
		}*/

            /// <summary>
            /// 
            /// </summary>
            /// <param name="msg"></param>
            /// <param name="pk"></param>
            /// <returns></returns>
		static public string  saveMailtxt(string msg,string pk)
		{
			try
			{
				string path = @"c:\mailsend\"+DateTime.Now.Month.ToString();
				//string sqh  = Request.QueryString["sqid"].ToString();

				if(!System.IO.Directory.Exists(path))
				{
					System.IO.Directory.CreateDirectory(path);
				}
				//			string path=@"c:\maillog\"+DateTime.Today.ToString("yyyy-MM-dd")+".txt";
				path=@"c:\mailsend\"+DateTime.Now.Month.ToString()+@"\"+pk+";"+DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")+".txt";
				StreamWriter sw = new StreamWriter(path, true);
				sw.Write(msg+"\r\n");
				sw.Close();
				return path;
			}
			catch(System.Exception ee)
			{
				string xx=ee.Message;
				return "无HTML文件保存";
			}
		}
		
		private void SendMailPipeline(MailMessage msg)
		{
			NetworkStream nwstream = GetConnection();
			CheckForError(ReadFromStream(ref nwstream), ReplyConstants.HELO_REPLY);

			WriteToStream(ref nwstream, "EHLO " + host + "\r\n");
			string serverResponse = ReadFromStream(ref nwstream);
			CheckForError(serverResponse, ReplyConstants.PIPELINING);
			CheckForError(serverResponse, ReplyConstants.OK);
			
			// Authentication is used if the u/p are supplied
			AuthLogin(ref nwstream);

			WriteToStream(ref nwstream, "MAIL FROM: <" + msg.from.address + ">\r\n");
			SendRecipientList(ref nwstream, msg.recipientList);
			SendRecipientList(ref nwstream, msg.ccList);
			SendRecipientList(ref nwstream, msg.bccList);
			CheckForError(ReadFromStream(ref nwstream), ReplyConstants.OK);

			WriteToStream(ref nwstream, "DATA\r\n");
			nwstream.Flush();
			CheckForError(ReadFromStream(ref nwstream), ReplyConstants.START_INPUT);

			OnStartedMessageTransfer(EventArgs.Empty);
			
			WriteToStream(ref nwstream, msg.ToString() + "\r\n.\r\n");
			WriteToStream(ref nwstream, "QUIT\r\n");
			CheckForError(ReadFromStream(ref nwstream), ReplyConstants.OK);
			CheckForError(ReadFromStream(ref nwstream), ReplyConstants.QUIT);
			
			OnEndedMessageTransfer(EventArgs.Empty);
			CloseConnection();
		}
		
		/// <summary>Resets the Smtp instance to it's defaut values</summary>
		/// <example>
		/// <code>
		/// 	Smtp smtp = new Smtp("mail.OpenSmtp.com", 25);
		///		smtp.Reset();
		/// </code>
		/// </example>
		public void Reset()
		{
			host 	 = null;
			port	 = 25;
			username = null;
			password = null;
			
			CloseConnection();
		}
		
		
		// --------------- Helper methods ------------------------------------

		private NetworkStream GetConnection()
		{
			tcpc = new TcpClient();

			try
			{
				if (host == null)
				{ host = SmtpConfig.SmtpHost; }

				if (port == 0)
				{ port = SmtpConfig.SmtpPort; }

				if (host != null && port != 0)
				{
					tcpc.Connect(host, port);
					LogMessage("connecting to:" + host + ":" + port, ""); 
					tcpc.ReceiveTimeout= recieveTimeout;
					tcpc.SendTimeout = sendTimeout;
					tcpc.ReceiveBufferSize = receiveBufferSize;
					tcpc.SendBufferSize = sendBufferSize;

					LingerOption lingerOption = new LingerOption(true, 10);
					tcpc.LingerState = lingerOption;
				}
				else
				{
					throw new SmtpException("Cannot use SendMail() method without specifying target host and port");
				}
			}
			catch(SocketException e)
			{
				throw new SmtpException("Cannot connect to specified smtp host(" + host + ":" + port + ").", e);
			}

			OnConnect(EventArgs.Empty);
			return tcpc.GetStream(); 
		}
		
		
		private void CloseConnection()
		{
			// add delimeter to log file
			LogMessage("------------------------------------------------------\r\n", "");
			
			// fire disconnect event
			OnDisconnect(EventArgs.Empty);
			
			// destroy tcp connection if it hasn't already closed
			if (tcpc!=null)			
			{ tcpc.Close(); }
		}


		private bool AuthLogin(ref NetworkStream nwstream)
		{
			if (this.username != null && this.username.Length > 0 && this.password != null && this.password.Length > 0)
			{
				WriteToStream(ref nwstream, "AUTH LOGIN\r\n");
				if (AuthImplemented(ReadFromStream(ref nwstream)))
				{
					WriteToStream(ref nwstream, Convert.ToBase64String(Encoding.ASCII.GetBytes(this.username.ToCharArray())) + "\r\n");

					CheckForError(ReadFromStream(ref nwstream), ReplyConstants.SERVER_CHALLENGE);

					WriteToStream(ref nwstream, Convert.ToBase64String(Encoding.ASCII.GetBytes(this.password.ToCharArray())) + "\r\n");
					CheckForError(ReadFromStream(ref nwstream), ReplyConstants.AUTH_SUCCESSFUL);
					
					OnAuthenticated(EventArgs.Empty);
					return true;
				}
			}

			return false;
		}
				
		private void SendRecipientList(ref NetworkStream nwstream, List<EmailAddress> recipients)
		{
			//	Iterate through all addresses and send them:
			foreach (var emailAddress in recipients)
			{
                EmailAddress recipient = emailAddress;
				WriteToStream(ref nwstream, "RCPT TO: <" + recipient.address + ">\r\n");

				if (!SmtpConfig.EnablePipelining) 
				{
					// potential 501 error (not valid sender, bad email address) below:
					CheckForError(ReadFromStream(ref nwstream), ReplyConstants.OK);
				}
			}	
		}

		private bool CheckMailMessage(MailMessage message)
		{
			string returnMessage = "Mail Message is missing ";
		
			if (message.To == null || message.To.Count <= 0)
			{	
				throw new SmtpException(returnMessage + "'To:' field");
			}
			else
			{ return true; }
		}

		/**
		 * NetworkStream Helper methods
		 */
		private void WriteToStream(ref NetworkStream nw, string line)
		{
			try
			{
				byte[] arrToSend = Encoding.ASCII.GetBytes(line);
				//byte[] arrToSend=Encoding.GetEncoding("gbk").GetBytes(line);
                //byte[] arrToSend = Encoding.UTF8.GetBytes(line);
                //				nw.Write(arrToSend, 0, arrToSend.Length);
                //Console.WriteLine("[client]:" + line);
                LogMessage(line, "[client]: ");
				
				int length=arrToSend.Length; 
				int size=75; 
				int count=size; 
				////				if (length>75) 
				////				{ 
				////					//					//数据分页 
				////					if ((length/size)*size==length)
				////						page=length/size+1; 
				////					else 
				////						page=length/size; 
				////					for (int i=0;i<page;i++)
				////					{ 
				////						start=i*size; 
				////						if (i==page-1) 
				////							count=length-(i*size); 
				////
				////						nw.Write(arrToSend,start,count);//将数据写入到服务器上 
				////						if(line.Substring(start,count).IndexOf("\r\n")==-1)
				////							nw.Write(Encoding.ASCII.GetBytes("\r\n"),0,(Encoding.ASCII.GetBytes("\r\n")).Length);
				////					}
				////   
				////   
				////				}
				////				else 
				nw.Write(arrToSend,0,arrToSend.Length); 
   
			}
			catch(System.Exception)
			{
				throw new SmtpException("Write to Stream threw an System.Exception");
			}
		}

		private string ReadFromStream(ref NetworkStream nw)
		{
			try
			{
				byte[] readBuffer = new byte[4096];
				
				int length = nw.Read(readBuffer, 0, readBuffer.Length);
				string returnMsg = Encoding.ASCII.GetString(readBuffer, 0, length);
				
				//Console.WriteLine("[server]:" + returnMsg);

				LogMessage(returnMsg, "[server]: ");
				return returnMsg;
			}
			catch(System.Exception e)
			{
				throw new SmtpException("Read from Stream threw an System.Exception: " + e.ToString());
			}
		}

		private void LogMessage(string msg, string src)
		{
			Log log = new Log();
			if (SmtpConfig.LogToText)	{ log.logToTextFile(SmtpConfig.LogPath, msg, src); }
		}
		
		/**
		 *
		 * Checks stream returned from SMTP server for success code
		 * If the success code is not present it will throw an error.		
		 *
		 */
		private void CheckForError(string s, string successCode)
		{
			if (s.IndexOf(successCode) == -1)
				throw new SmtpException("ERROR - Expecting: " + successCode + ". Recieved: " + s);
		}

		/// Check to see if the command sent returns a Unknown Command Error
		private bool IsUnknownCommand(string s)
		{
			if (s.IndexOf(ReplyConstants.UNKNOWN) != -1) { return true; }
			else { return false; }
		}

		/// Check to see if AUTH command returns valid challenge. 
		/// A valid AUTH string must be passed into this method.
		private bool AuthImplemented(string s)
		{
			if (s.IndexOf(ReplyConstants.SERVER_CHALLENGE) != -1)
			{ return true; }
			
			return false;
		}
	}
	
}