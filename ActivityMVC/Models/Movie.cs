using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ActivityMVC.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        public List<Models.Movie> GetDetail()
        {
            List<Models.Movie> lst = new List<Models.Movie>();
            lst.Add(new Models.Movie { ID = 1, Title = "Digital Fortress", Price = 120 });
            lst.Add(new Models.Movie { ID = 2, Title = "Angels and Demons", Price = 140 });
            lst.Add(new Models.Movie { ID = 3, Title = "The subtle art of not giving a fuck", Price = 110 });
            return lst;
        }
    }

 
   
}
