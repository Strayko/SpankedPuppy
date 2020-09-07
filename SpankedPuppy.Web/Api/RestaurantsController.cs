using System.Collections.Generic;
using System.Web.Http;
using SpankedPuppy.Data.Models;
using SpankedPuppy.Data.Services;

namespace SpankedPuppy.Web.Api
{
    public class RestaurantsController : ApiController
    {
        private readonly IRestaurantData _db;

        public RestaurantsController(IRestaurantData db)
        {
            _db = db;
        }
        
        public IEnumerable<Restaurant> Get()
        {
            var model = _db.GetAll();
            return model;
        }
    }
}