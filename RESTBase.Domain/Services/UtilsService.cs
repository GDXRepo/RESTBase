using RESTBase.Data.Models;

namespace RESTBase.Domain
{
	public sealed class UtilsService : IUtilsService
	{
		IAdapter _adapter;

		public UtilsService(IAdapter adapter) {
			_adapter = adapter;
		}

		public Translate Translate(string tag)
		{
			return _adapter.GetFirstOrDefault<Translate>(x => x.loctag == tag);
		}
	}
}
