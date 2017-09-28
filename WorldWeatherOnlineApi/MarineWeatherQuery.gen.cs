
using System;

namespace WorldWeatherOnline
{
	/// <summary>
	/// Class used to construct query to marine weather Api 
	/// </summary>
	/// <remarks>
	/// Full documentation for REST service can be found at https://developer.worldweatheronline.com/api/docs/marine-weather-api.aspx
	/// </remarks>
	public partial class MarineWeatherQuery
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
		public MarineWeatherQuery WithLocation (string location) { 
			this.Location = location;
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
		public MarineWeatherQuery WithForecast (bool? forecast) { 
			this.Forecast = forecast;
			return this;
		}



		
		/// <summary>
		/// Tide: To return tide data information if available. Default: false
		/// </summary>
		public bool? Tide { get; set; }

		/// <summary>
		/// Sets Tide and returns modified query
		/// </summary>
		/// <param name="tide">To return tide data information if available. Default: false</param>
		/// <returns>this</returns>
		public MarineWeatherQuery WithTide (bool? tide) { 
			this.Tide = tide;
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
		public MarineWeatherQuery WithInterval (IntervalOptions? interval) { 
			this.Interval = interval;
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
		public MarineWeatherQuery WithIncludeLocation (bool? include_location) { 
			this.IncludeLocation = include_location;
			return this;
		}


		private string _buildQueryString(){
			var s = "";
			if(Location != null){
				s+= $"&q={Location}";
			}
			if(Forecast != null){
				s+= $"&fx={(Forecast.Value ? "yes" : "no")}";
			}
			if(Tide != null){
				s+= $"&tide={(Tide.Value ? "yes" : "no")}";
			}
			if(Interval != null){
				s+= $"&tp={(int)Interval.Value}";
			}
			if(IncludeLocation != null){
				s+= $"&includelocation={(IncludeLocation.Value ? "yes" : "no")}";
			}
			return "marine.ashx?" + s.Substring(1);
		}
    }
}

