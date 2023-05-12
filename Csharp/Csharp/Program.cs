using System;

namespace Study
{
    class Program
    {
        static Task Test()
        {
            Console.WriteLine("Start Test");
            Task t = Task.Delay(3000);
            return t;
        }

        static void TestAsync()
        {
            Console.WriteLine("Start TestAsync");
            Task t = Task.Delay(3000);
            t.Wait();
            Console.WriteLine("End TestAsync");
        }
        
        static void Main(string[] args)
        {
            Task t = Test();
            t.Wait();
            
            Console.WriteLine("While start");
            while(true){}
        }
    }
}