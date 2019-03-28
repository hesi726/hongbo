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

    public class YouzanRetailStockVendorCreateParams : APIParams, FileParams
	{

		/// <summary>
		/// 地址
		/// </summary>
		private string address;
		/// <summary>
		/// 联系人名称
		/// </summary>
		private string contacts;
		/// <summary>
		/// 联系人电话
		/// </summary>
		private string contactsPhone;
		/// <summary>
		/// 邮件
		/// </summary>
		private string email;
		/// <summary>
		/// 传真
		/// </summary>
		private string fax;
		/// <summary>
		/// 供应商名称
		/// </summary>
		private string name;
		/// <summary>
		/// 公司电话
		/// </summary>
		private string phone;
		/// <summary>
		/// qq号码
		/// </summary>
		private string qq;
		/// <summary>
		/// 备注
		/// </summary>
		private string remark;
		/// <summary>
		/// 供应商编码
		/// </summary>
		private string sno;
		/// <summary>
		/// 调用来源
		/// </summary>
		private string source;
		/// <summary>
		/// 是否启用  0 启用 1 禁用
		/// </summary>
		private long? status;
		/// <summary>
		/// 微信号码
		/// </summary>
		private string weiXin;

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


		public virtual string Source
		{
			set
			{
				this.source = value;
			}
			get
			{
				return this.source;
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



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(address, null))
			{
				@params["address"] = address;
			}
			if (!string.ReferenceEquals(contacts, null))
			{
				@params["contacts"] = contacts;
			}
			if (!string.ReferenceEquals(contactsPhone, null))
			{
				@params["contacts_phone"] = contactsPhone;
			}
			if (!string.ReferenceEquals(email, null))
			{
				@params["email"] = email;
			}
			if (!string.ReferenceEquals(fax, null))
			{
				@params["fax"] = fax;
			}
			if (!string.ReferenceEquals(name, null))
			{
				@params["name"] = name;
			}
			if (!string.ReferenceEquals(phone, null))
			{
				@params["phone"] = phone;
			}
			if (!string.ReferenceEquals(qq, null))
			{
				@params["qq"] = qq;
			}
			if (!string.ReferenceEquals(remark, null))
			{
				@params["remark"] = remark;
			}
			if (!string.ReferenceEquals(sno, null))
			{
				@params["sno"] = sno;
			}
			if (!string.ReferenceEquals(source, null))
			{
				@params["source"] = source;
			}
			if (status != null)
			{
				@params["status"] = status;
			}
			if (!string.ReferenceEquals(weiXin, null))
			{
				@params["wei_xin"] = weiXin;
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