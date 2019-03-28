using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemCreateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemCreateResult;
    using YouzanItemCreateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemCreateParams;

    public class YouzanItemCreate : AbstractAPI <YouzanItemCreateParams, YouzanItemCreateResult>
	{

		public YouzanItemCreate()
		{
		}

		public YouzanItemCreate(YouzanItemCreateParams apiParams)
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
				return "youzan.item.create";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemCreateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemCreateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}