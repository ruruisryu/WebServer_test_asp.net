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

        // await을 사용하기 위해서는 함수에 async를 선언해주어야한다.
        // 반환형은 항상 Task
        static async Task TestAsync()
        {
            Console.WriteLine("Start TestAsync");
            // Task가 완료된 후에ㅣ End TestAsync 출력
            // 하지만 외부에서 Task가 완료될 때까지 기다리지는 않는다.
            await Task.Delay(3000);
            Console.WriteLine("End TestAsync");
        }
        
        static async Task Main(string[] args)
        {
            //Task t = Test();
            //t.Wait();
            
            //이부분의 await는 Main에 대해 대기를 걸어버림.
            // 그러므로 TestAsync()가 완료될 때까지 그 아래 스크립트 실행하지 못함.
            await TestAsync();

            Console.WriteLine("While start");
            while(true){}
        }
    }
}