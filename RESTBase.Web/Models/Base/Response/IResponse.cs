namespace RESTBase.Web
{
	public interface IResponse
	{
		ErrorData Error { get; set; }
		IResponseData Result { get; set; }
	}
}
