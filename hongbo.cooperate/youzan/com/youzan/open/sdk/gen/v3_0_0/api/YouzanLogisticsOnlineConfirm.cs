using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanLogisticsOnlineConfirmResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsOnlineConfirmResult;
    using YouzanLogisticsOnlineConfirmParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsOnlineConfirmParams;

    public class YouzanLogisticsOnlineConfirm : AbstractAPI <YouzanLogisticsOnlineConfirmParams, YouzanLogisticsOnlineConfirmResult>
	{

		public YouzanLogisticsOnlineConfirm()
		{
		}

		public YouzanLogisticsOnlineConfirm(YouzanLogisticsOnlineConfirmParams apiParams)
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
				return "youzan.logistics.online.confirm";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanLogisticsOnlineConfirmResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanLogisticsOnlineConfirmParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}