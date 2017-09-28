using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldWeatherOnline
{
	namespace MarineWeatherResponse
	{
		/// <summary>
		/// Information about the location request
		/// </summary>
		public class Request
		{
			/// <summary>
			/// The type of location request ("city", "latlon", "postcode", etc)
			/// </summary>
			public string type { get; set; }
			/// <summary>
			/// The location query used
			/// </summary>
			public string query { get; set; }
		}

		/// <summary>
		/// Value element
		/// </summary>
		public class Value
		{
			public string value { get; set; }
		}


		/// <summary>
		/// Information about nearest are
		/// </summary>
		public class NearestArea
		{
			/// <summary>
			/// Name of area
			/// </summary>
			public List<Value> areaName { get; set; }
			/// <summary>
			/// Country of area
			/// </summary>
			public List<Value> country { get; set; }
			/// <summary>
			/// region of area
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
		}

		public class WeatherIconUrl
		{
			public string value { get; set; }
		}

		public class WeatherDesc
		{
			public string value { get; set; }
		}

		/// <summary>
		/// Information about the current weather
		/// </summary>
		public class CurrentCondition
		{
			/// <summary>
			/// Time of the observation in UTC
			/// </summary>
			public DateTime observation_time { get; set; }
			/// <summary>
			/// Local time of observation
			/// </summary>
			public string localObsDateTime { get; set; }
			/// <summary>
			/// If observation was in daytime. "yes" or "no"
			/// </summary>
			public string isdaytime { get; set; }
			/// <summary>
			/// If observation was in daytime. null if no info is available
			/// </summary>
			public bool? IsDayTime {
				get
				{
					if (string.IsNullOrEmpty(isdaytime) ) {
						return null;
					}
					return isdaytime == "yes";
				}
			}
			/// <summary>
			/// The temperature in degrees Celsius
			/// </summary>
			public int temp_C { get; set; }
			/// <summary>
			/// The temperature in degrees Fahrenheit
			/// </summary>
			public int temp_F { get; set; }
			/// <summary>
			/// Weather code. for more info, go to https://developer.worldweatheronline.com/api/docs/weather-icons.aspx
			/// </summary>
			public int weatherCode { get; set; }
			/// <summary>
			/// icon url
			/// </summary>
			public List<WeatherIconUrl> weatherIconUrl { get; set; }
			/// <summary>
			/// textual description of weather
			/// </summary>
			public List<WeatherDesc> weatherDesc { get; set; }
			/// <summary>
			/// Wind speed in miles per hour
			/// </summary>
			public int windspeedMiles { get; set; }
			/// <summary>
			/// Wind speed in kilometres per hour
			/// </summary>
			public int windspeedKmph { get; set; }
			/// <summary>
			/// Wind direction in degrees
			/// </summary>
			public int winddirDegree { get; set; }
			/// <summary>
			/// Wind direction in 16-point compass
			/// </summary>
			public string winddir16Point { get; set; }
			/// <summary>
			/// Precipitation in millimetres
			/// </summary>
			public float precipMM { get; set; }
			/// <summary>
			/// Humidity in percentage
			/// </summary>
			public float humidity { get; set; }
			/// <summary>
			/// Visibility in kilometres
			/// </summary>
			public int visibility { get; set; }
			/// <summary>
			/// Atmospheric pressure in inches
			/// </summary>
			public float pressure { get; set; }
			/// <summary>
			/// Cloud cover in percentage
			/// </summary>
			public int cloudcover { get; set; }
			/// <summary>
			/// Feels like temperature in degrees Celsius
			/// </summary>
			public int FeelsLikeC { get; set; }
			/// <summary>
			/// Feels like temperature in degrees Fahrenheit
			/// </summary>
			public int FeelsLikeF { get; set; }
		}

		/// <summary>
		/// Information about when the sun and moon rise and set.
		/// </summary>
		public class Astronomy
		{
			/// <summary>
			/// Local sunrise time. Time formatted as "hh:mm am/pm". For example: "05:41 am".
			/// </summary>
			public string sunrise { get; set; }
			/// <summary>
			/// Local sunset time. Time formatted as "hh:mm am/pm". For example: "05:41 am".
			/// </summary>
			public string sunset { get; set; }
			/// <summary>
			/// Local moonrise time. Time formatted as "hh:mm am/pm". For example: "05:41 am".
			/// </summary>
			public string moonrise { get; set; }
			/// <summary>
			/// Local moonset time. Time formatted as "hh:mm am/pm". For example: "05:41 am".
			/// </summary>
			public string moonset { get; set; }
		}

		public class Hourly
		{
			/// <summary>
			/// Local time. Time in hmm format. For example: 100 or 1500.
			/// </summary>
			public string time { get; set; }
			/// <summary>
			/// date in UTC
			/// </summary>
			public string UTCdate { get; set; }
			/// <summary>
			/// Time in UTC
			/// </summary>
			public string UTCtime { get; set; }
			/// <summary>
			/// If it daytime. "Yes" or no
			/// </summary>
			public string isdaytime { get; set; }
			/// <summary>
			/// If observation was in daytime. null if no info is available
			/// </summary>
			public bool? IsDayTime
			{
				get
				{
					if (string.IsNullOrEmpty(isdaytime))
					{
						return null;
					}
					return isdaytime == "yes";
				}
			}
			/// <summary>
			/// Temperature in degrees Celsius.
			/// </summary>
			public int tempC { get; set; }
			/// <summary>
			/// Temperature in degrees Fahrenheit.
			/// </summary>
			public int tempF { get; set; }
			/// <summary>
			/// Wind speed in miles per hour
			/// </summary>
			public int windspeedMiles { get; set; }
			/// <summary>
			/// Wind speed in kilometers per hour
			/// </summary>
			public int windspeedKmph { get; set; }
			/// <summary>
			/// Wind direction in degrees
			/// </summary>
			public string winddirDegree { get; set; }
			/// <summary>
			/// Wind direction in 16-point compass. Example: N
			/// </summary>
			public string winddir16Point { get; set; }
			/// <summary>
			/// weather code
			/// </summary>
			public int weatherCode { get; set; }
			/// <summary>
			/// Icon urls
			/// </summary>
			public List<WeatherIconUrl> weatherIconUrl { get; set; }
			/// <summary>
			/// Human description of weather
			/// </summary>
			public List<WeatherDesc> weatherDesc { get; set; }
			/// <summary>
			/// Precipitation in millimeters
			/// </summary>
			public float precipMM { get; set; }
			/// <summary>
			/// Humidity in percentage (%)
			/// </summary>
			public int humidity { get; set; }
			/// <summary>
			/// Visibility in kilometers
			/// </summary>
			public int visibility { get; set; }
			/// <summary>
			/// Atmospheric pressure in millibars (mb)
			/// </summary>
			public int pressure { get; set; }
			/// <summary>
			/// Cloud cover amount in percentage (%)
			/// </summary>
			public int cloudcover { get; set; }
			/// <summary>
			/// Heat index temperature in degrees Celsius
			/// </summary>
			public int HeatIndexC { get; set; }
			/// <summary>
			/// Heat index temperature in degrees Fahrenheit
			/// </summary>
			public int HeatIndexF { get; set; }
			/// <summary>
			/// Dew point temperature in degrees Celsius
			/// </summary>
			public int DewPointC { get; set; }
			/// <summary>
			/// Dew point temperature in degrees Fahrenheit
			/// </summary>
			public int DewPointF { get; set; }
			/// <summary>
			/// Wind chill temperature in degrees Celsius
			/// </summary>
			public int WindChillC { get; set; }
			/// <summary>
			/// Wind chill temperature in degrees Fahrenheit
			/// </summary>
			public int WindChillF { get; set; }
			/// <summary>
			/// Wind gust in miles per hour
			/// </summary>
			public int WindGustMiles { get; set; }
			/// <summary>
			/// Wind gust in kilometers per hour
			/// </summary>
			public int WindGustKmph { get; set; }
			/// <summary>
			/// Feels like temperature in degrees Celsius
			/// </summary>
			public int FeelsLikeC { get; set; }
			/// <summary>
			/// Feels like temperature in degrees Fahrenheit
			/// </summary>
			public int FeelsLikeF { get; set; }
			/// <summary>
			/// Chance of rain (precipitation) in percentage (%).
			/// </summary>
			public int chanceofrain { get; set; }
			/// <summary>
			/// Chance of remedy in percentage (%).
			/// </summary>
			public int chanceofremdry { get; set; }
			/// <summary>
			/// Chance of being windy in percentage (%).
			/// </summary>
			public int chanceofwindy { get; set; }
			/// <summary>
			/// Chance of being cloudy in percentage (%).
			/// </summary>
			public int chanceofovercast { get; set; }
			/// <summary>
			/// Chance of being sunny in percentage (%).
			/// </summary>
			public int chanceofsunshine { get; set; }
			/// <summary>
			/// Chance of being sunny in percentage (%).
			/// </summary>
			public int chanceoffrost { get; set; }
			/// <summary>
			/// Chance of high temperature in percentage (%).
			/// </summary>
			public int chanceofhightemp { get; set; }
			/// <summary>
			/// Chance of fog in percentage (%).
			/// </summary>
			public int chanceoffog { get; set; }
			/// <summary>
			/// Chance of snow in percentage (%).
			/// </summary>
			public int chanceofsnow { get; set; }
			/// <summary>
			/// Chance of thunder in percentage (%).
			/// </summary>
			public int chanceofthunder { get; set; }

			/// <summary>
			/// Significant wave height in metres
			/// </summary>
			public float sigHeight_m { get; set; }
			/// <summary>
			/// Swell wave height in metres
			/// </summary>
			public float swellHeight_m { get; set; }
			/// <summary>
			/// Swell wave height in feed
			/// </summary>
			public float swellHeight_ft { get; set; }
			/// <summary>
			/// Swell direction in degree
			/// </summary>
			public float swellDir { get; set; }
			/// <summary>
			/// Swell direction in 16-point compass. Example: N
			/// </summary>
			public string swellDir16Point { get; set; }
			/// <summary>
			/// Swell period in seconds
			/// </summary>
			public float swellPeriod_secs { get; set; }
			/// <summary>
			/// Water temperature in Celcius
			/// </summary>
			public int waterTemp_C { get; set; }
			/// <summary>
			/// Water temperature in Fahrenheit
			/// </summary>
			public int waterTemp_F { get; set; }
		}

		/// <summary>
		/// Information about the weather forecast.
		/// </summary>
		public class Weather
		{
			/// <summary>
			/// Local forecast date
			/// </summary>
			public DateTime date { get; set; }
			/// <summary>
			/// Astronomical condition for the day.
			/// </summary>
			public List<Astronomy> astronomy { get; set; }
			/// <summary>
			/// Maximum temperature of the day in degree Celsius
			/// </summary>
			public int maxtempC { get; set; }
			/// <summary>
			/// Maximum temperature of the day in degree Fahrenheit
			/// </summary>
			public int maxtempF { get; set; }
			/// <summary>
			/// Minimum temperature of the day in degree Celsius
			/// </summary>
			public int mintempC { get; set; }
			/// <summary>
			/// Minimum temperature of the day in degree Fahrenheit
			/// </summary>
			public int mintempF { get; set; }
			/// <summary>
			/// Total snowfall amount in cm
			/// </summary>
			public float totalSnow_cm { get; set; }
			/// <summary>
			/// Total sun hour
			/// </summary>
			public float sunHour { get; set; }
			/// <summary>
			/// UV Index
			/// </summary>
			public int uvIndex { get; set; }
			/// <summary>
			/// Hourly weather conditions. 
			/// </summary>
			public List<Hourly> hourly { get; set; }
			/// <summary>
			/// Tide data information	
			/// </summary>
			public List<Tide> tides { get; set; }
		}

		/// <summary>
		/// Information about tides
		/// </summary>
		public class Tide {
			/// <summary>
			/// Local tide time. Time formatted as "hh:mm am/pm". For example: "05:41 am".
			/// </summary>
			public string tideTime { get; set; }

			/// <summary>
			/// Tide height in meter
			/// </summary>
			public float tideHeight_mt { get; set; }
			/// <summary>
			/// Type of tide i.e. High, Low or Normal	
			/// </summary>
			public string tide_type { get; set; }

		}

		public class Month
		{
			/// <summary>
			/// Month index. 1-12
			/// </summary>
			public string index { get; set; }
			/// <summary>
			/// Human name of month
			/// </summary>
			public string name { get; set; }
			/// <summary>
			/// Average minimum temperature in degrees Celsius
			/// </summary>
			public float avgMinTemp { get; set; }
			/// <summary>
			/// Average minimum temperature in degrees Fahrenheit
			/// </summary>
			public float avgMinTemp_F { get; set; }
			/// <summary>
			/// Absolute maximum temperature in degrees Celsius
			/// </summary>
			public float absMaxTemp { get; set; }
			/// <summary>
			/// Absolute maximum temperature in degrees Fahreinheit
			/// </summary>
			public float absMaxTemp_F { get; set; }
			/// <summary>
			/// Average daily rainfall in millimetres
			/// </summary>
			public float avgDailyRainfall { get; set; }
		}

		/// <summary>
		/// Climate average information
		/// </summary>
		public class ClimateAverage
		{
			/// <summary>
			/// Info for months
			/// </summary>
			public List<Month> month { get; set; }
		}

		/// <summary>
		/// Data returned by request to service endpoint
		/// </summary>
		public class Data
		{
			/// <summary>
			/// Contains the information about type of request made by user.
			/// </summary>
			public List<Request> request { get; set; }
			/// <summary>
			/// Nearest area info
			/// </summary>
			public List<NearestArea> nearest_area { get; set; }
			/// <summary>
			/// Contains the current weather condition forecast related information.
			/// </summary>
			public List<CurrentCondition> current_condition { get; set; }
			/// <summary>
			/// Contains the weather forecast related information.
			/// </summary>
			public List<Weather> weather { get; set; }
			/// <summary>
			/// Contains climate average related information.
			/// </summary>
			public List<ClimateAverage> ClimateAverages { get; set; }
		}

		/// <summary>
		/// Object returned by request to service endpoint
		/// </summary>
		public class RootObject
		{
			public Data data { get; set; }
		}
	}
}
