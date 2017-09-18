using System;

namespace DataTypeApplication
{
    class Program
    {
        int num;
        object obj;
        dynamic item;
        // int* num_ptr;

        public void Details()
        {
            obj = 100;
            item = 200;
            num = 250;
        }

        public int GetNum()
        {      
            return num;
        }

        public void ShowDetails()
        {
            Console.WriteLine("object is: {0}", obj);
            Console.WriteLine("item is: {0}", item);
            Console.WriteLine("number is: {0}", num);
            // Console.WriteLine("location of num: {0}", num_pt);
        }

      

        static void Main(string[] args)
        {
            Program r = new DataTypeApplication.Program();
            r.Details();
            r.ShowDetails();

            Console.WriteLine("Size of int: {0}", sizeof(int));
                      
            Console.ReadKey();
        }
    }
}
