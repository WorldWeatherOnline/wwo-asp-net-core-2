
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;


namespace WorldWeatherOnline
{
	/// <summary>
	/// Class used to construct query to local weather Api 
	/// </summary>
	/// <remarks>
	/// Full documentation for REST service can be found at https://developer.worldweatheronline.com/api/docs/local-city-town-weather-api.aspx
	/// </remarks>
	public partial class LocalWeatherQuery : QueryBuilder<LocalWeatherResponse.RootObject>
    {
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="location"></param>
		/// <param name="api"></param>
		public LocalWeatherQuery(string location, Api api = null) {
			this.Location = location;
			this.Api = api;
		}


		public override string BuildQueryString()
		{
			var s = _buildQueryString();
			var extras = new[] {
					(IsDayTime ?? false) ? "isDayTime" : null,
					(LocalObsTime ?? false) ? "localObsTime" : null,
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

