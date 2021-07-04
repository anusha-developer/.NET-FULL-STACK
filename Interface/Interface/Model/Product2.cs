using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Model
{
    class Product2:Product1
    {
        public string Importedform;
        public override string ToString()
        {
            return "Product:" + ProductId + " " + Name + " " + Quantity + " " + Description + " " + Price + "" + Size + " " + weight + ""+ Importedform + "";

        }

    }
}
