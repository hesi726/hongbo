using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemsInventoryGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemsInventoryGetResult;
    using YouzanItemsInventoryGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemsInventoryGetParams;

    public class YouzanItemsInventoryGet : AbstractAPI <YouzanItemsInventoryGetParams, YouzanItemsInventoryGetResult>
	{

		public YouzanItemsInventoryGet()
		{
		}

		public YouzanItemsInventoryGet(YouzanItemsInventoryGetParams apiParams)
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
				return "youzan.items.inventory.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemsInventoryGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemsInventoryGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}