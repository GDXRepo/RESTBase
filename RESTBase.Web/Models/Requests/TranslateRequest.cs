namespace RESTBase.Web
{
	public class TranslateRequest : IRequest
	{
		public string Tag { get; set; }

		public bool Validate()
		{
			return Tag != null;
		}
	}
}
