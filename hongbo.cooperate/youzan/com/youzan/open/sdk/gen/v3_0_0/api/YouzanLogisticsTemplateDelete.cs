using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanLogisticsTemplateDeleteResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsTemplateDeleteResult;
    using YouzanLogisticsTemplateDeleteParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsTemplateDeleteParams;

    public class YouzanLogisticsTemplateDelete : AbstractAPI <YouzanLogisticsTemplateDeleteParams, YouzanLogisticsTemplateDeleteResult>
	{

		public YouzanLogisticsTemplateDelete()
		{
		}

		public YouzanLogisticsTemplateDelete(YouzanLogisticsTemplateDeleteParams apiParams)
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
				return "youzan.logistics.template.delete";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanLogisticsTemplateDeleteResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanLogisticsTemplateDeleteParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}