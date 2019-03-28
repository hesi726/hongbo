using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{
    using APIParams = com.youzan.open.sdk.model.APIParams;

    public class YouzanItemDeleteParams : APIParams
	{

		/// <summary>
		/// 商品Id
		/// </summary>
		private long? itemId;

		public virtual long? ItemId
		{
			set
			{
				this.itemId = value;
			}
			get
			{
				return this.itemId;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
            IDictionary<string, object> @params = new Dictionary<string, object>(); // Maps.newHashMap();
			if (itemId != null)
			{
				@params["item_id"] = itemId;
			}
			return @params;
		}

		//public virtual IDictonary<string,ByteWrapper> toFileParams()
		//{
		//	Multimap<string, ByteWrapper> @params = ArrayListMultimap.create<string, ByteWrapper>();

		//		return @params;
		//}


	}
}