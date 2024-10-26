using Core.Helper.Enums;
using Core.Helper.Exceptions;
using Core.Models;

namespace Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            //Product product=new Product("Name",10,Types.Baker );
            //Product product1 = new Product( "Na", 15, Types.Drink);
            //Product product2 = new Product( "Nam", 20, Types.Meat);

            //store.AddProduct(product);
            //store.AddProduct(product1);
            //store.AddProduct(product2);

            //store.RemoveProductByNo(2);
            while (true)
            {
                Console.WriteLine();

                Console.WriteLine("1. Add Product.");
                Console.WriteLine("2. Remove Product By No.");
                Console.WriteLine("3. Get Product.");
                Console.WriteLine("4. Filter Products By Type.");
                Console.WriteLine("5. Filter Products By Name.");
                Console.WriteLine("6. Exit.");



                Console.WriteLine();

                int choice = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Product Name:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter product type by number(1.Baker, 2.Drink, 3.Meat, 4.Diary)");
                        if(int.TryParse(Console.ReadLine(), out int type)&& type>=1 && type <= 4)
                        {
                            Console.WriteLine($"You selected:{(Types)type}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice");
                        }


                        try
                        {

                            Console.WriteLine("Enter Product Price:");
                            double price = double.Parse(Console.ReadLine());


                            Product product = new Product(name, price, (Types)type);

                            store.AddProduct(product);
                        }
                        catch (PriceMustBeGratherThanZeroException ex)
                        {
                            throw new PriceMustBeGratherThanZeroException();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;


                    case 2:
                        bool f = false;
                        
                        Console.Write("Enter product Id that you want remove: ");
                        int removeById = int.Parse(Console.ReadLine());

                        store.RemoveProductByNo(removeById);
                        break;


                    case 3:

                        Console.Write("Enter product Id that you want get: ");
                        
                        if(int.TryParse(Console.ReadLine(), out int productId))
                        {
                            Product newProduct=store.GetProduct(productId);
                            if (newProduct != null)
                            {
                                Console.WriteLine($"Name: {newProduct.Name}, Price: {newProduct.Price}, Type: {newProduct.ProductType}");
                            }
                            else
                            {
                                Console.WriteLine("Product not found.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                        break;

                    case 4:

                        Console.WriteLine("Enter type by number that you want to get(1.Baker, 2.Drink, 3.Meat, 4.Diary):");
                        if(int.TryParse(Console.ReadLine(),out int num)&& num>=1 && num <= 4)
                        {
                            Product[] newArray= store.FilterProductsByType((Types)num);

                          
                            foreach (Product product in newArray)
                            {
                                if (product != null)
                                {
                                    Console.WriteLine($"Namw: {product.Name}, Price: {product.Price}, Type: {product.ProductType}");
                                }
                                
                            }
             
                        }
                        else
                        {
                            Console.WriteLine("newArray is empty");
                        }

                        break ;

                    case 5:
                        Console.WriteLine("Enter name that you want to get:");
                        string Productname= Console.ReadLine();

                        Product[] newArray1 = store.FilterProductByName(Productname);

                        foreach(Product product in newArray1)
                        {
                            if(product != null)
                            {
                                Console.WriteLine($"Namw: {product.Name}, Price: {product.Price}, Type: {product.ProductType}");
                            }
                        }
                        break ;

                    case 6:
                        return;


                }
            }




            
        }
    }
}
