using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanScrmCustomerRemarkUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCustomerRemarkUpdateResult;
    using YouzanScrmCustomerRemarkUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCustomerRemarkUpdateParams;

    public class YouzanScrmCustomerRemarkUpdate : AbstractAPI <YouzanScrmCustomerRemarkUpdateParams, YouzanScrmCustomerRemarkUpdateResult>
	{

		public YouzanScrmCustomerRemarkUpdate()
		{
		}

		public YouzanScrmCustomerRemarkUpdate(YouzanScrmCustomerRemarkUpdateParams apiParams)
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
				return "youzan.scrm.customer.remark.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanScrmCustomerRemarkUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanScrmCustomerRemarkUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}