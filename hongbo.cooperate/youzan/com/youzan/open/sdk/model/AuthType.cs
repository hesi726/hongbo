namespace com.youzan.open.sdk.model
{

    public enum AuthType
    {
        SIGN,

        Token
    }

    /*
	/// <summary>
	/// @author ph0ly
	/// @time 2016-11-28
	/// </summary>
	public sealed class AuthType
	{

		public static readonly AuthType SIGN = new AuthType("SIGN", InnerEnum.SIGN, "sign");
		public static readonly AuthType TOKEN = new AuthType("TOKEN", InnerEnum.TOKEN, "token");

		private static readonly IList<AuthType> valueList = new List<AuthType>();

		static AuthType()
		{
			valueList.Add(SIGN);
			valueList.Add(TOKEN);
		}

		public enum InnerEnum
		{
			SIGN,
			TOKEN
		}

		private readonly string nameValue;
		private readonly int ordinalValue;
		private readonly InnerEnum innerEnumValue;
		private static int nextOrdinal = 0;

		private string value;

		internal AuthType(string name, InnerEnum innerEnum, string value)
		{
			this.value = value;

			nameValue = name;
			ordinalValue = nextOrdinal++;
			innerEnumValue = innerEnum;
		}

		public string Value
		{
			get
			{
				return value;
			}
		}

		public static IList<AuthType> values()
		{
			return valueList;
		}

		public InnerEnum InnerEnumValue()
		{
			return innerEnumValue;
		}

		public int ordinal()
		{
			return ordinalValue;
		}

		public override string ToString()
		{
			return nameValue;
		}

		public static AuthType valueOf(string name)
		{
			foreach (AuthType enumInstance in AuthType.values())
			{
				if (enumInstance.nameValue == name)
				{
					return enumInstance;
				}
			}
			throw new System.ArgumentException(name);
		}
	}*/

}