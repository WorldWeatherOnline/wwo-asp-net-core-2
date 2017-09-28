
using System;

namespace WorldWeatherOnline
{
	/// <summary>
	/// Class used to construct query to historical weather Api 
	/// </summary>
	/// <remarks>
	/// Full documentation for REST service can be found at https://developer.worldweatheronline.com/api/docs/historical-weather-api.aspx
	/// </remarks>
	public partial class PastWeatherQuery
    {
		
		
		/// <summary>
		/// Location: City name (ex: 'New York', 'New York,ny', 'London,united kingdom'), 
		///<para /> ip address (ex: '101.25.32.325'), 
		///<para /> US zip code, UK postcode, Canada postal code (ex: 'SW1', '90201')
		///<para /> or lot/lan coordinates (ex: 48.834,2.394)
		/// </summary>
		public string Location { get; set; }

		/// <summary>
		/// Sets Location and returns modified query
		/// </summary>
		/// <param name="location">City name (ex: 'New York', 'New York,ny', 'London,united kingdom'), 
		///<para /> ip address (ex: '101.25.32.325'), 
		///<para /> US zip code, UK postcode, Canada postal code (ex: 'SW1', '90201')
		///<para /> or lot/lan coordinates (ex: 48.834,2.394)</param>
		/// <returns>this</returns>
		public PastWeatherQuery WithLocation (string location) { 
			this.Location = location;
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
		public PastWeatherQuery WithDate (DateTime? date) { 
			this.Date = date;
			return this;
		}



		
		/// <summary>
		/// Enddate: If you wish to retrieve weather between two dates, use this parameter to specify the ending date. 
		///<para /> Important: the enddate parameter must have the same month and year as the date parameter.
		/// </summary>
		public DateTime? Enddate { get; set; }

		/// <summary>
		/// Sets Enddate and returns modified query
		/// </summary>
		/// <param name="enddate">If you wish to retrieve weather between two dates, use this parameter to specify the ending date. 
		///<para /> Important: the enddate parameter must have the same month and year as the date parameter.</param>
		/// <returns>this</returns>
		public PastWeatherQuery WithEnddate (DateTime? enddate) { 
			this.Enddate = enddate;
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
		public PastWeatherQuery WithIncludeLocation (bool? include_location) { 
			this.IncludeLocation = include_location;
			return this;
		}



		/// <summary>
		/// Available options for Interval
		/// </summary>
		public enum IntervalOptions {
			ONE_HOUR = 1,
			TWO_HOURS = 2,
			THREE_HOURS = 3,
			SIX_HOURS = 6,
			TWELVE_HOURS = 12,
			TWENTY_FOUR_HOURS = 24
		}

		/// <summary>
		/// Interval: Specifies the weather forecast time interval in hours. Options are: 1 hour, 3 hourly, 6 hourly, 12 hourly (day/night) or 24 hourly (day average). Default: 3
		/// </summary>
		public IntervalOptions? Interval { get; set; }

		/// <summary>
		/// Sets Interval and returns modified query
		/// </summary>
		/// <param name="interval">Specifies the weather forecast time interval in hours. Options are: 1 hour, 3 hourly, 6 hourly, 12 hourly (day/night) or 24 hourly (day average). Default: 3</param>
		/// <returns>this</returns>
		public PastWeatherQuery WithInterval (IntervalOptions? interval) { 
			this.Interval = interval;
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
		public PastWeatherQuery WithIsDayTime (bool? isDayTime) { 
			this.IsDayTime = isDayTime;
			return this;
		}



		
		/// <summary>
		/// UtcDateTime: Time intervals are displayed in UTC format instead of locate date and time. Default: false
		/// </summary>
		public bool? UtcDateTime { get; set; }

		/// <summary>
		/// Sets UtcDateTime and returns modified query
		/// </summary>
		/// <param name="utcDateTime">Time intervals are displayed in UTC format instead of locate date and time. Default: false</param>
		/// <returns>this</returns>
		public PastWeatherQuery WithUtcDateTime (bool? utcDateTime) { 
			this.UtcDateTime = utcDateTime;
			return this;
		}


		private string _buildQueryString(){
			var s = "";
			if(Location != null){
				s+= $"&q={Location}";
			}
			if(Date != null){
				s+= $"&date={Date.Value.ToString("yyyy-MM-dd")}";
			}
			if(Enddate != null){
				s+= $"&enddate={Enddate.Value.ToString("yyyy-MM-dd")}";
			}
			if(IncludeLocation != null){
				s+= $"&includelocation={(IncludeLocation.Value ? "yes" : "no")}";
			}
			if(Interval != null){
				s+= $"&tp={(int)Interval.Value}";
			}
			return "past-weather.ashx?" + s.Substring(1);
		}
    }
}

