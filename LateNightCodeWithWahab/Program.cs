using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LateNightCodeWithWahab
{
    class Program
    {
        static void Main(string[] args)
        {
            Task taskA = Task.Run(() => Thread.Sleep(2000));
            Console.WriteLine(taskA.Status);
            try
            {
                taskA.Wait();
                Console.WriteLine(taskA.Status);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception in taskA.");
            }
            Console.Read();
        }
    }
}
