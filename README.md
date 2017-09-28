# WorldWeatherOnlineApi
Code of library is in `/WorldWeatherOnlineApi`. Code is compatible with .Net Standart 1.1. 

# Usage of library

Library contains `Api` class. `Api` should be constructed with api key for service.

`Api` provides a set of methods starting with `Build`, which provide builders for  queries to different endpoint. Initial parameter required by builder are required by service api.

Builders store query parameters. Thye provide a set of methods starting with `With`, which allow to set paramters of query.

Builders also provide methods starting with `Get`, which make request to service and return data in specified format.

Example:
```c#
api.BuildPastWeatherQuery(loc, date)
    .WithEnddate(enddate)
    .WithIncludeLocation(true)
    .GetResult();
```

All code is documented, generated documentation is also available in `/docs` folder.

Examples of using api are located in `/Controllers/HomeController.cs` Client side code is in `/Views/Home`

# Example of using local weather endpoint
```c#
api.BuildLocalWeatherQuery(loc)
    .WithNumOfDays(days)
    .WithIncludeLocation(true)
    .GetResult();

```
This code will call `http://api.worldweatheronline.com/premium/v1/weather.ashx?key=API_KEY&q=London&num_of_days=5&format=json&includelocation=yes`

<img src="/imgs/6bb62d46-899d-4342-8121-d5cc1c5e4504.png">

# Example of using historical weather endpoint
```c#
api.BuildPastWeatherQuery(loc, date)
    .WithEnddate(enddate)
    .WithIncludeLocation(true)
    .GetResult();
```
This code will call `http://api.worldweatheronline.com/premium/v1/past-weather.ashx?key=API_KEY&q=Paris&format=json&includelocation=yes&date=2017-08-15&enddate=2017-09-10`

<img src="/imgs/5fc0749e-cf4b-4d38-a8d3-1382fc80ee9b.png">

# Example of using marine weather endpoint
```c#
api.BuildMarineWeatherQuery(loc)
    .WithIncludeLocation(true)
    .GetResult();
```
This code will call `http://api.worldweatheronline.com/premium/v1/marine.ashx?key=API_KEY&q=31.50,-12.50&format=json&includelocation=yes`

<img src="/imgs/c3313244-78fd-41d9-9d68-c58de78efc77.png">

# Example of using historical marine weather endpoint
```c#
api.BuildPastMarineWeatherQuery(loc, date)
    .WithEnddate(enddate)
    .WithIncludeLocation(true)
    .GetResult();
```
This code will call `http://api.worldweatheronline.com/premium/v1/past-marine.ashx?q=31.50,-12.50&date=2017-08-16&&enddate=2017-09-10&includelocation=yes&format=json&key=API_KEY`

<img src="/imgs/508a882d-ce34-406f-867c-186bcde53ce6.png">

# Example of using ski weather endpoint
```c#
api.BuildSkiWeatherQuery(loc, days)
    .WithIncludeLocation(true)
    .GetResult();
```
This code will call `http://api.worldweatheronline.com/premium/v1/ski.ashx?q=52.233,-90.75&num_of_days=5&includelocation=yes&format=json&key=API_KEY`

<img src="/imgs/a77621fc-a6c3-4283-b460-5a548f527fc2.png">

# Example of using location search endpoint
```c#
api.BuildSearchWeatherQuery(loc)
    .GetResult(); 
```
This code will call `http://api.worldweatheronline.com/premium/v1/search.ashx?key=API_KEY&q=London&format=json`

<img src="/imgs/51d7f61b-0b85-491f-ba8b-3be2ecce5027.png">

# Example of using timezone endpoint
```c#
api.BuildTzWeatherQuery(loc)
    .WithIncludeLocation(true)
    .GetResult();
```
This code will call `http://api.worldweatheronline.com/premium/v1/tz.ashx?key=API_KEY&q=Paris&format=json&includelocation=yes`

<img src="/imgs/c4ea705d-fe93-4419-a3e5-97c7b207d39f.png">
