using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemHotelRoomSetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemHotelRoomSetResult;
    using YouzanItemHotelRoomSetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemHotelRoomSetParams;

    public class YouzanItemHotelRoomSet : AbstractAPI <YouzanItemHotelRoomSetParams, YouzanItemHotelRoomSetResult>
	{

		public YouzanItemHotelRoomSet()
		{
		}

		public YouzanItemHotelRoomSet(YouzanItemHotelRoomSetParams apiParams)
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
				return "youzan.item.hotel.room.set";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemHotelRoomSetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemHotelRoomSetParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}