using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;
using OdeToFood.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OdeToFood.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;
        private IGreeter _greeter;

        public HomeController(IRestaurantData _restaurantData, IGreeter _greeter)
        {
            this._restaurantData = _restaurantData;
            this._greeter = _greeter;
        }

        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            model.Restaurants = this._restaurantData.GetAll().OrderBy(restaurant => restaurant.Name);
            model.CurrentMessage = _greeter.GetMessageOfTheDay();

            return View(model);
        }
    }
}
