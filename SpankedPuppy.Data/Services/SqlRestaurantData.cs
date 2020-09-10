using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SpankedPuppy.Data.Models;

namespace SpankedPuppy.Data.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly ApplicationDbContext _db;

        public SqlRestaurantData(ApplicationDbContext _db)
        {
            this._db = _db;
        }
        
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in _db.Restaurants
                orderby r.Name
                select r;
        }

        public Restaurant Get(int id)
        {
            return _db.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public void Add(Restaurant restaurant)
        {
            _db.Restaurants.Add(restaurant);
            _db.SaveChanges();
        }

        public void Update(Restaurant restaurant)
        {
            var entry = _db.Entry(restaurant);
            entry.State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}