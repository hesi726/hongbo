using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////	using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
    using global::youzan.com.youzan.open.sdk.model;

    ////	using Maps = com.google.common.collect.Maps;


    ////	using Multimap = com.google.common.collect.Multimap;


    using APIParams = com.youzan.open.sdk.model.APIParams;
    using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
    using FileParams = com.youzan.open.sdk.model.FileParams;

    public class YouzanMaterialsVideoUploadPublishParams : APIParams, FileParams
	{

		/// <summary>
		/// 视频所属分组id(默认为0,归属于未分组)
		/// </summary>
		private long? categoryId;
		/// <summary>
		/// 视频文件名称
		/// </summary>
		private string fileName;
		/// <summary>
		/// 上传的远端视频文件路径
		/// </summary>
		private string videoPath;

		public virtual long? CategoryId
		{
			set
			{
				this.categoryId = value;
			}
			get
			{
				return this.categoryId;
			}
		}


		public virtual string FileName
		{
			set
			{
				this.fileName = value;
			}
			get
			{
				return this.fileName;
			}
		}


		public virtual string VideoPath
		{
			set
			{
				this.videoPath = value;
			}
			get
			{
				return this.videoPath;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (categoryId != null)
			{
				@params["category_id"] = categoryId;
			}
			if (!string.ReferenceEquals(fileName, null))
			{
				@params["file_name"] = fileName;
			}
			if (!string.ReferenceEquals(videoPath, null))
			{
				@params["video_path"] = videoPath;
			}
			return @params;
		}

		public virtual IDictionary<string,ByteWrapper> toFileParams()
		{
			Multimap<string, ByteWrapper> @params = ArrayListMultimap.create<string, ByteWrapper>();

				return @params;
		}


	}
}