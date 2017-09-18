using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversionApp
{
    class ExplicitConversion
    {
        static double d;
        static int b;
        static bool a;

        static void Main(string[] args)
        {
            string[] str= new string[3];
            d = 100.27567;
            b = (int)d;
            str[0] = "String value of double d: " + d.ToString();
            a = true;
            str[1] = "String value of boolean a: " + a.ToString();
            str[2] = "String value of int b: " + b.ToString();
            
            foreach (string s in str) {
                Console.WriteLine(s);
            }
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Square of num: {0}", num * num);


            Console.ReadKey();
            
        }
    }
}
