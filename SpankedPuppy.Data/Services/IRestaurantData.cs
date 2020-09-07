using System.Collections;
using System.Collections.Generic;
using SpankedPuppy.Data.Models;

namespace SpankedPuppy.Data.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}