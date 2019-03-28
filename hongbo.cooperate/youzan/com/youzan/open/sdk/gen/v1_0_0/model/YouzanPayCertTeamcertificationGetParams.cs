using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v1_0_0.model
{

    ////	using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
    using global::youzan.com.youzan.open.sdk.model;

    ////	using Maps = com.google.common.collect.Maps;


    ////	using Multimap = com.google.common.collect.Multimap;


    using APIParams = com.youzan.open.sdk.model.APIParams;
    using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
    using FileParams = com.youzan.open.sdk.model.FileParams;

    public class YouzanPayCertTeamcertificationGetParams : APIParams, FileParams
	{

		/// <summary>
		/// json
		/// </summary>
		private string debug;
		/// <summary>
		/// 店铺id
		/// </summary>
		private string kdtId;

		public virtual string Debug
		{
			set
			{
				this.debug = value;
			}
			get
			{
				return this.debug;
			}
		}


		public virtual string KdtId
		{
			set
			{
				this.kdtId = value;
			}
			get
			{
				return this.kdtId;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(debug, null))
			{
				@params["debug"] = debug;
			}
			if (!string.ReferenceEquals(kdtId, null))
			{
				@params["kdt_id"] = kdtId;
			}
			return @params;
		}

		public virtual IDictionary<string,ByteWrapper> toFileParams()
		{
			Multimap<string, ByteWrapper> @params = ArrayListMultimap.create<string, ByteWrapper>();

				return @params;
		}


	}
}