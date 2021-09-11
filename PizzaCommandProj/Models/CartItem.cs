﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaCommandProj.Models
{
    public class CartItem
    {
        public int DishId { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public int Amount { get; set; }
    }
}
