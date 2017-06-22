using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MvcApplication3.Models
{
    public class Dog
    {
        [Required(ErrorMessage="ID is required")]
        
        public int DogId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        
    }
}