using System.Collections.Generic;
using System.Linq;
using SpankedPuppy.Data.Models;

namespace SpankedPuppy.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Name1", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 2, Name = "Name2", Cuisine = CuisineType.Indian },
                new Restaurant { Id = 3, Name = "Name3", Cuisine = CuisineType.French },
            };
        }


        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}