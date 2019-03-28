namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanLogisticsTemplateCreateResult : APIResult
	{



		/// <summary>
		/// 运费模板id
		/// </summary>
[Newtonsoft.Json.JsonProperty("templateId")]//) private Nullable<long> templateId;
		private long? templateId;

		public virtual long? TemplateId
		{
			set
			{
				this.templateId = value;
			}
			get
			{
				return this.templateId;
			}
		}



	}
}