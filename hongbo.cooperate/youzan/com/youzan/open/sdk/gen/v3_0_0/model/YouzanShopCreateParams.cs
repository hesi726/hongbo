using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////	using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
    using global::youzan.com.youzan.open.sdk.model;

    ////	using Maps = com.google.common.collect.Maps;


    ////	using Multimap = com.google.common.collect.Multimap;


    using APIParams = com.youzan.open.sdk.model.APIParams;
    using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
    using FileParams = com.youzan.open.sdk.model.FileParams;

    public class YouzanShopCreateParams : APIParams, FileParams
	{

		/// <summary>
		/// 店铺简介
		/// </summary>
		private string intro;
		/// <summary>
		/// 店铺LOGO资源地址
		/// </summary>
		private string logo;
		/// <summary>
		/// 店铺名字
		/// </summary>
		private string name;

		public virtual string Intro
		{
			set
			{
				this.intro = value;
			}
			get
			{
				return this.intro;
			}
		}


		public virtual string Logo
		{
			set
			{
				this.logo = value;
			}
			get
			{
				return this.logo;
			}
		}


		public virtual string Name
		{
			set
			{
				this.name = value;
			}
			get
			{
				return this.name;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(intro, null))
			{
				@params["intro"] = intro;
			}
			if (!string.ReferenceEquals(logo, null))
			{
				@params["logo"] = logo;
			}
			if (!string.ReferenceEquals(name, null))
			{
				@params["name"] = name;
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