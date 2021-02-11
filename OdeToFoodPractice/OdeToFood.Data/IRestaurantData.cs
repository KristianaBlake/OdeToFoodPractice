﻿using System;
using System.Collections.Generic;
using System.Text;
using OdeToFoodPractice.Core;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string Name);
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id=1, Name="Los Comanles", Location="Mexico", Cuisine=CuisineType.Mexian},
                new Restaurant { Id=2, Name="Nepal House", Location="India", Cuisine=CuisineType.Indian},
                new Restaurant { Id=3, Name="Bartoli's", Location="Italy", Cuisine=CuisineType.Italian }
            };
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }


     }
}
