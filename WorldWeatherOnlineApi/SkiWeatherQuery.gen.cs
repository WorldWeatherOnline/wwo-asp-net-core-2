
using System;

namespace WorldWeatherOnline
{
	/// <summary>
	/// Class used to construct query to ski weather Api 
	/// </summary>
	/// <remarks>
	/// Full documentation for REST service can be found at https://developer.worldweatheronline.com/api/docs/ski-weather-api.aspx
	/// </remarks>
	public partial class SkiWeatherQuery
    {
		
		
		/// <summary>
		/// Location: Finds the nearest ski and mountain location for the provided search criteria.
		///<para /> City name (ex: 'New York', 'New York,ny', 'London,united kingdom'), 
		///<para /> ip address (ex: '101.25.32.325'), 
		///<para /> US zip code, UK postcode, Canada postal code (ex: 'SW1', '90201')
		///<para /> or lot/lan coordinates (ex: 48.834,2.394)
		/// </summary>
		public string Location { get; set; }

		/// <summary>
		/// Sets Location and returns modified query
		/// </summary>
		/// <param name="location">Finds the nearest ski and mountain location for the provided search criteria.
		///<para /> City name (ex: 'New York', 'New York,ny', 'London,united kingdom'), 
		///<para /> ip address (ex: '101.25.32.325'), 
		///<para /> US zip code, UK postcode, Canada postal code (ex: 'SW1', '90201')
		///<para /> or lot/lan coordinates (ex: 48.834,2.394)</param>
		/// <returns>this</returns>
		public SkiWeatherQuery WithLocation (string location) { 
			this.Location = location;
			return this;
		}



		
		/// <summary>
		/// NumOfDays: Number of days of forecast
		/// </summary>
		public int? NumOfDays { get; set; }

		/// <summary>
		/// Sets NumOfDays and returns modified query
		/// </summary>
		/// <param name="num_of_days">Number of days of forecast</param>
		/// <returns>this</returns>
		public SkiWeatherQuery WithNumOfDays (int? num_of_days) { 
			this.NumOfDays = num_of_days;
			return this;
		}



		
		/// <summary>
		/// Date: Specifies weather for a date
		/// </summary>
		public DateTime? Date { get; set; }

		/// <summary>
		/// Sets Date and returns modified query
		/// </summary>
		/// <param name="date">Specifies weather for a date</param>
		/// <returns>this</returns>
		public SkiWeatherQuery WithDate (DateTime? date) { 
			this.Date = date;
			return this;
		}



		
		/// <summary>
		/// IncludeLocation: Whether to return the nearest weather point for which the weather data is returned for a given postcode, zipcode and lat/lon values. Default: false
		/// </summary>
		public bool? IncludeLocation { get; set; }

		/// <summary>
		/// Sets IncludeLocation and returns modified query
		/// </summary>
		/// <param name="include_location">Whether to return the nearest weather point for which the weather data is returned for a given postcode, zipcode and lat/lon values. Default: false</param>
		/// <returns>this</returns>
		public SkiWeatherQuery WithIncludeLocation (bool? include_location) { 
			this.IncludeLocation = include_location;
			return this;
		}



		
		/// <summary>
		/// IsDayTime: Adds yes for day and no for night time period. Note: This parameter only works with 3 hourly, 6 hourly or 12 hourly intervals. Default: false
		/// </summary>
		public bool? IsDayTime { get; set; }

		/// <summary>
		/// Sets IsDayTime and returns modified query
		/// </summary>
		/// <param name="isDayTime">Adds yes for day and no for night time period. Note: This parameter only works with 3 hourly, 6 hourly or 12 hourly intervals. Default: false</param>
		/// <returns>this</returns>
		public SkiWeatherQuery WithIsDayTime (bool? isDayTime) { 
			this.IsDayTime = isDayTime;
			return this;
		}


		private string _buildQueryString(){
			var s = "";
			if(Location != null){
				s+= $"&q={Location}";
			}
			if(NumOfDays != null){
				s+= $"&num_of_days={NumOfDays}";
			}
			if(Date != null){
				s+= $"&date={Date.Value.ToString("yyyy-MM-dd")}";
			}
			if(IncludeLocation != null){
				s+= $"&includelocation={(IncludeLocation.Value ? "yes" : "no")}";
			}
			return "ski.ashx?" + s.Substring(1);
		}
    }
}

