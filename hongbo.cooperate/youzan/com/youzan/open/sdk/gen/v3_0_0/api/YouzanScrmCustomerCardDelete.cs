using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanScrmCustomerCardDeleteResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCustomerCardDeleteResult;
    using YouzanScrmCustomerCardDeleteParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCustomerCardDeleteParams;

    public class YouzanScrmCustomerCardDelete : AbstractAPI <YouzanScrmCustomerCardDeleteParams, YouzanScrmCustomerCardDeleteResult>
	{

		public YouzanScrmCustomerCardDelete()
		{
		}

		public YouzanScrmCustomerCardDelete(YouzanScrmCustomerCardDeleteParams apiParams)
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
				return "youzan.scrm.customer.card.delete";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanScrmCustomerCardDeleteResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanScrmCustomerCardDeleteParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}