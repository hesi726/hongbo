using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemDeleteResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemDeleteResult;
    using YouzanItemDeleteParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemDeleteParams;

    public class YouzanItemDelete : AbstractAPI <YouzanItemDeleteParams, YouzanItemDeleteResult>
	{

		public YouzanItemDelete()
		{
		}

		public YouzanItemDelete(YouzanItemDeleteParams apiParams)
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
				return "youzan.item.delete";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemDeleteResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemDeleteParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}