using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanScrmCustomerCardGrantResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCustomerCardGrantResult;
    using YouzanScrmCustomerCardGrantParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCustomerCardGrantParams;

    public class YouzanScrmCustomerCardGrant : AbstractAPI <YouzanScrmCustomerCardGrantParams, YouzanScrmCustomerCardGrantResult>
	{

		public YouzanScrmCustomerCardGrant()
		{
		}

		public YouzanScrmCustomerCardGrant(YouzanScrmCustomerCardGrantParams apiParams)
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
				return "youzan.scrm.customer.card.grant";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanScrmCustomerCardGrantResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanScrmCustomerCardGrantParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}