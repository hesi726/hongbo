namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanShopGetResult : APIResult
	{



		/// <summary>
		/// 店铺名字
		/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
		private string name;


		/// <summary>
		/// 店铺LOGO
		/// </summary>
[Newtonsoft.Json.JsonProperty("logo")]//) private String logo;
		private string logo;


		/// <summary>
		/// 店铺简介
		/// </summary>
[Newtonsoft.Json.JsonProperty("intro")]//) private String intro;
		private string intro;


		/// <summary>
		/// 店铺id
		/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
		private long? id;

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

		public virtual long? Id
		{
			set
			{
				this.id = value;
			}
			get
			{
				return this.id;
			}
		}



	}
}