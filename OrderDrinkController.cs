using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BartenderApp.Models
{
    public class OrderDrink
    {
        public int OrderId { get; set; }
        public string Patron { get; set; }
        public string DrinkType { get; set; }
    }
}