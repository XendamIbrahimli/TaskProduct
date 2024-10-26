using Core.Helper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Store
    {
        Product[] products;

        public Store()
        {
            products = new Product[0];
        }

        public void AddProduct(Product product)
        {
            Array.Resize(ref  products, products.Length+1);
            products[products.Length - 1] = product;
    
        }

        public void RemoveProductByNo(int no)
        {
            int id = 0;
            Product[] newArray=new Product[products.Length-1];
            for(int i=0; i<products.Length; i++)
            {
                if (products[i].Id != no)
                {
                    newArray[id] = products[i];
                    id++;
                    
                }

            }
            products = newArray;

            foreach(Product product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Type: {product.ProductType}");
            }

        }

        public Product GetProduct(int no)
        {
            for(int i = 0; i<products.Length;i++)
            {
                if (products[i].Id == no)
                {
                    return products[i];
                }
            }
            return null;

        }

        public Product[] FilterProductsByType(Types type)
        {
            Product[] filteredArray = new Product[products.Length];
            int h = 0;
            for(int i=0; i<products.Length; i++)
            {
                if (products[i].ProductType == type)
                {
                    filteredArray[h] = products[i];
                    h++;
                    
                }
            }
            return filteredArray;

        }

        public Product[] FilterProductByName(string name)
        {
            Product[] newProduct= new Product[products.Length];
            for(int i=0; i<products.Length; ++i)
            {
                if (products[i].Name == name)
                {
                    newProduct[i] = products[i];
                    return newProduct;
                }
            }
            return newProduct;
            
        }
    }
}
