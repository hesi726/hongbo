using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanLogisticsTemplateCreateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsTemplateCreateResult;
    using YouzanLogisticsTemplateCreateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsTemplateCreateParams;

    public class YouzanLogisticsTemplateCreate : AbstractAPI <YouzanLogisticsTemplateCreateParams, YouzanLogisticsTemplateCreateResult>
	{

		public YouzanLogisticsTemplateCreate()
		{
		}

		public YouzanLogisticsTemplateCreate(YouzanLogisticsTemplateCreateParams apiParams)
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
				return "youzan.logistics.template.create";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanLogisticsTemplateCreateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanLogisticsTemplateCreateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}