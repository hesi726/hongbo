using com.youzan.open.sdk.api;
using com.youzan.open.sdk.gen.v1_0_0.model;
using System;

namespace com.youzan.open.sdk.gen.v1_0_0.api
{    
	public class KdtItemDelete : AbstractAPI <KdtItemDeleteParams, KdtItemDeleteResult>
	{

		public KdtItemDelete()
		{
		}

		public KdtItemDelete(KdtItemDeleteParams apiParams)
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
				return "1.0.0";
			}
		}

		public override string Name
		{
			get
			{
				return "kdt.item.delete";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(KdtItemDeleteResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(KdtItemDeleteParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}