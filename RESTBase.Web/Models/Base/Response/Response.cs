namespace RESTBase.Web
{
	public sealed class ResponseWrapper : IResponse
	{
		public IResponseData Result { get; set; }
		public ErrorData Error { get; set; }

		ResponseWrapper() { }

		public static IResponse Success(IResponseData response) 
		{
			return new ResponseWrapper
			{
				Result = response,
				Error = null
			};
		}

		public static IResponse Failure(ErrorCode code)
		{
			var tuple = ErrorDescription.For(code);

			return new ResponseWrapper
			{
				Result = null,
				Error = new ErrorData(tuple.Item1, tuple.Item2)
			};
		}
	}
}
