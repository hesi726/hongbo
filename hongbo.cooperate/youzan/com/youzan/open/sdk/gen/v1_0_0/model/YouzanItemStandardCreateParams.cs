using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v1_0_0.model
{
    using APIParams = com.youzan.open.sdk.model.APIParams;

    public class YouzanItemStandardCreateParams : APIParams
	{

		/// <summary>
		/// 商品条码，通用的条形编码，不是商家编码
		/// </summary>
		private string code;
		/// <summary>
		/// 商品类型
		/// </summary>
		private long? itemType;

		public virtual string Code
		{
			set
			{
				this.code = value;
			}
			get
			{
				return this.code;
			}
		}


		public virtual long? ItemType
		{
			set
			{
				this.itemType = value;
			}
			get
			{
				return this.itemType;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = new Dictionary<string, object>();
			if (!string.ReferenceEquals(code, null))
			{
				@params["code"] = code;
			}
			if (itemType != null)
			{
				@params["item_type"] = itemType;
			}
			return @params;
		}
        


	}
}