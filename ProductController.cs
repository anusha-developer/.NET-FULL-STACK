using FlipCart.Models;
using FlipCart.Repositary;
using FlipCart.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FlipCart.Controllers
{
    public class ProductController : ApiController
    {
        //Http verbs

        private ProductService productService;
        public ProductController()
        {
            productService = new ProductService();
        }

        [HttpPost]
        [Route("api/Product/Save")]
        public Product Saveproduct(Product product)
        {
            try
            {
                return productService.Saveproduct(product);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return product;
        }

        [HttpGet]
        [Route("api/Product/GetById/{productId}")]
        public Product fetchProductById(int productId)
        {
            try
            {
                return productService.GetProductById(productId);
            }
            catch ( Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return productService.GetProductById(productId);
        }
        [HttpGet]
        [Route("api/Product/GetAll")]
        public List<Product> fetchAllProducts()
        {
            try
            {
                return productService.GetAllProducts();

            }
            catch(Exception ex)
            {
                Console.WriteLine( ex.Message);
            }
            return null;
        }

        [HttpPut]
        [Route("api/Product/Update/{productId}")]
        public Product UpdateProductById(int productId, Product product)
        {
            try
            {
                return productService.UpdateProductById(productId,product);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        [HttpDelete]
        [Route("api/product/DeleteById/{productId}")]
        public string removeProductById(int productId)
        {
            try
            {
                return productService.DeleteProductById(productId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        [HttpGet]
        [Route("api/Product/GetByName/{Name}")]
        public Product fetchProductByName(string Name)
        {
            try
            {
                return productService.GetProductByName(Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return productService.GetProductByName(Name);
        }

        [HttpGet]
        [Route("api/Product/SearchAllProductsByName/{Name}")]
        public List<Product> fetchAllProductsByName(string Name)
        {
            try
            {
                return productService.SearchAllProductsByName(Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return productService.SearchAllProductsByName(Name);
        }
        [HttpGet]
        [Route("api/Product/SearchAllProductsBetweenRange/{MinPrice}/{MaxPrice}")]
        public List<Product> fetchAllProductsBetweenRange(decimal MinPrice, decimal MaxPrice)
        {
            try
            {
                return productService.FindAllProductsBetweenRange(MinPrice, MaxPrice);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return productService.FindAllProductsBetweenRange(MinPrice, MaxPrice);
        }
    }
}
