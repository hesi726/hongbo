using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemHotelRoomQueryResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemHotelRoomQueryResult;
    using YouzanItemHotelRoomQueryParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemHotelRoomQueryParams;

    public class YouzanItemHotelRoomQuery : AbstractAPI <YouzanItemHotelRoomQueryParams, YouzanItemHotelRoomQueryResult>
	{

		public YouzanItemHotelRoomQuery()
		{
		}

		public YouzanItemHotelRoomQuery(YouzanItemHotelRoomQueryParams apiParams)
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
				return "youzan.item.hotel.room.query";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemHotelRoomQueryResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemHotelRoomQueryParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}