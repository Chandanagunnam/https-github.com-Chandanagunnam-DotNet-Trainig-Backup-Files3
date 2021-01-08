using System;

namespace class_object
{
    //Create a class called Saledetails which has data members like Salesno, Productno, Price, dateofsale, Qty, TotalAmount
    //Create a method called Sales() that takes qty, Price details of the object and updates the TotalAmount as Qty* Price
    //Pass the other information like SalesNo, Productno, Price, Qty and Date of sale through constructor
    //call the show data method to display the values.
    //Hint : Use This pointer
    class Salesdetails
    {
        int sales_no, production_no,Qty;
        float price,Totalamount;
        DateTime dateofsale;
        internal float Sales(int Qty, float price)
        {
            Totalamount = Qty * price;
            return Totalamount;
        }
        internal Salesdetails(int sales_no, int production_no,DateTime dateofsale,int Qty,float price)
        {
            this.sales_no = sales_no;
            this.production_no = production_no;
            this.Qty = Qty;
            this.dateofsale = dateofsale;
            this.price = price;
        }
       internal void ShowData()
        {
            Console.WriteLine("sales no. = {0} || productn no. = {1} || quantity = {2} ||" +
                " dateofsale = {3} || price = {4} || total amount ={5}"
                , sales_no, production_no, Qty, dateofsale, price,Totalamount);

        }

    }
    class SalesAssignment
    {
        static void Main()
        {
            Console.WriteLine("enter size of array of objects");
            int size = Convert.ToInt32(Console.ReadLine());
            Salesdetails[] objsales = new Salesdetails[size];
            int sales_no, production_no, Qty;
            float price;
            DateTime dateofsale;
            for (int i=0;i < objsales.Length;i++)
            {
                Console.WriteLine("enter sales_no, production_no, Qty,price, dateofsale");
                sales_no = Convert.ToInt32(Console.ReadLine());
                production_no = Convert.ToInt32(Console.ReadLine());
                Qty = Convert.ToInt32(Console.ReadLine());
                float.TryParse(Console.ReadLine(), out price);
                DateTime.TryParse(Console.ReadLine(),out dateofsale);
                objsales[i] = new Salesdetails(sales_no, production_no, dateofsale,Qty,price);
                Console.WriteLine("TotalAmount = {0}", objsales[i].Sales(Qty,price));
                objsales[i].ShowData();
            }
            Console.Read();
        }
    }
}
