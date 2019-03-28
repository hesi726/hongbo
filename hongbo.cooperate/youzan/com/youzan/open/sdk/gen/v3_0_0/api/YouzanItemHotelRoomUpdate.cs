using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemHotelRoomUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemHotelRoomUpdateResult;
    using YouzanItemHotelRoomUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemHotelRoomUpdateParams;

    public class YouzanItemHotelRoomUpdate : AbstractAPI <YouzanItemHotelRoomUpdateParams, YouzanItemHotelRoomUpdateResult>
	{

		public YouzanItemHotelRoomUpdate()
		{
		}

		public YouzanItemHotelRoomUpdate(YouzanItemHotelRoomUpdateParams apiParams)
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
				return "youzan.item.hotel.room.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemHotelRoomUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemHotelRoomUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}