using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanScrmCustomerCardListResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCustomerCardListResult;
    using YouzanScrmCustomerCardListParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCustomerCardListParams;

    public class YouzanScrmCustomerCardList : AbstractAPI <YouzanScrmCustomerCardListParams, YouzanScrmCustomerCardListResult>
	{

		public YouzanScrmCustomerCardList()
		{
		}

		public YouzanScrmCustomerCardList(YouzanScrmCustomerCardListParams apiParams)
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
				return "youzan.scrm.customer.card.list";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanScrmCustomerCardListResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanScrmCustomerCardListParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}