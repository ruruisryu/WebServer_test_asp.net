using System;

namespace Study
{
    class async_await
    {
        static Task Test()
        {
            Console.WriteLine("Start Test");
            Task t = Task.Delay(3000);
            return t;
        }

        static async void TestAsync()
        {
            Console.WriteLine("Start TestAsync");
            Task t = Task.Delay(3000);
            await t;
            Console.WriteLine("End TestAsync");
        }
        
        static void Main(string[] args)
        {
            //Task t = Test();
            //t.Wait();
            
            TestAsync();

            Console.WriteLine("While start");
            while(true){}
        }
    }
}