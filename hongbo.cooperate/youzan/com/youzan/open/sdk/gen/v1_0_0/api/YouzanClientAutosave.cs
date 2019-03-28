using System;

namespace com.youzan.open.sdk.gen.v1_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanClientAutosaveResult = com.youzan.open.sdk.gen.v1_0_0.model.YouzanClientAutosaveResult;
    using YouzanClientAutosaveParams = com.youzan.open.sdk.gen.v1_0_0.model.YouzanClientAutosaveParams;

    public class YouzanClientAutosave : AbstractAPI <YouzanClientAutosaveParams, YouzanClientAutosaveResult>
	{

		public YouzanClientAutosave()
		{
		}

		public YouzanClientAutosave(YouzanClientAutosaveParams apiParams)
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
				return "youzan.client.autosave";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanClientAutosaveResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanClientAutosaveParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}