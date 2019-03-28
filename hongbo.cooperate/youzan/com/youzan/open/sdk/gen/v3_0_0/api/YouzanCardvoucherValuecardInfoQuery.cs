using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanCardvoucherValuecardInfoQueryResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanCardvoucherValuecardInfoQueryResult;
    using YouzanCardvoucherValuecardInfoQueryParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanCardvoucherValuecardInfoQueryParams;

    public class YouzanCardvoucherValuecardInfoQuery : AbstractAPI <YouzanCardvoucherValuecardInfoQueryParams, YouzanCardvoucherValuecardInfoQueryResult>
	{

		public YouzanCardvoucherValuecardInfoQuery()
		{
		}

		public YouzanCardvoucherValuecardInfoQuery(YouzanCardvoucherValuecardInfoQueryParams apiParams)
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
				return "youzan.cardvoucher.valuecard.info.query";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanCardvoucherValuecardInfoQueryResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanCardvoucherValuecardInfoQueryParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}