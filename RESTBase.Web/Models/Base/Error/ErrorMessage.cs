using System;
using System.Collections.Generic;
using RESTBase.Web.App_GlobalResources;

namespace RESTBase.Web
{
	public enum ErrorCode
	{
		BadRequest = 400
	}

	public static class ErrorMessage
	{
		public static readonly Dictionary<int, string> Messages;

		static ErrorMessage()
		{
			Messages = new Dictionary<int, string>()
			{
				{(int)ErrorCode.BadRequest, AppResources.errors_badRequest}
			};
		}
	}
}
