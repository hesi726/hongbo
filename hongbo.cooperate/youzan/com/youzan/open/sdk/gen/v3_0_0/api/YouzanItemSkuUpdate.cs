using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemSkuUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemSkuUpdateResult;
    using YouzanItemSkuUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemSkuUpdateParams;

    public class YouzanItemSkuUpdate : AbstractAPI <YouzanItemSkuUpdateParams, YouzanItemSkuUpdateResult>
	{

		public YouzanItemSkuUpdate()
		{
		}

		public YouzanItemSkuUpdate(YouzanItemSkuUpdateParams apiParams)
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
				return "youzan.item.sku.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemSkuUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemSkuUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}