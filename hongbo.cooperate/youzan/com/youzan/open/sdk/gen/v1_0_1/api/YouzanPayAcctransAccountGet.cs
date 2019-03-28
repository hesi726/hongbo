using System;

namespace com.youzan.open.sdk.gen.v1_0_1.api
{

    using com.youzan.open.sdk.api;
    using YouzanPayAcctransAccountGetResult = com.youzan.open.sdk.gen.v1_0_1.model.YouzanPayAcctransAccountGetResult;
    using YouzanPayAcctransAccountGetParams = com.youzan.open.sdk.gen.v1_0_1.model.YouzanPayAcctransAccountGetParams;

    public class YouzanPayAcctransAccountGet : AbstractAPI <YouzanPayAcctransAccountGetParams, YouzanPayAcctransAccountGetResult>
	{

		public YouzanPayAcctransAccountGet()
		{
		}

		public YouzanPayAcctransAccountGet(YouzanPayAcctransAccountGetParams apiParams)
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
				return "1.0.1";
			}
		}

		public override string Name
		{
			get
			{
				return "youzan.pay.acctrans.account.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanPayAcctransAccountGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanPayAcctransAccountGetParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}