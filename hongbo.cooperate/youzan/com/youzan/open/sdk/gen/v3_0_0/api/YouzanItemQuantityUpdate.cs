using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemQuantityUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemQuantityUpdateResult;
    using YouzanItemQuantityUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemQuantityUpdateParams;

    public class YouzanItemQuantityUpdate : AbstractAPI <YouzanItemQuantityUpdateParams, YouzanItemQuantityUpdateResult>
	{

		public YouzanItemQuantityUpdate()
		{
		}

		public YouzanItemQuantityUpdate(YouzanItemQuantityUpdateParams apiParams)
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
				return "youzan.item.quantity.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemQuantityUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemQuantityUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}