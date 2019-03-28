using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanMultistoreGoodsSingleskuUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMultistoreGoodsSingleskuUpdateResult;
    using YouzanMultistoreGoodsSingleskuUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMultistoreGoodsSingleskuUpdateParams;

    public class YouzanMultistoreGoodsSingleskuUpdate : AbstractAPI <YouzanMultistoreGoodsSingleskuUpdateParams, YouzanMultistoreGoodsSingleskuUpdateResult>
	{

		public YouzanMultistoreGoodsSingleskuUpdate()
		{
		}

		public YouzanMultistoreGoodsSingleskuUpdate(YouzanMultistoreGoodsSingleskuUpdateParams apiParams)
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
				return "youzan.multistore.goods.singlesku.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanMultistoreGoodsSingleskuUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanMultistoreGoodsSingleskuUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}