using System;

namespace com.youzan.open.sdk.gen.v1_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanClientAppenginePushinfoUpdateResult = com.youzan.open.sdk.gen.v1_0_0.model.YouzanClientAppenginePushinfoUpdateResult;
    using YouzanClientAppenginePushinfoUpdateParams = com.youzan.open.sdk.gen.v1_0_0.model.YouzanClientAppenginePushinfoUpdateParams;

    public class YouzanClientAppenginePushinfoUpdate : AbstractAPI <YouzanClientAppenginePushinfoUpdateParams, YouzanClientAppenginePushinfoUpdateResult>
	{

		public YouzanClientAppenginePushinfoUpdate()
		{
		}

		public YouzanClientAppenginePushinfoUpdate(YouzanClientAppenginePushinfoUpdateParams apiParams)
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
				return "1.0.0";
			}
		}

		public override string Name
		{
			get
			{
				return "youzan.client.appengine.pushinfo.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanClientAppenginePushinfoUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanClientAppenginePushinfoUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}