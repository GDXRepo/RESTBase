using LinqToDB.Data;
using RESTBase.Data.Models;

namespace RESTBase.Data.DAL
{
	/// <summary>
	/// Encapsulates database table schemas mapping.
	/// </summary>
	public class DB : DataConnection
	{
		static DB() {
			var fmb = LinqToDB.Mapping.MappingSchema.Default.GetFluentMappingBuilder();

			/* custom column names example:
			 
			   var itemMappingBuilder = fmb.Entity<Item>()
                   .HasTableName("Item")
                   .HasIdentity(x => x.Id)
                   .HasPrimaryKey(x => x.Id);
               itemMappingBuilder.Property(x => x.Name).HasColumnName("SomeName"); */

			// Utils

			fmb.Entity<Translate>()
			   .HasTableName("translate")
			   .HasPrimaryKey(x => x.translate_id)
			   .HasIdentity(x => x.translate_id);
		}

		public DB() : base("Lure") {
			
		}
	}
}
