using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeMemoUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeMemoUpdateResult;
    using YouzanTradeMemoUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeMemoUpdateParams;

    public class YouzanTradeMemoUpdate : AbstractAPI <YouzanTradeMemoUpdateParams, YouzanTradeMemoUpdateResult>
	{

		public YouzanTradeMemoUpdate()
		{
		}

		public YouzanTradeMemoUpdate(YouzanTradeMemoUpdateParams apiParams)
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
				return "youzan.trade.memo.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeMemoUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeMemoUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}