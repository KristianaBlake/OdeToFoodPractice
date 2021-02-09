using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace OdeToFoodPractice.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;

        public string Message { get; set; }

        /*
         ListModel is a Constructor
         My Constructor can take a parameter of type IConfiguration*/

        public ListModel(IConfiguration config)
        {
            this.config = config;
        }
        public void OnGet()
        {
            Message = config["Message"];
        }
    }
}
