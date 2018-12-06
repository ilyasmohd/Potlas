using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> task = HandleFileAsync();

            // Control returns here before HandleFileAsync returns.
            // ... Prompt the user.
            Int64 size = 0;
            for (int z = 0; z < 100; z++)
            {
                for (int i = 0; i < 100000; i++)
                {
                    string value = i.ToString();
                    size += value.Length;
                }
            }
            Console.WriteLine("Please wait patiently " +
                "while I do something important.");


            task.Wait();
            var x = task.Result;
            Console.WriteLine("Count: " + x);

            Console.WriteLine("[DONE]");
            Console.ReadLine();
        }        

        static async Task<int> HandleFileAsync()
        {
            string file = @"enable1.txt";
            Console.WriteLine("HandleFile enter");
            int count = 0;
            
            //...Use async StreamReader method.
            using (StreamReader reader = new StreamReader(file))
            {
                //string v = await reader.ReadToEndAsync();
                int t1 = await Task.Run(() => Allocate());
                int t = await Task.Run(() => Allocate());

                //int z = await HandleFileAsync123();
                // ... Process the file data somehow.
                //count += v.Length;

                //// ... A slow-running computation.
                ////     Dummy code.
                //for (int i = 0; i < 10000; i++)
                //{
                //    int x = v.GetHashCode();
                //    if (x == 0)
                //    {
                //        count--;
                //    }
                //}

                //for (int i = 0; i < 100000000; i++)
                //{
                //    //Console.WriteLine(i);
                //}
            }
            Console.WriteLine("HandleFile exit");
            return 123;
        }
        static int Allocate()
        {
            // Compute total count of digits in strings.
            int size = 0;
            for (int z = 0; z < 10000; z++)
            {
                for (int i = 0; i < 10000; i++)
                {
                    string value = i.ToString();
                    size += value.Length;
                }
            }
            return size;
        }


    }
}
