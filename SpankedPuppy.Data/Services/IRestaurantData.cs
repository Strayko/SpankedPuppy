using System.Collections;
using System.Collections.Generic;
using SpankedPuppy.Data.Models;

namespace SpankedPuppy.Data.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        void Add(Restaurant restaurant);
        void Update(Restaurant restaurant);
        void Delete(int id);
    }
}