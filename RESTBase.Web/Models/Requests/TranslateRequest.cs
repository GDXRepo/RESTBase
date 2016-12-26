namespace RESTBase.Web
{
	public class TranslateRequest : BaseRequest
	{
		public string Tag { get; set; }

		public override bool IsValid()
		{
			return Tag != null;
		}
	}
}
