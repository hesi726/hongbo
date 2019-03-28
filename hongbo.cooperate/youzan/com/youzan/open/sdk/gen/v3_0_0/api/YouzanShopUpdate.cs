using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanShopUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanShopUpdateResult;
    using YouzanShopUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanShopUpdateParams;

    public class YouzanShopUpdate : AbstractAPI <YouzanShopUpdateParams, YouzanShopUpdateResult>
	{

		public YouzanShopUpdate()
		{
		}

		public YouzanShopUpdate(YouzanShopUpdateParams apiParams)
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
				return "youzan.shop.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanShopUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanShopUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}