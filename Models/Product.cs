using Core.Helper.Enums;
using Core.Helper.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    internal class Product
    {
        public int Id { get; set; }
        private static int _id { get; set; }
        public string Name { get; set; }
        private double _price;
        public Types ProductType { get; set; }

        public Product(string name, double price, Types type)
        {

            Name = name;
            Price = price;
            ProductType = type;

            _id++;
            Id = _id;
        }

        public double Price 
        { 
            get 
            { 
                return _price;
            } 
            set 
            { 
                if(value<0)
                {
                    throw new PriceMustBeGratherThanZeroException("Price cannot be less than 0.");
                }
                else
                {
                    _price = value;
                }

            } 
        }

        

        //Types type=new Types;
    }
}
