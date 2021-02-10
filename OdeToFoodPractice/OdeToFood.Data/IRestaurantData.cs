using System;
using System.Collections.Generic;
using System.Text;
using OdeToFoodPractice.Core;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id= 1, Name="McFly's", Location="Chicago", Cuisine=CuisineType.None},
                new Restaurant { Id=2, Name="Los Comanles", Location="Mexico", Cuisine=CuisineType.Mexian},
                new Restaurant { Id=3, Name="Nepal House", Location="India", Cuisine=CuisineType.Indian},
                new Restaurant { Id=4, Name="Bartoli's", Location="Italy", Cuisine=CuisineType.Italian}
                
            };
        }
 
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r; 
        }
    }
