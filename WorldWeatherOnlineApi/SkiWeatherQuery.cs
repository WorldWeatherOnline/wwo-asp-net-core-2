
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;


namespace WorldWeatherOnline
{
	/// <summary>
	/// Class used to construct query to ski weather Api 
	/// </summary>
	/// <remarks>
	/// Full documentation for REST service can be found at https://developer.worldweatheronline.com/api/docs/ski-weather-api.aspx
	/// </remarks>
	public partial class SkiWeatherQuery : QueryBuilder<SkiWeatherResponse.RootObject>
    {
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="location"></param>
		/// <param name="api"></param>
		public SkiWeatherQuery(string location, int days, Api api = null) {
			this.Location = location;
			this.NumOfDays = days;
			this.Api = api;
		}


		public override string BuildQueryString()
		{
			var s = _buildQueryString();
			var extras = new[] {
					(IsDayTime ?? false) ? "isDayTime" : null,
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

