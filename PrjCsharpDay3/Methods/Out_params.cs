using System;

namespace Methods
{
    class Out_params
    {
        void Calculation(float n1,float n2,int l,out float s,out float p,out int c)
        {
            s = n1 + n2;//float
            p = n1 * n2;//float
            c = l + 2 * 4;//int
        }
        void StudentDetails(string name,params string[] hobbies)
        {
            Console.WriteLine("name:{0}", name);
            for(int i=0;i<hobbies.Length;i++)
            {
                Console.WriteLine(hobbies[i]);
            }
        }
        static void Main()
        {
            //out parameter--need not initialize before
            float num1 = 10, num2 = 80;
            int length = 10;
            float sum, product;
            int cal;
            Out_params objoutpar = new Out_params();
            objoutpar.Calculation(num1, num2, length, out sum, out product, out cal);
            if(sum>0 && product>0)
            {
                Console.WriteLine("Sum:{0} || product:{1} || cal{2}", sum, product, cal);
            }
            Console.WriteLine("------------------");
            //string[]h = new string[3] {"singing","dancing","reading"};
            //params is keyword which is used to specify a parameter that takes variable number of arguments
            //only one params keyword is allowed and no additional parameter is allowed in a argument list after the params keyword
            //argument with params --it must be last parameter in the argument list
            //obj.StudentDetails("sumitha",Singing","playing","chennai",90,80);
            objoutpar.StudentDetails("Edward", "sing", "dance", "read");
            Console.Read();
        }
    }
}
