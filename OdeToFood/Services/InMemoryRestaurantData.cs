using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            this._restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Scott's Pizza Palace" },
                new Restaurant { Id = 2, Name = "Tarsiguels Pasta" },
                new Restaurant { Id = 3, Name = "Sushi Bar" },
                new Restaurant { Id = 4, Name = "Chinenese Food Restaurant" }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return this._restaurants;
        }
    }
}
