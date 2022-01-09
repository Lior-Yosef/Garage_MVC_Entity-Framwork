using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage_MVC_WEB_API.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string OwnerName { get; set; }
        public string CarNumber { get; set; }   
        public bool CarStatus { get; set; } 


    }
}