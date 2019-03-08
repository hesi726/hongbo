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
	using Microsoft.Win32;

	/// <summary>
	/// This Type stores a file attachment. There can be many attachments in each MailMessage
	/// <seealso cref="MailMessage"/>
	/// </summary>
	/// <example>
	/// <code>
	/// MailMessage msg = new MailMessage();
	/// Attachment a = new Attachment("C:\\file.jpg");
	/// msg.AddAttachment(a);
	/// </code>
	/// </example>
	public class Attachment: IComparable
	{

		internal string 	name;
		internal string 	mimeType;
		internal string 	encoding = "base64";
		internal string 	filePath;
		internal int		size = 0;
		internal string 	encodedFilePath;
		
		/// <summary>Constructor using a file path</summary>
		/// <example>
		/// <code>Attachment a = new Attachment("C:\\file.jpg");</code>
		/// </example>
		public Attachment(string filePath)
		{
			this.filePath = filePath;

			if (filePath.Length > 0)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(filePath);		
					if (fileInfo.Exists)
					{
						this.mimeType = getMimeType(fileInfo.Extension);
						this.name = fileInfo.Name;
						this.size = (int)fileInfo.Length;

						string encodedTempFile = Path.GetTempFileName();
						MailEncoder.ConvertToBase64(filePath, encodedTempFile);
						this.encodedFilePath = encodedTempFile;
					}
				}
				catch(ArgumentNullException)
				{
					throw new SmtpException("Attachment file does not exist or path is incorrect.");
				}
			}	
		}

	/// <summary>
    /// 
    /// </summary>
		~Attachment()
		{
			// delete temp file used for temp encoding of large files
			try
			{
				if (this.encodedFilePath != null)
				{
					FileInfo fileInfo = new FileInfo(this.encodedFilePath);
					if (fileInfo.Exists) { fileInfo.Delete(); }
				}
			}
			catch(ArgumentNullException)
			{ }
		}

		/// <value> Stores the Attachment Name</value>
		public string Name
		{
			get { return(this.name); }
			set { this.name = value; }
		}

		/// <value> Stores the MIME type of the attachment</value>
		public string MimeType
		{
			get { return(this.mimeType); }
			set { this.mimeType = value; }
		}

		/// <value> Returns the MIME encoding type of the attachment</value>
		public string Encoding
		{
			get { return(this.encoding); }
		}
		
		/// <value> Returns the path to the file to be attached</value>
		public string FilePath
		{
			get { return(this.filePath); }
		}

		/// <value> Returns the attachment size in bytes</value>
		public int Size
		{
			get { return(this.size); }
		}
		
		/// <value>When the file is encoded it is stored in temp directory until sendMail() method is called.
		/// This property retrieves the path to that temp file.</value>
		internal string EncodedFilePath
		{
			get { return(this.encodedFilePath) ; }
		}
		
		/// <summary>Returns the MIME type for the supplied file extension</summary>
		/// <returns>String MIME type (Example: \"text/plain\")</returns>
		private string getMimeType(string fileExtension)
		{
			try
			{
				//RegistryKey extKey = Registry.ClassesRoot.OpenSubKey(fileExtension);
				//string contentType = (string)extKey.GetValue("Content Type");

				//if (contentType.ToString() != null)
				//{	
				//	return contentType.ToString(); 
				//}
				//else
				{ return "application/octet-stream"; }
			}
			catch(System.Exception)
			{ return "application/octet-stream"; }
		}
		
        /// <summary>
        /// 
        /// </summary>
        /// <param name="attachment"></param>
        /// <returns></returns>
		public int CompareTo(object attachment)        
		{ 
			// Order instances based on the Date         
			return (this.Name.CompareTo(((Attachment)(attachment)).Name));        
		}	

		/// <summary>returns the file name from a parsed file path</summary>
		/// <param name="filePath">UNC file path to file (IE: "C:\file.txt")</param>
		/// <returns>string file name (Example: \"test.zip\")</returns>
		private string getFileName(string filePath)
		{
			return filePath.Substring(filePath.LastIndexOf("\\")+1);
		}
		

	}
}