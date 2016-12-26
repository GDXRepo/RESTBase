namespace RESTBase.Web
{
	public abstract class BaseRequest : IRequest
	{
		public abstract bool IsValid();

		public static IResponse CreateSuccessResponse(IResponseData response)
		{
			return new BaseResponse
			{
				Result = response,
				Error = null
			};
		}

		public static IResponse CreateErrorResponse(ErrorCode code)
		{
			var tuple = ErrorDescription.For(code);

			return new BaseResponse
			{
				Result = null,
				Error = new ErrorData(tuple.Item1, tuple.Item2)
			};
		}

		public static bool Validate(IRequest request)
		{
			return (request != null && request.IsValid());
		}
	}
}
