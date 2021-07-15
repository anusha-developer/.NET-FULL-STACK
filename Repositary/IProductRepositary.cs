using FlipCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlipCart.Repositary
{
    public interface IProductRepositary
    {
        //Methods
        Product CreateProduct(Product product);
        Product findProductById( int productId);

        Product findProductByName(string productId);
        List<Product> findAllProducts();
        Product updateProduct(int productId, Product product);
        string DeleteProduct(int productId);
       
    }
}