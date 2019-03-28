using System;

namespace com.youzan.open.sdk.gen.v1_0_1.api
{

    using com.youzan.open.sdk.api;
    using YouzanPayAcctransBillDetailGetListResult = com.youzan.open.sdk.gen.v1_0_1.model.YouzanPayAcctransBillDetailGetListResult;
    using YouzanPayAcctransBillDetailGetListParams = com.youzan.open.sdk.gen.v1_0_1.model.YouzanPayAcctransBillDetailGetListParams;

    public class YouzanPayAcctransBillDetailGetList : AbstractAPI <YouzanPayAcctransBillDetailGetListParams, YouzanPayAcctransBillDetailGetListResult>
	{

		public YouzanPayAcctransBillDetailGetList()
		{
		}

		public YouzanPayAcctransBillDetailGetList(YouzanPayAcctransBillDetailGetListParams apiParams)
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
				return "youzan.pay.acctrans.bill.detail.get.list";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanPayAcctransBillDetailGetListResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanPayAcctransBillDetailGetListParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}