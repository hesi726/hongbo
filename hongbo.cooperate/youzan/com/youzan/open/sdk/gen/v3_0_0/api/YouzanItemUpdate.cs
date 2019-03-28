using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemUpdateResult;
    using YouzanItemUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemUpdateParams;

    public class YouzanItemUpdate : AbstractAPI <YouzanItemUpdateParams, YouzanItemUpdateResult>
	{

		public YouzanItemUpdate()
		{
		}

		public YouzanItemUpdate(YouzanItemUpdateParams apiParams)
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
				return "youzan.item.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}