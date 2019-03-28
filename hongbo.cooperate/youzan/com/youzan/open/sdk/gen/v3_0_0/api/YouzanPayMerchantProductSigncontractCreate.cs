using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanPayMerchantProductSigncontractCreateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPayMerchantProductSigncontractCreateResult;
    using YouzanPayMerchantProductSigncontractCreateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPayMerchantProductSigncontractCreateParams;

    public class YouzanPayMerchantProductSigncontractCreate : AbstractAPI <YouzanPayMerchantProductSigncontractCreateParams, YouzanPayMerchantProductSigncontractCreateResult>
	{

		public YouzanPayMerchantProductSigncontractCreate()
		{
		}

		public YouzanPayMerchantProductSigncontractCreate(YouzanPayMerchantProductSigncontractCreateParams apiParams)
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
				return "youzan.pay.merchant.product.signcontract.create";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanPayMerchantProductSigncontractCreateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanPayMerchantProductSigncontractCreateParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}