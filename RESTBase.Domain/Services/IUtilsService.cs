using RESTBase.Data.Models;

namespace RESTBase.Domain
{
	public interface IUtilsService
	{
		/// <summary>
		/// Returns "translate" table row content for the specified tag.
		/// </summary>
		/// <param name="tag">Localization tag.</param>
		Translate Translate(string tag);
	}
}
