namespace RESTBase.Web
{
	public sealed class ErrorData : IResponseData
	{
		public int Code { get; }
		public string Message { get; }

		public ErrorData(ErrorCode code, string message) 
		{
			Code = (int)code;
			Message = message.Trim();
		}
	}
}
