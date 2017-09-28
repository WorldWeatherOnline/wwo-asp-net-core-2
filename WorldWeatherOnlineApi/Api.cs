using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WorldWeatherOnline
{
    public class Api
    {
		static string url = "http://api.worldweatheronline.com/premium/v1/";
		public string Key { get; set; }

		/// <summary>
		/// Api instance
		/// </summary>
		/// <param name="key">api key</param>
		public Api(string key) {
			this.Key = key;
		}

		/// <summary>
		/// Returns object to configure query for local weather endpoint
		/// </summary>
		/// <param name="location">City name (ex: 'New York', 'New York,ny', 'London,united kingdom'), 
		///<para /> ip address (ex: '101.25.32.325'), 
		///<para /> US zip code, UK postcode, Canada postal code (ex: 'SW1', '90201')
		///<para /> or lot/lan coordinates (ex: 48.834,2.394)</param>
		/// <returns>LocalWeatherQuery instance</returns>
		public LocalWeatherQuery BuildLocalWeatherQuery(string location)
		{
			var query = new LocalWeatherQuery(location, this);
			return query;
		}

		/// <summary>
		/// Returns object to configure query for ski weather endpoint
		/// </summary>
		/// <param name="location">City name (ex: 'New York', 'New York,ny', 'London,united kingdom'), 
		///<para /> ip address (ex: '101.25.32.325'), 
		///<para /> US zip code, UK postcode, Canada postal code (ex: 'SW1', '90201')
		///<para /> or lot/lan coordinates (ex: 48.834,2.394)</param>
		/// <param name="days">Number of days to show data for</param>
		/// <returns>LocalWeatherQuery instance</returns>
		public SkiWeatherQuery BuildSkiWeatherQuery(string location, int days)
		{
			var query = new SkiWeatherQuery(location, days, this);
			return query;
		}

		/// <summary>
		/// Returns object to configure query for marine weather endpoint
		/// </summary>
		/// <param name="location">City name (ex: 'New York', 'New York,ny', 'London,united kingdom'), 
		///<para /> ip address (ex: '101.25.32.325'), 
		///<para /> US zip code, UK postcode, Canada postal code (ex: 'SW1', '90201')
		///<para /> or lot/lan coordinates (ex: 48.834,2.394)</param>
		/// <returns>MarineWeatherQuery instance</returns>
		public MarineWeatherQuery BuildMarineWeatherQuery(string location)
		{
			var query = new MarineWeatherQuery(location, this);
			return query;
		}
		/// <summary>
		/// Returns object to configure query for marine weather endpoint
		/// </summary>
		/// <param name="location">City name (ex: 'New York', 'New York,ny', 'London,united kingdom'), 
		///<para /> ip address (ex: '101.25.32.325'), 
		///<para /> US zip code, UK postcode, Canada postal code (ex: 'SW1', '90201')
		///<para /> or lot/lan coordinates (ex: 48.834,2.394)</param>
		/// <returns>MarineWeatherQuery instance</returns>
		public PastMarineWeatherQuery BuildPastMarineWeatherQuery(string location, DateTime date)
		{
			var query = new PastMarineWeatherQuery(location, date, this);
			return query;
		}

		/// <summary>
		/// Returns object to configure query for historical weather endpoint
		/// </summary>
		/// <param name="location">City name (ex: 'New York', 'New York,ny', 'London,united kingdom'), 
		///<para /> ip address (ex: '101.25.32.325'), 
		///<para /> US zip code, UK postcode, Canada postal code (ex: 'SW1', '90201')
		///<para /> or lot/lan coordinates (ex: 48.834,2.394)</param>
		/// <returns>LocalWeatherQuery instance</returns>
		public PastWeatherQuery BuildPastWeatherQuery(string location, DateTime startDate)
		{
			var query = new PastWeatherQuery(location, startDate, this);
			return query;
		}

		/// <summary>
		/// Returns object to configure query for search weather endpoint
		/// </summary>
		/// <param name="location">City name (ex: 'New York', 'New York,ny', 'London,united kingdom'), 
		///<para /> ip address (ex: '101.25.32.325'), 
		///<para /> US zip code, UK postcode, Canada postal code (ex: 'SW1', '90201')
		///<para /> or lot/lan coordinates (ex: 48.834,2.394)</param>
		/// <returns>LocalWeatherQuery instance</returns>
		public SearchWeatherQuery BuildSearchWeatherQuery(string loc)
		{
			var query = new SearchWeatherQuery(loc, this);
			return query;
		}

		/// <summary>
		/// Returns object to configure query for timezone endpoint
		/// </summary>
		/// <param name="location">City name (ex: 'New York', 'New York,ny', 'London,united kingdom'), 
		///<para /> ip address (ex: '101.25.32.325'), 
		///<para /> US zip code, UK postcode, Canada postal code (ex: 'SW1', '90201')
		///<para /> or lot/lan coordinates (ex: 48.834,2.394)</param>
		/// <returns>LocalWeatherQuery instance</returns>
		public TzWeatherQuery BuildTzWeatherQuery(string loc)
		{
			var query = new TzWeatherQuery(loc, this);
			return query;
		}


		private async Task<string> GetQueryResultText(string url, string format) {
			var client = new HttpClient();
			return await client.GetStringAsync($"{url}&format={format}&key={Key}");
		}

		/// <summary>
		/// Executes query and return data in json format
		/// </summary>
		/// <param name="qb">Query object</param>
		/// <returns>json text</returns>
		public async Task<string> GetResultAsJson<T>(IQueryBuilder<T> qb)
		{
			return await GetQueryResultText($"{url}{qb.BuildQueryString()}", "json");
		}

		/// <summary>
		/// Executes query and return data in XML format
		/// </summary>
		/// <param name="qb">Query object</param>
		/// <returns>xml text</returns>
		public async Task<string> GetResultAsXml<T>(IQueryBuilder<T> qb)
		{
			return await GetQueryResultText($"{url}{qb.BuildQueryString()}", "xml");
		}

		/// <summary>
		/// Executes query and return data in CSV format
		/// </summary>
		/// <param name="qb">Query object</param>
		/// <returns>csv text</returns>
		public async Task<string> GetResultAsCsv<T>(IQueryBuilder<T> qb)
		{
			return await GetQueryResultText($"{url}{qb.BuildQueryString()}", "csv");
		}

		/// <summary>
		/// Executes query and return data in TSV format
		/// </summary>
		/// <param name="qb">Query object</param>
		/// <returns>tsv text</returns>
		public async Task<string> GetResultAsTsv<T>(IQueryBuilder<T> qb)
		{
			return await GetQueryResultText($"{url}{qb.BuildQueryString()}", "tab");
		}

		/// <summary>
		/// Execute query and get results as c# object
		/// </summary>
		/// <param name="api">Api instance. Is not required if it was provided in constructor or provided by builder</param>
		/// <returns>Response object</returns>
		public async Task<T> GetResult<T>(IQueryBuilder<T> qb)
		{
			var ser = new Newtonsoft.Json.JsonSerializer();
			return JsonConvert.DeserializeObject<T>(await GetQueryResultText($"{url}{qb.BuildQueryString()}", "json"));
		}
	}
}
