namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;

    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanRetailStockVendorCreateResult : APIResult
	{



		/// <summary>
		/// 供应商详情
		/// </summary>
[Newtonsoft.Json.JsonProperty("VendorVO")]//) private VendorVO VendorVO;
		private VendorVO _VendorVO;

		public virtual void setVendorVO(VendorVO VendorVO)
		{
			this._VendorVO = VendorVO;
		}

		public virtual VendorVO getVendorVO()
		{
			return this._VendorVO;
		}

		public class VendorVO
		{


			/// <summary>
			/// qq
			/// </summary>
[Newtonsoft.Json.JsonProperty("qq")]//) private String qq;
				internal string qq;


			/// <summary>
			/// 联系人电话
			/// </summary>
[Newtonsoft.Json.JsonProperty("contacts_phone")]//) private String contactsPhone;
				internal string contactsPhone;


			/// <summary>
			/// 地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("address")]//) private String address;
				internal string address;


			/// <summary>
			/// 创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created_at")]//) private Nullable<long> createdAt;
				internal long? createdAt;


			/// <summary>
			/// 备注
			/// </summary>
[Newtonsoft.Json.JsonProperty("remark")]//) private String remark;
				internal string remark;


			/// <summary>
			/// 微信
			/// </summary>
[Newtonsoft.Json.JsonProperty("wei_xin")]//) private String weiXin;
				internal string weiXin;


			/// <summary>
			/// 店铺id
			/// </summary>
[Newtonsoft.Json.JsonProperty("kdt_id")]//) private Nullable<long> kdtId;
				internal long? kdtId;


			/// <summary>
			/// 更新时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("updated_at")]//) private Nullable<long> updatedAt;
				internal long? updatedAt;


			/// <summary>
			/// 供应商编码
			/// </summary>
[Newtonsoft.Json.JsonProperty("sno")]//) private String sno;
				internal string sno;


			/// <summary>
			/// 电话
			/// </summary>
[Newtonsoft.Json.JsonProperty("phone")]//) private String phone;
				internal string phone;


			/// <summary>
			/// 供应商id
			/// </summary>
[Newtonsoft.Json.JsonProperty("vendor_id")]//) private Nullable<long> vendorId;
				internal long? vendorId;


			/// <summary>
			/// 供应商名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
				internal string name;


			/// <summary>
			/// 传真
			/// </summary>
[Newtonsoft.Json.JsonProperty("fax")]//) private String fax;
				internal string fax;


			/// <summary>
			/// 联系人名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("contacts")]//) private String contacts;
				internal string contacts;


			/// <summary>
			/// 邮箱
			/// </summary>
[Newtonsoft.Json.JsonProperty("email")]//) private String email;
				internal string email;


			/// <summary>
			/// 状态
			/// </summary>
[Newtonsoft.Json.JsonProperty("status")]//) private Nullable<long> status;
				internal long? status;

				public virtual string Qq
				{
					set
					{
					this.qq = value;
					}
					get
					{
					return this.qq;
					}
				}


				public virtual string ContactsPhone
				{
					set
					{
					this.contactsPhone = value;
					}
					get
					{
					return this.contactsPhone;
					}
				}


				public virtual string Address
				{
					set
					{
					this.address = value;
					}
					get
					{
					return this.address;
					}
				}


				public virtual long? CreatedAt
				{
					set
					{
					this.createdAt = value;
					}
					get
					{
					return this.createdAt;
					}
				}


				public virtual string Remark
				{
					set
					{
					this.remark = value;
					}
					get
					{
					return this.remark;
					}
				}


				public virtual string WeiXin
				{
					set
					{
					this.weiXin = value;
					}
					get
					{
					return this.weiXin;
					}
				}


				public virtual long? KdtId
				{
					set
					{
					this.kdtId = value;
					}
					get
					{
					return this.kdtId;
					}
				}


				public virtual long? UpdatedAt
				{
					set
					{
					this.updatedAt = value;
					}
					get
					{
					return this.updatedAt;
					}
				}


				public virtual string Sno
				{
					set
					{
					this.sno = value;
					}
					get
					{
					return this.sno;
					}
				}


				public virtual string Phone
				{
					set
					{
					this.phone = value;
					}
					get
					{
					return this.phone;
					}
				}


				public virtual long? VendorId
				{
					set
					{
					this.vendorId = value;
					}
					get
					{
					return this.vendorId;
					}
				}


				public virtual string Name
				{
					set
					{
					this.name = value;
					}
					get
					{
					return this.name;
					}
				}


				public virtual string Fax
				{
					set
					{
					this.fax = value;
					}
					get
					{
					return this.fax;
					}
				}


				public virtual string Contacts
				{
					set
					{
					this.contacts = value;
					}
					get
					{
					return this.contacts;
					}
				}


				public virtual string Email
				{
					set
					{
					this.email = value;
					}
					get
					{
					return this.email;
					}
				}


				public virtual long? Status
				{
					set
					{
					this.status = value;
					}
					get
					{
					return this.status;
					}
				}


		}


	}
}