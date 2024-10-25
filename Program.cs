using Core.Helper.Enums;
using Core.Models;

namespace Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            Product product=new Product("Name",10,Types.Baker );
            Product product1 = new Product( "Na", 15, Types.Drink);
            Product product2 = new Product( "Nam", 20, Types.Meat);

            store.AddProduct(product);
            store.AddProduct(product1);
            store.AddProduct(product2);

            //store.RemoveProductByNo(2);
            while (true)
            {
                Console.WriteLine("1. Add Product.");
                Console.WriteLine("2. Remove Product By No.");
                Console.WriteLine("3. Get Product.");
                Console.WriteLine("4. Filter Products By Type.");
                Console.WriteLine("5. Filter Products By Name.");

                int choice = int.Parse(Console.ReadLine());



                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Enter Product Name:");
                        string name=Console.ReadLine();

                        Console.WriteLine("Enter Product Price:");
                        double price=double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter product type(Baker, Drink, Meat, Diary");
                        Types types=new Types();


                        break;

                }
            }




            
        }
    }
}
