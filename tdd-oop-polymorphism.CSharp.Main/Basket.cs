﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<IProduct> products = new List<IProduct>();


        public void add(IProduct product)
        {
            this.products.Add(product);
        }


        public int getTotal()
        {
            int total = 0;

            foreach (var item in products)
            {
                total += item.getPrice();
            }

            return total;
        }

        public bool isInBasket(String name)
        {

            foreach (var item in products)
            {
                if (item.getName().Equals(name))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
