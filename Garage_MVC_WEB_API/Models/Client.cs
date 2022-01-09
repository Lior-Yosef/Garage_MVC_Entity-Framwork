using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Garage_MVC_WEB_API.Models
{
    public class Client
    {
        [key]
        public int ClientId { get; set; }
        public string FirstName { get; set; }   
        public string LastName { get; set; }
        public int CarID { get; set; }

    }
}