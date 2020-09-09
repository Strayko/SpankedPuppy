using System.Collections.Generic;
using SpankedPuppy.Data.Models;

namespace SpankedPuppy.Web.Models
{
    public class GreetingViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
    }
}