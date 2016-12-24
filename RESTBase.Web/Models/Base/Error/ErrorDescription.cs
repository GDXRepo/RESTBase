using System;

namespace RESTBase.Web
{
	public static class ErrorDescription
	{
		static readonly int[] Codes;
		static readonly string[] Descriptions;

		static ErrorDescription()
		{
			Codes = new int[]
			{
				400
			};
			Descriptions = new string[]
			{
				"Bad Request"
			};
		}

		public static Tuple<int, string> For(ErrorCode code)
		{
			var index = (int)code;
			return new Tuple<int, string>(Codes[index], Descriptions[index]);
		}
	}
}
