using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUmpPromotionGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpPromotionGetResult;
    using YouzanUmpPromotionGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpPromotionGetParams;

    public class YouzanUmpPromotionGet : AbstractAPI <YouzanUmpPromotionGetParams, YouzanUmpPromotionGetResult>
	{

		public YouzanUmpPromotionGet()
		{
		}

		public YouzanUmpPromotionGet(YouzanUmpPromotionGetParams apiParams)
		{
			this.@params = apiParams;
		}

		public override string HttpMethod
		{
			get
			{
				return "GET";
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
				return "youzan.ump.promotion.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUmpPromotionGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUmpPromotionGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}