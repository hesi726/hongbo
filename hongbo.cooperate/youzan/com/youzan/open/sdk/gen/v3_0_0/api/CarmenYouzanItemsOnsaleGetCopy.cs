using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using CarmenYouzanItemsOnsaleGetCopyResult = com.youzan.open.sdk.gen.v3_0_0.model.CarmenYouzanItemsOnsaleGetCopyResult;
    using CarmenYouzanItemsOnsaleGetCopyParams = com.youzan.open.sdk.gen.v3_0_0.model.CarmenYouzanItemsOnsaleGetCopyParams;

    public class CarmenYouzanItemsOnsaleGetCopy : AbstractAPI <CarmenYouzanItemsOnsaleGetCopyParams, CarmenYouzanItemsOnsaleGetCopyResult>
	{

		public CarmenYouzanItemsOnsaleGetCopy()
		{
		}

		public CarmenYouzanItemsOnsaleGetCopy(CarmenYouzanItemsOnsaleGetCopyParams apiParams)
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
				return "carmen.youzan.items.onsale.get.copy";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(CarmenYouzanItemsOnsaleGetCopyResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(CarmenYouzanItemsOnsaleGetCopyParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}