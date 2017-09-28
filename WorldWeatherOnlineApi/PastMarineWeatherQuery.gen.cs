
using System;

namespace WorldWeatherOnline
{
	/// <summary>
	/// Class used to construct query to historical marine weather Api 
	/// </summary>
	/// <remarks>
	/// Full documentation for REST service can be found at https://developer.worldweatheronline.com/api/docs/historical-marine-weather-api.aspx
	/// </remarks>
	public partial class PastMarineWeatherQuery
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
		public PastMarineWeatherQuery WithLocation (string location) { 
			this.Location = location;
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
		public PastMarineWeatherQuery WithTide (bool? tide) { 
			this.Tide = tide;
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
		public PastMarineWeatherQuery WithDate (DateTime? date) { 
			this.Date = date;
			return this;
		}



		
		/// <summary>
		/// Enddate: Specifies end date
		/// </summary>
		public DateTime? Enddate { get; set; }

		/// <summary>
		/// Sets Enddate and returns modified query
		/// </summary>
		/// <param name="enddate">Specifies end date</param>
		/// <returns>this</returns>
		public PastMarineWeatherQuery WithEnddate (DateTime? enddate) { 
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
		public PastMarineWeatherQuery WithIncludeLocation (bool? include_location) { 
			this.IncludeLocation = include_location;
			return this;
		}


		private string _buildQueryString(){
			var s = "";
			if(Location != null){
				s+= $"&q={Location}";
			}
			if(Tide != null){
				s+= $"&tide={(Tide.Value ? "yes" : "no")}";
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
			return "past-marine.ashx?" + s.Substring(1);
		}
    }
}

