using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanLogisticsFeeGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsFeeGetResult;
    using YouzanLogisticsFeeGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsFeeGetParams;

    public class YouzanLogisticsFeeGet : AbstractAPI <YouzanLogisticsFeeGetParams, YouzanLogisticsFeeGetResult>
	{

		public YouzanLogisticsFeeGet()
		{
		}

		public YouzanLogisticsFeeGet(YouzanLogisticsFeeGetParams apiParams)
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
				return "youzan.logistics.fee.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanLogisticsFeeGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanLogisticsFeeGetParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}