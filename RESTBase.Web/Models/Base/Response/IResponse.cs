namespace RESTBase.Web
{
	public interface IResponse
	{
		IResponseData Result { get; set; }
		ErrorData Error { get; set; }
	}
}
