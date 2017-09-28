
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;


namespace WorldWeatherOnline
{
	/// <summary>
	/// Class used to construct query to historical weather Api 
	/// </summary>
	/// <remarks>
	/// Full documentation for REST service can be found at https://developer.worldweatheronline.com/api/docs/historical-weather-api.aspx
	/// </remarks>
	public partial class PastWeatherQuery : QueryBuilder<PastWeatherResponse.RootObject>
    {
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="location"></param>
		/// <param name="api"></param>
		public PastWeatherQuery(string location, DateTime date, Api api = null) {
			this.Location = location;
			this.Date = date;
			this.Api = api;
		}


		public override string BuildQueryString()
		{
			var s = _buildQueryString();
			var extras = new[] {
					(IsDayTime ?? false) ? "isDayTime" : null,
					(UtcDateTime ?? false) ? "utcDateTime" : null,
				}
				.Where(x=>x!=null)
				.ToList();
			if (extras.Count > 0) {
				s += $"&extra={string.Join(",", extras)}";
			}
			return s;
		}
	}
}

