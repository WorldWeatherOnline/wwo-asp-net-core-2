
using System;

namespace WorldWeatherOnline
{
	/// <summary>
	/// The Location search REST API returns information about the location, including area name, country, latitude/longitude, population, and a URL for the weather information. Note that the Free API returns 30 results and the Premium API returns 100 results.
	/// </summary>
	/// <remarks>
	/// Full documentation for REST service can be found at https://developer.worldweatheronline.com/api/docs/search-api.aspx
	/// </remarks>
	public partial class SearchWeatherQuery
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
		public SearchWeatherQuery WithLocation (string location) { 
			this.Location = location;
			return this;
		}



		
		/// <summary>
		/// NumOfResults: The number of results to return. Free API: Default 3, maximum 3. Premium API: Default 10, maximum 50
		/// </summary>
		public int? NumOfResults { get; set; }

		/// <summary>
		/// Sets NumOfResults and returns modified query
		/// </summary>
		/// <param name="num_of_results">The number of results to return. Free API: Default 3, maximum 3. Premium API: Default 10, maximum 50</param>
		/// <returns>this</returns>
		public SearchWeatherQuery WithNumOfResults (int? num_of_results) { 
			this.NumOfResults = num_of_results;
			return this;
		}



		
		/// <summary>
		/// Timezone: Whether to return offset hours from GMT for each location. Default: false
		/// </summary>
		public bool? Timezone { get; set; }

		/// <summary>
		/// Sets Timezone and returns modified query
		/// </summary>
		/// <param name="timezone">Whether to return offset hours from GMT for each location. Default: false</param>
		/// <returns>this</returns>
		public SearchWeatherQuery WithTimezone (bool? timezone) { 
			this.Timezone = timezone;
			return this;
		}



		
		/// <summary>
		/// Popular: Whether to only search for popular locations, such as major cities. Default: false
		/// </summary>
		public bool? Popular { get; set; }

		/// <summary>
		/// Sets Popular and returns modified query
		/// </summary>
		/// <param name="popular">Whether to only search for popular locations, such as major cities. Default: false</param>
		/// <returns>this</returns>
		public SearchWeatherQuery WithPopular (bool? popular) { 
			this.Popular = popular;
			return this;
		}



		/// <summary>
		/// Available options for Wct
		/// </summary>
		public enum WctOptions {
			SKI,
			CRICKET,
			FOOTBALL,
			GOLF,
			FISHING
		}

		/// <summary>
		/// Wct: Returns nearest locations for the type of category provided. E.g:- wct=Ski or wct=Cricket
		/// </summary>
		public WctOptions? Wct { get; set; }

		/// <summary>
		/// Sets Wct and returns modified query
		/// </summary>
		/// <param name="wct">Returns nearest locations for the type of category provided. E.g:- wct=Ski or wct=Cricket</param>
		/// <returns>this</returns>
		public SearchWeatherQuery WithWct (WctOptions? wct) { 
			this.Wct = wct;
			return this;
		}


		private string _buildQueryString(){
			var s = "";
			if(Location != null){
				s+= $"&q={Location}";
			}
			if(NumOfResults != null){
				s+= $"&num_of_results={NumOfResults}";
			}
			if(Timezone != null){
				s+= $"&timezone={(Timezone.Value ? "yes" : "no")}";
			}
			if(Popular != null){
				s+= $"&popular={(Popular.Value ? "yes" : "no")}";
			}
			if(Wct != null){
				s+= $"&popular={Wct.ToString().ToLower()}";
			}
			return "search.ashx?" + s.Substring(1);
		}
    }
}

