using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemStandardGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemStandardGetResult;
    using YouzanItemStandardGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemStandardGetParams;

    public class YouzanItemStandardGet : AbstractAPI <YouzanItemStandardGetParams, YouzanItemStandardGetResult>
	{

		public YouzanItemStandardGet()
		{
		}

		public YouzanItemStandardGet(YouzanItemStandardGetParams apiParams)
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
				return "youzan.item.standard.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemStandardGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemStandardGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}