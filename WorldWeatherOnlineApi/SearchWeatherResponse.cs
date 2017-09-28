using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldWeatherOnline
{
	namespace SearchWeatherResponse
	{
		/// <summary>
		/// Holds value for a field
		/// </summary>
		public class Value
		{
			public string value { get; set; }
		}

		/// <summary>
		/// Search request result object
		/// </summary>
		public class Result
		{
			/// <summary>
			/// The name of the location.
			/// </summary>
			public List<Value> areaName { get; set; }
			/// <summary>
			/// The name of the location's country
			/// </summary>
			public List<Value> country { get; set; }
			/// <summary>
			/// The name of the location's region.
			/// </summary>
			public List<Value> region { get; set; }
			/// <summary>
			/// The location's latitude, in degrees.
			/// </summary>
			public string latitude { get; set; }
			/// <summary>
			/// The location's longitude, in degrees.
			/// </summary>
			public string longitude { get; set; }
			/// <summary>
			/// The location's population (if available).
			/// </summary>
			public int population { get; set; }
			/// <summary>
			/// The URL to the location's weather.
			/// </summary>
			public List<Value> weatherUrl { get; set; }
		}

		public class SearchApi
		{
			public List<Result> result { get; set; }
		}

		public class RootObject
		{
			public SearchApi search_api { get; set; }
		}
	}
}
