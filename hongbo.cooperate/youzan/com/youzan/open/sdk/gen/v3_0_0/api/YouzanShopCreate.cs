using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanShopCreateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanShopCreateResult;
    using YouzanShopCreateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanShopCreateParams;

    public class YouzanShopCreate : AbstractAPI <YouzanShopCreateParams, YouzanShopCreateResult>
	{

		public YouzanShopCreate()
		{
		}

		public YouzanShopCreate(YouzanShopCreateParams apiParams)
		{
			this.@params = apiParams;
		}

		public override string HttpMethod
		{
			get
			{
				return "POST";
			}
		}

		public override string Version
		{
			get
			{
				return "3.0.0";
			}
		}

		public override string Name
		{
			get
			{
				return "youzan.shop.create";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanShopCreateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanShopCreateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}