using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Data;
using OdeToFoodPractice.Core;

namespace OdeToFoodPractice.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData;

        /* Below is the property the view is going to consume to display the value using @Model.Message */
        public string Message { get; set; }
        /* Below is the property the view is going to consume to display the value using @Model.Restaurants */
        public IEnumerable<Restaurant> Restaurants { get; set; }


        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }
        public void OnGet(string searchTerm)
        {
            Message = config["Message"];
            Restaurants = restaurantData.GetRestaurantsByName(searchTerm);
        }
    }
}
