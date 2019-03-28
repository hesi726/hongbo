using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{
    using System.Linq;
    using APIParams = com.youzan.open.sdk.model.APIParams;
    using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
    using FileParams = com.youzan.open.sdk.model.FileParams;

    public class YouzanMaterialsStoragePlatformImgUploadParams : APIParams, FileParams
	{

		/// <summary>
		/// 本地图片上传(http post)，仅支持单个文件上传，每个文件不超过1MB。
		/// </summary>
		private ByteWrapper[] image;

		public virtual ByteWrapper[] Image
		{
			set
			{
				this.image = value;
			}
			get
			{
				return this.image;
			}
		}

        public IDictionary<string, ByteWrapper> toFileParams()
        {
            return Image.ToDictionary(a => a.Name);
        }

        public virtual IDictionary<string, object> toParams()
		{
            IDictionary<string, object> @params = new Dictionary<string, object>();//  Maps.newHashMap();
			return @params;
		}
        


	}
}