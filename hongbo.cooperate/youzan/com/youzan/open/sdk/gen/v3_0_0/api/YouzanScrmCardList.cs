using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanScrmCardListResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCardListResult;
    using YouzanScrmCardListParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCardListParams;

    public class YouzanScrmCardList : AbstractAPI <YouzanScrmCardListParams, YouzanScrmCardListResult>
	{

		public YouzanScrmCardList()
		{
		}

		public YouzanScrmCardList(YouzanScrmCardListParams apiParams)
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
				return "youzan.scrm.card.list";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanScrmCardListResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanScrmCardListParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}