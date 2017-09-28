using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldWeatherOnline
{
	namespace TzWeatherResponse
	{
		/// <summary>
		/// Request infor passed to service by user
		/// </summary>
		public class Request
		{
			public string type { get; set; }
			public string query { get; set; }
		}

		/// <summary>
		/// Holds value for field
		/// </summary>
		public class Value
		{
			public string value { get; set; }
		}

		/// <summary>
		/// Info for location closes to passed location
		/// </summary>
		public class NearestArea
		{
			/// <summary>
			/// area name
			/// </summary>
			public List<Value> areaName { get; set; }
			/// <summary>
			/// country name
			/// </summary>
			public List<Value> country { get; set; }
			/// <summary>
			/// region name
			/// </summary>
			public List<Value> region { get; set; }
			/// <summary>
			/// latitude of area
			/// </summary>
			public string latitude { get; set; }
			/// <summary>
			/// longitude of area
			/// </summary>
			public string longitude { get; set; }
			/// <summary>
			/// population of area
			/// </summary>
			public string population { get; set; }
			/// <summary>
			/// url for weather in area
			/// </summary>
			public List<Value> weatherUrl { get; set; }
		}

		/// <summary>
		/// Information about the timezone offset from GMT.
		/// </summary>
		public class TimeZone
		{
			/// <summary>
			/// The current local time.
			/// </summary>
			public string localtime { get; set; }
			/// <summary>
			/// UTC offset from GMT in hour and minute.
			/// </summary>
			public float utcOffset { get; set; }
		}

		/// <summary>
		/// request result data
		/// </summary>
		public class Data
		{
			public List<Request> request { get; set; }
			public List<NearestArea> nearest_area { get; set; }
			public List<TimeZone> time_zone { get; set; }
		}

		public class RootObject
		{
			public Data data { get; set; }
		}
	}
}
