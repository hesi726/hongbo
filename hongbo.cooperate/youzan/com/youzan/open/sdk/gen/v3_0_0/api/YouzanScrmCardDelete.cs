using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanScrmCardDeleteResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCardDeleteResult;
    using YouzanScrmCardDeleteParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCardDeleteParams;

    public class YouzanScrmCardDelete : AbstractAPI <YouzanScrmCardDeleteParams, YouzanScrmCardDeleteResult>
	{

		public YouzanScrmCardDelete()
		{
		}

		public YouzanScrmCardDelete(YouzanScrmCardDeleteParams apiParams)
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
				return "youzan.scrm.card.delete";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanScrmCardDeleteResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanScrmCardDeleteParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}