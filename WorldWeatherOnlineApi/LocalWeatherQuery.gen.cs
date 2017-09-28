
using System;

namespace WorldWeatherOnline
{
	/// <summary>
	/// Class used to construct query to local weather Api 
	/// </summary>
	/// <remarks>
	/// Full documentation for REST service can be found at https://developer.worldweatheronline.com/api/docs/local-city-town-weather-api.aspx
	/// </remarks>
	public partial class LocalWeatherQuery
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
		public LocalWeatherQuery WithLocation (string location) { 
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
		public LocalWeatherQuery WithNumOfDays (int? num_of_days) { 
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
		public LocalWeatherQuery WithDate (DateTime? date) { 
			this.Date = date;
			return this;
		}



		/// <summary>
		/// Available options for DateFormat
		/// </summary>
		public enum DateFormatOptions {
			UNIX,
			ISO8601
		}

		/// <summary>
		/// DateFormat: Specifies weather for a date
		/// </summary>
		public DateFormatOptions? DateFormat { get; set; }

		/// <summary>
		/// Sets DateFormat and returns modified query
		/// </summary>
		/// <param name="date_format">Specifies weather for a date</param>
		/// <returns>this</returns>
		public LocalWeatherQuery WithDateFormat (DateFormatOptions? date_format) { 
			this.DateFormat = date_format;
			return this;
		}



		
		/// <summary>
		/// Forecast: Whether to return weather forecast output. Default: true
		/// </summary>
		public bool? Forecast { get; set; }

		/// <summary>
		/// Sets Forecast and returns modified query
		/// </summary>
		/// <param name="forecast">Whether to return weather forecast output. Default: true</param>
		/// <returns>this</returns>
		public LocalWeatherQuery WithForecast (bool? forecast) { 
			this.Forecast = forecast;
			return this;
		}



		
		/// <summary>
		/// Conditions: Whether to return current weather conditions output. Default: true
		/// </summary>
		public bool? Conditions { get; set; }

		/// <summary>
		/// Sets Conditions and returns modified query
		/// </summary>
		/// <param name="conditions">Whether to return current weather conditions output. Default: true</param>
		/// <returns>this</returns>
		public LocalWeatherQuery WithConditions (bool? conditions) { 
			this.Conditions = conditions;
			return this;
		}



		
		/// <summary>
		/// MonthlyAverage: Whether to return monthly climate average data. Default: false
		/// </summary>
		public bool? MonthlyAverage { get; set; }

		/// <summary>
		/// Sets MonthlyAverage and returns modified query
		/// </summary>
		/// <param name="monthly_average">Whether to return monthly climate average data. Default: false</param>
		/// <returns>this</returns>
		public LocalWeatherQuery WithMonthlyAverage (bool? monthly_average) { 
			this.MonthlyAverage = monthly_average;
			return this;
		}



		
		/// <summary>
		/// ThreeHourInterval: Returns 24 hourly weather information in a 3 hourly interval response. Default: false
		/// </summary>
		public bool? ThreeHourInterval { get; set; }

		/// <summary>
		/// Sets ThreeHourInterval and returns modified query
		/// </summary>
		/// <param name="three_hour_interval">Returns 24 hourly weather information in a 3 hourly interval response. Default: false</param>
		/// <returns>this</returns>
		public LocalWeatherQuery WithThreeHourInterval (bool? three_hour_interval) { 
			this.ThreeHourInterval = three_hour_interval;
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
		public LocalWeatherQuery WithIncludeLocation (bool? include_location) { 
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
		public LocalWeatherQuery WithInterval (IntervalOptions? interval) { 
			this.Interval = interval;
			return this;
		}



		
		/// <summary>
		/// LocalTime: Whether to return the timezone information i.e. local time and offset hour and minute for the location. Default: false
		/// </summary>
		public bool? LocalTime { get; set; }

		/// <summary>
		/// Sets LocalTime and returns modified query
		/// </summary>
		/// <param name="local_time">Whether to return the timezone information i.e. local time and offset hour and minute for the location. Default: false</param>
		/// <returns>this</returns>
		public LocalWeatherQuery WithLocalTime (bool? local_time) { 
			this.LocalTime = local_time;
			return this;
		}



		
		/// <summary>
		/// Map: Returns series of GIF images for rain, snow and pressure map and surface temperature map. Default: false
		/// </summary>
		public bool? Map { get; set; }

		/// <summary>
		/// Sets Map and returns modified query
		/// </summary>
		/// <param name="map">Returns series of GIF images for rain, snow and pressure map and surface temperature map. Default: false</param>
		/// <returns>this</returns>
		public LocalWeatherQuery WithMap (bool? map) { 
			this.Map = map;
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
		public LocalWeatherQuery WithIsDayTime (bool? isDayTime) { 
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
		public LocalWeatherQuery WithUtcDateTime (bool? utcDateTime) { 
			this.UtcDateTime = utcDateTime;
			return this;
		}



		
		/// <summary>
		/// LocalObsTime: Adds the current weather observation time in UTC as well as local time of the location requested. Default: false
		/// </summary>
		public bool? LocalObsTime { get; set; }

		/// <summary>
		/// Sets LocalObsTime and returns modified query
		/// </summary>
		/// <param name="localObsTime">Adds the current weather observation time in UTC as well as local time of the location requested. Default: false</param>
		/// <returns>this</returns>
		public LocalWeatherQuery WithLocalObsTime (bool? localObsTime) { 
			this.LocalObsTime = localObsTime;
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
			if(DateFormat != null){
				s+= $"&date_format={DateFormat.ToString().ToLower()}";
			}
			if(Forecast != null){
				s+= $"&fx={(Forecast.Value ? "yes" : "no")}";
			}
			if(Conditions != null){
				s+= $"&cc={(Conditions.Value ? "yes" : "no")}";
			}
			if(MonthlyAverage != null){
				s+= $"&mca={(MonthlyAverage.Value ? "yes" : "no")}";
			}
			if(ThreeHourInterval != null){
				s+= $"&fx24={(ThreeHourInterval.Value ? "yes" : "no")}";
			}
			if(IncludeLocation != null){
				s+= $"&includelocation={(IncludeLocation.Value ? "yes" : "no")}";
			}
			if(Interval != null){
				s+= $"&tp={(int)Interval.Value}";
			}
			if(LocalTime != null){
				s+= $"&showlocaltime={(LocalTime.Value ? "yes" : "no")}";
			}
			if(Map != null){
				s+= $"&showmap={(Map.Value ? "yes" : "no")}";
			}
			return "weather.ashx?" + s.Substring(1);
		}
    }
}

