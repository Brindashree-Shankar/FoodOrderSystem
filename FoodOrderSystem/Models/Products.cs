﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodOrderSystem.Models
{
    public class Products
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductPicture { get; set; }
        int Distance { get; set; }
    }
}