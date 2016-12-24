using RESTBase.Data.Models;

namespace RESTBase.Web
{
	public class TranslateResponse : IResponseData
	{
		public string Tag { get; set; }
		public string Translation { get; set; }

		public TranslateResponse(Translate t)
		{
			if (t != null)
			{
				Tag = t.loctag;
				Translation = t.value;
			}
		}
	}
}
