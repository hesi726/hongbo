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

        
	
		
	}
}