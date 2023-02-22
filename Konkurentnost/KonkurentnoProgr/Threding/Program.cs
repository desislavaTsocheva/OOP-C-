using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threding
{
    public class Program
    {
        static void Print()
        {
            Console.WriteLine("Daughter thread is starting.");
            for (int i = 1; i < 15; i++)
            {
                Console.WriteLine("Daughter thread:"+i);
                System.Threading.Thread.Sleep(2500);
            }
            Console.WriteLine("daugter thread is complied!");
        }
        static void Words()
        {
            Console.WriteLine("Main thread is starting");
            for (char i = 'a'; i < 'z' ; i++)
            {
                Console.WriteLine("Мain thread:"+i);
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("main thread is complied!");
        }
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Print);
            thread1.Start();
            Thread.Sleep(3000);
            Thread t2 = new Thread(Words);
            t2.IsBackground = true;
            t2.Start();
            //Thread t3 = new Thread(Print);
            //t3.Start();
            //Thread.Sleep(1000);
            //t3.Abort();

        }
    }
}
