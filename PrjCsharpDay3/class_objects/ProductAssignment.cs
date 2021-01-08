using System;

namespace class_objects
{
    //Create a Product class containing pid ,pname,price of product and shopname as static .
    //fetch multiple product details from user and display the same along with shopname
    class Product
    {
         internal static string shopname;
        int pid;
        string pname;
         float price;
        internal Product(int pid, string pname, float price)
        {
            this.pid = pid;
            this.pname = pname;
            this.price = price;
        }
        internal void DisplayProducts()
        {
            Console.WriteLine("pid : {0} || pname :{1} || price :{2} || shopname :{3}", pid, pname, price, shopname);
        }


    }
    class ProductAssignment
    {
        static void Main()
        {
            Console.WriteLine("enter size of array of objects");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter shopname");
            Product.shopname = Console.ReadLine();
            Product[] objproducts = new Product[size];
            int pid; string pname; float price;
            for (int i = 0; i < objproducts.Length; i++)
            {
                Console.WriteLine("enter pid");
                pid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter pname");
                pname = Console.ReadLine();
                Console.WriteLine("enter price");
                float.TryParse(Console.ReadLine(), out price);
                objproducts[i] = new Product(pid, pname, price);
                objproducts[i].DisplayProducts();
            }
            Console.Read();

        }
    }
}