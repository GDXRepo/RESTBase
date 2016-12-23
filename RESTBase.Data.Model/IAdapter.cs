using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RESTBase.Data.Models
{
	/// <summary>
	/// Database access adapter interface.
	/// </summary>
	public interface IAdapter : IDisposable
	{
		/// <summary>
		/// Gets all records.
		/// </summary>
		/// <returns>The all records.</returns>
		/// <typeparam name="T">Table model type.</typeparam>
		IEnumerable<T> GetAll<T>() where T : class;

		/// <summary>
		/// Gets all records which satisfies the given filtering expression.
		/// </summary>
		/// <returns>The filtered records.</returns>
		/// <param name="predicate">Predicate.</param>
		/// <typeparam name="T">Table model type.</typeparam>
		IEnumerable<T> GetWhere<T>(Expression<Func<T, bool>> predicate) where T : class;

		/// <summary>
		/// Gets the first record which satisfies the given filtering expression. If no records found then default value will be returned.
		/// </summary>
		/// <returns>The first filtered value or default value, if no records satisfies the filter.</returns>
		/// <param name="predicate">Predicate.</param>
		/// <typeparam name="T">Table model type.</typeparam>
		T GetFirstOrDefault<T>(Expression<Func<T, bool>> predicate) where T : class;

		/// <summary>
		/// Insert the specified item into a DB table.
		/// </summary>
		/// <param name="item">Item to insert.</param>
		/// <typeparam name="T">Table model type.</typeparam>
		void Insert<T>(T item) where T : class;

		/// <summary>
		/// Update the specified item in a DB table.
		/// </summary>
		/// <param name="item">Item to update.</param>
		/// <typeparam name="T">Table model type.</typeparam>
		void Update<T>(T item) where T : class;

		/// <summary>
		/// Delete the specified item.
		/// </summary>
		/// <param name="item">Item to remove.</param>
		/// <typeparam name="T">Table model type.</typeparam>
		void Delete<T>(T item) where T : class;
	}
}
