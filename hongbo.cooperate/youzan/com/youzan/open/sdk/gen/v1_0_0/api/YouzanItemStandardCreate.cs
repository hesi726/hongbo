using System;

namespace com.youzan.open.sdk.gen.v1_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemStandardCreateResult = com.youzan.open.sdk.gen.v1_0_0.model.YouzanItemStandardCreateResult;
    using YouzanItemStandardCreateParams = com.youzan.open.sdk.gen.v1_0_0.model.YouzanItemStandardCreateParams;

    public class YouzanItemStandardCreate : AbstractAPI <YouzanItemStandardCreateParams, YouzanItemStandardCreateResult>
	{

		public YouzanItemStandardCreate()
		{
		}

		public YouzanItemStandardCreate(YouzanItemStandardCreateParams apiParams)
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
				return "1.0.0";
			}
		}

		public override string Name
		{
			get
			{
				return "youzan.item.standard.create";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemStandardCreateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemStandardCreateParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}