using System;

namespace ExceptionHandling
{
    class SystemExceptionEg
    {
        static void Main()
        {
            int num = 30;
            //num = num/0'
            string[] fruits = { "apple", "kiwi" };
            int[,] arr = { { 5, 10 }, { 8, 17 }, { 7, 7 } };
            try
            {
                Console.WriteLine("num = {2}", num);
                Console.WriteLine("fruits[2] = {0}", fruits[2]);
                //Console.WriteLine("num = {2}", num);

                num = num / 0;
                int add = 10 + 45;
                Console.WriteLine("add = {0}", add);

            }
            
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Message :{0}", ex);
                Console.WriteLine("--------------------------");
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Message :{0}", ex);
                Console.WriteLine("--------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message :{0}", ex);
                Console.WriteLine("--------------------------");
                Console.WriteLine("only Message :{0}", ex.Message);
                Console.WriteLine("--------------------------");
                Console.WriteLine("stacktrace Message :{0}", ex.StackTrace);
                Console.WriteLine("--------------------------");
                Console.WriteLine("Source--Message :{0}", ex.Source);
                Console.WriteLine("--------------------------");
                Console.WriteLine(" our own msg--please check namespace");

            }
            
            finally
            {
                Console.WriteLine("used to close opened connection");
            }
            num = num * num;
            Console.WriteLine("Multiply :{0}",num);
            Console.WriteLine("end of system exceptn");
            Console.Read();
        }
    }
}
