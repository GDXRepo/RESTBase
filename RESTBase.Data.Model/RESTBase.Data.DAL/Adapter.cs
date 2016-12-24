using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LinqToDB;
using LinqToDB.Data;

namespace RESTBase.Data.DAL
{
	public class Adapter : Models.IAdapter
	{
		public IEnumerable<T> GetAll<T>() where T : class
		{
			using (var db = new DB())
			{
				return db.GetTable<T>().ToList();
			}
		}

		public T GetFirstOrDefault<T>(Expression<Func<T, bool>> predicate) where T : class
		{
			using (var db = new DB())
			{
				return db.GetTable<T>().FirstOrDefault(predicate);
			}
		}

		public IEnumerable<T> GetWhere<T>(Expression<Func<T, bool>> predicate) where T : class
		{
			using (var db = new DB()) 
			{
				return db.GetTable<T>().Where(predicate).ToList();
			}
		}

		public void Insert<T>(T item) where T : class
		{
			using (var db = new DB())
			{
				db.Insert(item);
			}
		}

		public void Update<T>(T item) where T : class
		{
			using (var db = new DB())
			{
				db.Update(item);
			}
		}

		public void Delete<T>(T item) where T : class
		{
			using (var db = new DB())
			{
				db.Delete(item);
			}
		}

		#region IDisposable Support
		bool disposedValue; // To detect redundant calls

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					// dispose managed state (managed objects).
				}
				// free unmanaged resources (unmanaged objects) and override a finalizer below.
				// set large fields to null.
				disposedValue = true;
			}
		}

		// This code added to correctly implement the disposable pattern.
		public void Dispose()
		{
			// Do not change this code. Put cleanup code in Dispose(bool disposing) above.
			Dispose(true);
			// uncomment the following line if the finalizer is overridden above.
			// GC.SuppressFinalize(this);
		}
		#endregion
	}
}
