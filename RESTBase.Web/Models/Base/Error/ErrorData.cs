namespace RESTBase.Web
{
	public sealed class ErrorData : IResponseData
	{
		public int Code { get; }
		public string Message { get; }

		public ErrorData(int code, string message) 
		{
			Code = code;
			Message = message.Trim();
		}
	}
}
