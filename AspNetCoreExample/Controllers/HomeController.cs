using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WorldWeatherOnline;

namespace AspNetCoreExample.Controllers
{
	public class HomeController : Controller
	{
		static Api api = null;
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Local()
		{
			return View();
		}

		public ActionResult Ski()
		{
			return View();
		}

		public ActionResult Search()
		{
			return View();
		}

		public ActionResult Timezones()
		{
			return View();
		}

		public ActionResult Marine()
		{
			return View();
		}

		public ActionResult PastMarine()
		{
			return View();
		}

		public ActionResult Historical()
		{
			return View();
		}

		public ActionResult Contact()
		{
			return View();
		}

		[Microsoft.AspNetCore.Mvc.HttpPost]
		public JsonResult UpdateKey([FromForm]string key)
		{
			api = api ?? new Api(key);
			api.Key = key;
			return Json("ok");
		}

		[Microsoft.AspNetCore.Mvc.HttpPost]
		public async Task<ActionResult> GetLocalWeather([FromForm]string loc, [FromForm] int days)
		{
			// example of request with all possible options enabled
			//var res = await api.BuildLocalWeatherQuery(loc)
			//	.WithNumOfDays(4)
			//	.WithConditions(true)
			//	.WithDate(DateTime.Today)
			//	.WithDateFormat(LocalWeatherQuery.DateFormatOptions.ISO8601)
			//	.WithForecast(true)
			//	.WithIncludeLocation(true)
			//	.WithInterval(LocalWeatherQuery.IntervalOptions.THREE_HOURS)
			//	.WithIsDayTime(true)
			//	.WithLocalObsTime(true)
			//	.WithMap(true)
			//	.WithThreeHourInterval(true)
			//	.WithUtcDateTime(true)
			//	.WithMonthlyAverage(true)
			//	.GetResult();

			// example of minimal request
			var res = await api.BuildLocalWeatherQuery(loc)
				.WithNumOfDays(days)
				.WithIncludeLocation(true)
				.GetResult();

			// serialize and send to client
			var ret = JsonConvert.SerializeObject(res, Formatting.Indented,
				 new JsonSerializerSettings
				 {
					 DateFormatHandling = DateFormatHandling.IsoDateFormat
				 });
			return Content(ret, "application/json");
		}

		[HttpPost]
		public async Task<ActionResult> GetPastWeather([FromForm]string loc, [FromForm] DateTime date, [FromForm] DateTime enddate)
		{
			// example of request with all possible options enabled
			//var res = await api.BuildPastWeatherQuery(loc, DateTime.Today)
			//	.WithEnddate(DateTime.Today.AddDays(3))
			//	.WithIncludeLocation(true)
			//	.WithIsDayTime(true)
			//	.WithUtcDateTime(true)
			//	.GetResult();

			// example of minimal request
			var res = await api.BuildPastWeatherQuery(loc, date)
				.WithEnddate(enddate)
				.WithIncludeLocation(true)
				.GetResult();

			// serialize and send to client
			var ret = JsonConvert.SerializeObject(res, Formatting.Indented,
				 new JsonSerializerSettings
				 {
					 DateFormatHandling = DateFormatHandling.IsoDateFormat
				 });
			return Content(ret, "application/json");
		}

		[HttpPost]
		public async Task<ActionResult> GetMarineWeather([FromForm]string loc)
		{
			// example of minimal request
			var res = await api.BuildMarineWeatherQuery(loc)
				.WithIncludeLocation(true)
				.GetResult();

			// serialize and send to client
			var ret = JsonConvert.SerializeObject(res, Formatting.Indented,
				 new JsonSerializerSettings
				 {
					 DateFormatHandling = DateFormatHandling.IsoDateFormat
				 });
			return Content(ret, "application/json");
		}

		[HttpPost]
		public async Task<ActionResult> GetPastMarineWeather([FromForm]string loc, [FromForm] DateTime date, [FromForm] DateTime enddate)
		{
			// example of minimal request
			var res = await api.BuildPastMarineWeatherQuery(loc, date)
				.WithEnddate(enddate)
				.WithIncludeLocation(true)
				.GetResult();

			// serialize and send to client
			var ret = JsonConvert.SerializeObject(res, Formatting.Indented,
				 new JsonSerializerSettings
				 {
					 DateFormatHandling = DateFormatHandling.IsoDateFormat
				 });
			return Content(ret, "application/json");
		}

		[HttpPost]
		public async Task<ActionResult> GetSkiWeather([FromForm]string loc, [FromForm]int days)
		{
			// example of minimal request
			var res = await api.BuildSkiWeatherQuery(loc, days)
				.WithIncludeLocation(true)
				.GetResult();

			// serialize and send to client
			var ret = JsonConvert.SerializeObject(res, Formatting.Indented,
				 new JsonSerializerSettings
				 {
					 DateFormatHandling = DateFormatHandling.IsoDateFormat
				 });
			return Content(ret, "application/json");
		}

		[HttpPost]
		public async Task<ActionResult> SearchWeather([FromForm]string loc)
		{
			// example of minimal request
			var res = await api.BuildSearchWeatherQuery(loc)
				.GetResult();

			// serialize and send to client
			var ret = JsonConvert.SerializeObject(res, Formatting.Indented,
				 new JsonSerializerSettings
				 {
					 DateFormatHandling = DateFormatHandling.IsoDateFormat
				 });
			return Content(ret, "application/json");
		}

		[HttpPost]
		public async Task<ActionResult> Tz([FromForm]string loc)
		{
			// example of minimal request
			var res = await api.BuildTzWeatherQuery(loc)
				.WithIncludeLocation(true)
				.GetResult();

			// serialize and send to client
			var ret = JsonConvert.SerializeObject(res, Formatting.Indented,
				 new JsonSerializerSettings
				 {
					 DateFormatHandling = DateFormatHandling.IsoDateFormat
				 });
			return Content(ret, "application/json");
		}
	}
}
