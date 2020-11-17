using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForecastApp.ForecastAppModels;
using ForecastApp.OpenWeatherMapModels;
using ForecastApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ForecastApp.Controllers
{
    public class ForecastAppController : Controller
    {
        //GET ForecastApp/SearchCity
        public IActionResult SearchCity()
        {
            var viewModel = new SearchCity();
            return View(viewModel);
        }

        //POST: ForecastApp/SearchCity
        [HttpPost]
        public IActionResult SeachCity(SearchCity model)
        {
            if (ModelState.IsValid) {
                return RedirectToAction("City", "ForecastApp", new { city = model.CityName });
            }
            return View(model);
        }

        //GET: ForecastApp/City
        public IActionResult City(string city);
        {
            City viewModel = new City();
            return View(viewModel);
        }
    }
}