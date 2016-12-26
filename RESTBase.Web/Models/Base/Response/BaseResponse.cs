namespace RESTBase.Web
{
	public class BaseResponse : IResponse
	{
		public ErrorData Error { get; set; }
		public IResponseData Result { get; set; }
	}
}
