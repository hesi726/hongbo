using System;

namespace com.youzan.open.sdk.gen.v1_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemStandardGetbycodeResult = com.youzan.open.sdk.gen.v1_0_0.model.YouzanItemStandardGetbycodeResult;
    using YouzanItemStandardGetbycodeParams = com.youzan.open.sdk.gen.v1_0_0.model.YouzanItemStandardGetbycodeParams;

    public class YouzanItemStandardGetbycode : AbstractAPI <YouzanItemStandardGetbycodeParams, YouzanItemStandardGetbycodeResult>
	{

		public YouzanItemStandardGetbycode()
		{
		}

		public YouzanItemStandardGetbycode(YouzanItemStandardGetbycodeParams apiParams)
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
				return "youzan.item.standard.getbycode";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemStandardGetbycodeResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemStandardGetbycodeParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}