using RESTBase.Data.Models;

namespace RESTBase.Web
{
	public class TranslateResponseData : IResponseData
	{
		public string Tag { get; set; }
		public string Translation { get; set; }

		public TranslateResponseData(Translate t)
		{
			if (t != null)
			{
				Tag = t.loctag;
				Translation = t.value;
			}
		}
	}
}
