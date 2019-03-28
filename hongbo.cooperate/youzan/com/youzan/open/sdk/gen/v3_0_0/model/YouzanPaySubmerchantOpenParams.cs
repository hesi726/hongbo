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

    public class YouzanPaySubmerchantOpenParams : APIParams, FileParams
	{

		/// <summary>
		/// 营业期限 起
		/// </summary>
		private long? bizEffectiveFrom;
		/// <summary>
		/// 营业期限 止
		/// </summary>
		private long? bizExpiredOn;
		/// <summary>
		/// 注册地址
		/// </summary>
		private string businessAddress;
		/// <summary>
		/// 营业执照号
		/// </summary>
		private string businessLicense;
		/// <summary>
		/// 营业执照照片URL
		/// </summary>
		private string businessLicensePhotoUri;
		/// <summary>
		/// 企业名字
		/// </summary>
		private string businessName;
		/// <summary>
		/// 经营范围
		/// </summary>
		private string businessScope;
		/// <summary>
		/// 联系人邮箱
		/// </summary>
		private string contactMail;
		/// <summary>
		/// 联系人手机
		/// </summary>
		private string contactPhone;
		/// <summary>
		/// 联系人姓名
		/// </summary>
		private string contactsName;
		/// <summary>
		/// 证件反面照片
		/// </summary>
		private string idCardBackPhotoUri;
		/// <summary>
		/// 证件正面照片
		/// </summary>
		private string idCardFrontPhotoUri;
		/// <summary>
		/// 手持证件照片
		/// </summary>
		private string idCardInHandPhotoUri;
		/// <summary>
		/// 法人名字
		/// </summary>
		private string idCardName;
		/// <summary>
		/// 法人证件号码
		/// </summary>
		private string idCardNo;
		/// <summary>
		/// 法人证件类型 Enum(1: 中国大陆身份证 2: 香港身份证 3: 台湾身份证 4: 澳门身份证 5: 中国大陆护照 6: 港澳通行证 7: 台湾通行证)
		/// </summary>
		private long? idCardType;
		/// <summary>
		/// 法人证件期限 起
		/// </summary>
		private long? idEffectiveFrom;
		/// <summary>
		/// 法人证件期限 止
		/// </summary>
		private long? idExpiredOn;
		/// <summary>
		/// 组织机构代码
		/// </summary>
		private string organizationCode;
		/// <summary>
		/// 组织机构代码证照片URL
		/// </summary>
		private string organizationCodePhotoUri;
		/// <summary>
		/// 外部商户号
		/// </summary>
		private string outUserNo;
		/// <summary>
		/// 审核地址
		/// </summary>
		private string resultNoticeUri;
		/// <summary>
		/// 服务描述
		/// </summary>
		private string serviceDesc;
		/// <summary>
		/// 服务商商户号
		/// </summary>
		private long? serviceMerchantNo;
		/// <summary>
		/// 客服电话
		/// </summary>
		private string serviceTel;

		public virtual long? BizEffectiveFrom
		{
			set
			{
				this.bizEffectiveFrom = value;
			}
			get
			{
				return this.bizEffectiveFrom;
			}
		}


		public virtual long? BizExpiredOn
		{
			set
			{
				this.bizExpiredOn = value;
			}
			get
			{
				return this.bizExpiredOn;
			}
		}


		public virtual string BusinessAddress
		{
			set
			{
				this.businessAddress = value;
			}
			get
			{
				return this.businessAddress;
			}
		}


		public virtual string BusinessLicense
		{
			set
			{
				this.businessLicense = value;
			}
			get
			{
				return this.businessLicense;
			}
		}


		public virtual string BusinessLicensePhotoUri
		{
			set
			{
				this.businessLicensePhotoUri = value;
			}
			get
			{
				return this.businessLicensePhotoUri;
			}
		}


		public virtual string BusinessName
		{
			set
			{
				this.businessName = value;
			}
			get
			{
				return this.businessName;
			}
		}


		public virtual string BusinessScope
		{
			set
			{
				this.businessScope = value;
			}
			get
			{
				return this.businessScope;
			}
		}


		public virtual string ContactMail
		{
			set
			{
				this.contactMail = value;
			}
			get
			{
				return this.contactMail;
			}
		}


		public virtual string ContactPhone
		{
			set
			{
				this.contactPhone = value;
			}
			get
			{
				return this.contactPhone;
			}
		}


		public virtual string ContactsName
		{
			set
			{
				this.contactsName = value;
			}
			get
			{
				return this.contactsName;
			}
		}


		public virtual string IdCardBackPhotoUri
		{
			set
			{
				this.idCardBackPhotoUri = value;
			}
			get
			{
				return this.idCardBackPhotoUri;
			}
		}


		public virtual string IdCardFrontPhotoUri
		{
			set
			{
				this.idCardFrontPhotoUri = value;
			}
			get
			{
				return this.idCardFrontPhotoUri;
			}
		}


		public virtual string IdCardInHandPhotoUri
		{
			set
			{
				this.idCardInHandPhotoUri = value;
			}
			get
			{
				return this.idCardInHandPhotoUri;
			}
		}


		public virtual string IdCardName
		{
			set
			{
				this.idCardName = value;
			}
			get
			{
				return this.idCardName;
			}
		}


		public virtual string IdCardNo
		{
			set
			{
				this.idCardNo = value;
			}
			get
			{
				return this.idCardNo;
			}
		}


		public virtual long? IdCardType
		{
			set
			{
				this.idCardType = value;
			}
			get
			{
				return this.idCardType;
			}
		}


		public virtual long? IdEffectiveFrom
		{
			set
			{
				this.idEffectiveFrom = value;
			}
			get
			{
				return this.idEffectiveFrom;
			}
		}


		public virtual long? IdExpiredOn
		{
			set
			{
				this.idExpiredOn = value;
			}
			get
			{
				return this.idExpiredOn;
			}
		}


		public virtual string OrganizationCode
		{
			set
			{
				this.organizationCode = value;
			}
			get
			{
				return this.organizationCode;
			}
		}


		public virtual string OrganizationCodePhotoUri
		{
			set
			{
				this.organizationCodePhotoUri = value;
			}
			get
			{
				return this.organizationCodePhotoUri;
			}
		}


		public virtual string OutUserNo
		{
			set
			{
				this.outUserNo = value;
			}
			get
			{
				return this.outUserNo;
			}
		}


		public virtual string ResultNoticeUri
		{
			set
			{
				this.resultNoticeUri = value;
			}
			get
			{
				return this.resultNoticeUri;
			}
		}


		public virtual string ServiceDesc
		{
			set
			{
				this.serviceDesc = value;
			}
			get
			{
				return this.serviceDesc;
			}
		}


		public virtual long? ServiceMerchantNo
		{
			set
			{
				this.serviceMerchantNo = value;
			}
			get
			{
				return this.serviceMerchantNo;
			}
		}


		public virtual string ServiceTel
		{
			set
			{
				this.serviceTel = value;
			}
			get
			{
				return this.serviceTel;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (bizEffectiveFrom != null)
			{
				@params["biz_effective_from"] = bizEffectiveFrom;
			}
			if (bizExpiredOn != null)
			{
				@params["biz_expired_on"] = bizExpiredOn;
			}
			if (!string.ReferenceEquals(businessAddress, null))
			{
				@params["business_address"] = businessAddress;
			}
			if (!string.ReferenceEquals(businessLicense, null))
			{
				@params["business_license"] = businessLicense;
			}
			if (!string.ReferenceEquals(businessLicensePhotoUri, null))
			{
				@params["business_license_photo_uri"] = businessLicensePhotoUri;
			}
			if (!string.ReferenceEquals(businessName, null))
			{
				@params["business_name"] = businessName;
			}
			if (!string.ReferenceEquals(businessScope, null))
			{
				@params["business_scope"] = businessScope;
			}
			if (!string.ReferenceEquals(contactMail, null))
			{
				@params["contact_mail"] = contactMail;
			}
			if (!string.ReferenceEquals(contactPhone, null))
			{
				@params["contact_phone"] = contactPhone;
			}
			if (!string.ReferenceEquals(contactsName, null))
			{
				@params["contacts_name"] = contactsName;
			}
			if (!string.ReferenceEquals(idCardBackPhotoUri, null))
			{
				@params["id_card_back_photo_uri"] = idCardBackPhotoUri;
			}
			if (!string.ReferenceEquals(idCardFrontPhotoUri, null))
			{
				@params["id_card_front_photo_uri"] = idCardFrontPhotoUri;
			}
			if (!string.ReferenceEquals(idCardInHandPhotoUri, null))
			{
				@params["id_card_in_hand_photo_uri"] = idCardInHandPhotoUri;
			}
			if (!string.ReferenceEquals(idCardName, null))
			{
				@params["id_card_name"] = idCardName;
			}
			if (!string.ReferenceEquals(idCardNo, null))
			{
				@params["id_card_no"] = idCardNo;
			}
			if (idCardType != null)
			{
				@params["id_card_type"] = idCardType;
			}
			if (idEffectiveFrom != null)
			{
				@params["id_effective_from"] = idEffectiveFrom;
			}
			if (idExpiredOn != null)
			{
				@params["id_expired_on"] = idExpiredOn;
			}
			if (!string.ReferenceEquals(organizationCode, null))
			{
				@params["organization_code"] = organizationCode;
			}
			if (!string.ReferenceEquals(organizationCodePhotoUri, null))
			{
				@params["organization_code_photo_uri"] = organizationCodePhotoUri;
			}
			if (!string.ReferenceEquals(outUserNo, null))
			{
				@params["out_user_no"] = outUserNo;
			}
			if (!string.ReferenceEquals(resultNoticeUri, null))
			{
				@params["result_notice_uri"] = resultNoticeUri;
			}
			if (!string.ReferenceEquals(serviceDesc, null))
			{
				@params["service_desc"] = serviceDesc;
			}
			if (serviceMerchantNo != null)
			{
				@params["service_merchant_no"] = serviceMerchantNo;
			}
			if (!string.ReferenceEquals(serviceTel, null))
			{
				@params["service_tel"] = serviceTel;
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