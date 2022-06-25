
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharp
{
    public class ProductConsole
    {
        List<Product> products = new List<Product>();

        public void menu()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("*********Menu************");
                    Console.WriteLine("1.Add Product");
                    Console.WriteLine("2.Display all product");
                    Console.WriteLine("3.Delete product");
                    Console.WriteLine("4.Exit");
                    int choice=Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            addProductConsole();
                            break;
                        case 2:
                            getAll();
                            break;
                        case 3:
                            deleteProductConsole();
                            break;
                        case 4:
                            Environment.Exit(4);
                            break;
                   
                    }

                }catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        public void addProductConsole()
        {
            int check = 0;
            Product product = new Product();
            Console.WriteLine("Enter ID Product:");
            product.ProductId = Convert.ToInt32(Console.ReadLine());
            foreach (Product p in products)
            {
                if (p.ProductId.Equals(product.ProductId))
                {
                    Console.WriteLine("id already exist");
                    check = 1;
                    
                }


            }

            if (check == 0)
            {
                Console.WriteLine("Enter product name:");
                product.ProductName = Console.ReadLine();
                Console.WriteLine("Enter price:");
                product.ProductPrice = Convert.ToDouble(Console.ReadLine());
                products.Add(product);
            }
        }
        public void getAll()
        {

            if (products.Count==0)
            {
                Console.WriteLine("List Empty");
            }
            else
            {

                foreach (Product product in products)
                {
                    Console.WriteLine("product id: " + product.ProductId);
                    Console.WriteLine("product name: " + product.ProductName);
                    Console.WriteLine("price: " + product.ProductPrice);
                }
            }
        }
        public void deleteProductConsole()
        {
            Console.WriteLine("Enter id product");
            int id = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            foreach (var item in products)
            {
                if (item.ProductId.Equals(id))
                {
                    products.Remove(products.Find(p => { return p.ProductId == id; }));
                    Console.WriteLine("Delete sucess !");
                    count = 1;
                    break;
                }
                else
                {
                    count = 0;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("Not Found ProductId : {0}", id);
            }
        }
    }
}
