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
                new Restaurant { Id = 1, Name = "Banana Leaf", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 2, Name = "Pink Sugar ", Cuisine = CuisineType.Indian },
                new Restaurant { Id = 3, Name = "Pine & Dine ", Cuisine = CuisineType.French },
            };
        }


        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }

        public void Add(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
            restaurant.Id = restaurants.Max(r => r.Id) + 1;
        }

        public void Update(Restaurant restaurant)
        {
            var existing = Get(restaurant.Id);
            if (existing != null)
            {
                existing.Name = restaurant.Name;
                existing.Cuisine = restaurant.Cuisine;
            }
        }
    }
}