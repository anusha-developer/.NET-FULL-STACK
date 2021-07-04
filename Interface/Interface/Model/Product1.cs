using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Model
{
    class Product1 :Product
    {
        public float Size;
        public float weight;
        public override string ToString()
        {
            return "Product:" + ProductId + " " + Name + " " + Quantity + " " + Description + " " + Price + ""+ Size + " "+ weight + "";

        }



    }
}
