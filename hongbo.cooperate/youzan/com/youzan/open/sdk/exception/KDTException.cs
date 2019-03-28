using System;

namespace com.youzan.open.sdk.exception
{

	/// <summary>
	/// @author ph0ly
	/// @time 2016-11-29
	/// </summary>
	public class KDTException : Exception
	{

		public KDTException() : base()
		{
		}

		public KDTException(string msg) : base(msg)
		{
		}

	}

}