using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanRetailProductSkusDeleteResult : APIResult
	{



		/// <summary>
		/// 批量删除商品库商品，各个商品是否更新成功
		/// </summary>
[Newtonsoft.Json.JsonProperty("delete_result")]//) private java.util.Map<Nullable<long>,Nullable<bool>> deleteResult;
		private IDictionary<long?, bool?> deleteResult;

		public virtual IDictionary<long?, bool?> DeleteResult
		{
			set
			{
				this.deleteResult = value;
			}
			get
			{
				return this.deleteResult;
			}
		}



	}
}