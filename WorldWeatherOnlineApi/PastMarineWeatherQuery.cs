
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;


namespace WorldWeatherOnline
{
	/// <summary>
	/// Class used to construct query to historical marine weather Api 
	/// </summary>
	/// <remarks>
	/// Full documentation for REST service can be found at https://developer.worldweatheronline.com/api/docs/historical-weather-api.aspx
	/// </remarks>
	public partial class PastMarineWeatherQuery : QueryBuilder<PastMarineWeatherResponse.RootObject>
    {
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="location"></param>
		/// <param name="api"></param> 
		public PastMarineWeatherQuery(string location, DateTime date, Api api = null) {
			this.Location = location;
			this.Date = date;
			this.Api = api;
		}


		public override string BuildQueryString()
		{
			var s = _buildQueryString();

			return s;
		}
	}
}

