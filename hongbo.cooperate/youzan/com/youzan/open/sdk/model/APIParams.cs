using System.Collections.Generic;

namespace com.youzan.open.sdk.model
{

	/// <summary>
	/// @author ph0ly
	/// @time 2016-11-28
	/// </summary>
	public interface APIParams
	{

		IDictionary<string, object> toParams();

	}

}