using System.Collections.Generic;

namespace com.youzan.open.sdk.model
{


    /// <summary>
    /// @author ph0ly
    /// @time 2016-11-29
    /// </summary>
    public interface FileParams : APIParams
	{

		IDictionary<string, ByteWrapper> toFileParams();

	}

}