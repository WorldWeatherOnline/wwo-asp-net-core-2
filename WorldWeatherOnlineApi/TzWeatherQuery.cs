
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;


namespace WorldWeatherOnline
{
	/// <summary>
	/// Class used to construct query to timezone weather Api 
	/// </summary>
	/// <remarks>
	/// Full documentation for REST service can be found at https://developer.worldweatheronline.com/api/docs/time-zone-api.aspx
	/// </remarks>
	public partial class TzWeatherQuery : QueryBuilder<TzWeatherResponse.RootObject>
    {
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="location"></param>
		/// <param name="api"></param>
		public TzWeatherQuery(string location, Api api = null) {
			this.Location = location;
			this.Api = api;
		}


		public override string BuildQueryString()
		{
			var s = _buildQueryString();
			return s;
		}
	}
}

