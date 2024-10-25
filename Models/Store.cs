using Core.Helper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    internal class Store
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
            Product[] newArray=new Product[products.Length];
            for(int i=0; i<products.Length; i++)
            {
                if (products[i].Id != no)
                {
                    newArray[i] = products[i];
                    Console.WriteLine($"ID:{newArray[i].Id}, Name:{newArray[i].Name}, Price:{newArray[i].Price}");
                }

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
            for(int i=0; i<products.Length; ++i)
            {
                if (products[i].ProductType == type)
                {
                    filteredArray[i] = products[i];
                    return filteredArray;
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
