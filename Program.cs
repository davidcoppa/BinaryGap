using System;

namespace BinaryGap
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BinaryGap g = new BinaryGap();
            
            int value1 = g.solution(32);
            int value2 = g.solution(9);
            int value3 = g.solution(20);
            int value4 = g.solution(15);
            int value5 = g.solution(1041);
            int value6 = g.solution(1984);

            Console.WriteLine("Number 32    - gap is:" + value1);
            Console.WriteLine("Number 9     - gap is:" + value2);
            Console.WriteLine("Number 10    - gap is:" + value3);
            Console.WriteLine("Number 20    - gap is:" + value4);
            Console.WriteLine("Number 1041  - gap is:" + value5);
            Console.WriteLine("Number 1984  - gap is:" + value6);
            Console.ReadLine();

        }


        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>();
        //        });
    }
}
