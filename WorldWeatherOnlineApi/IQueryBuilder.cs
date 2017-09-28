using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace WorldWeatherOnline
{
    public interface IQueryBuilder<T>
    {
		string BuildQueryString();
    }

	/// <summary>
	/// Base class for query builders
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class QueryBuilder<T> : IQueryBuilder<T> {
		/// <summary>
		/// Api instance that will be used to execute queries
		/// </summary>
		public Api Api { get; set; }

		public abstract string BuildQueryString();

		/// <summary>
		/// Execute query and get results as c# object
		/// </summary>
		/// <param name="api">Api instance. Is not required if it was provided in constructor or provided by builder</param>
		/// <returns>Response object</returns>
		public async Task<T> GetResult(Api api = null)
		{
			var _api = api ?? this.Api;
			return await _api.GetResult(this);
		}


		/// <summary>
		/// Execute query and get results as plain json text
		/// </summary>
		/// <param name="api">Api instance. Is not required if it was provided in constructor or provided by builder</param>
		/// <returns>Json response as plain text</returns>
		public async Task<string> GetResultAsJson(Api api = null)
		{
			var _api = api ?? this.Api;
			return await _api.GetResultAsJson(this);
		}

		/// <summary>
		/// Execute query and get results as plain xml text
		/// </summary>
		/// <param name="api">Api instance. Is not required if it was provided in constructor or provided by builder</param>
		/// <returns>xml response as plain text</returns>
		public async Task<string> GetResultAsXml(Api api = null)
		{
			var _api = api ?? this.Api;
			return await _api.GetResultAsXml(this);
		}

		/// <summary>
		/// Execute query and get results as plain csv text
		/// </summary>
		/// <param name="api">Api instance. Is not required if it was provided in constructor or provided by builder</param>
		/// <returns>csv response as plain text</returns>
		public async Task<string> GetResultAsCsv(Api api = null)
		{
			var _api = api ?? this.Api;
			return await _api.GetResultAsCsv(this);
		}

		/// <summary>
		/// Execute query and get results as plain tsv text
		/// </summary>
		/// <param name="api">Api instance. Is not required if it was provided in constructor or provided by builder</param>
		/// <returns>tsv response as plain text</returns>
		public async Task<string> GetResultAsTsv(Api api = null)
		{
			var _api = api ?? this.Api;
			return await _api.GetResultAsTsv(this);
		}
	}
}
