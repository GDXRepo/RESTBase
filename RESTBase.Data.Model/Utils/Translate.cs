namespace RESTBase.Data.Models
{
	public sealed class Translate
	{
		public int translate_id { get; set; }
		public int language_id { get; set; }
		public string loctag { get; set; }
		public string value { get; set; }
	}
}
