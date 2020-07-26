using System;
using System.Threading;

namespace dotnet_console
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
	        while (true) {
                total += 3;
                writeStatus(total);
	        }
        }

        static void writeStatus(int total) {
                Console.WriteLine("Hello World!");
                Console.WriteLine("Waiting 3 seconds...");
                Thread.Sleep(3000);
                
                Console.WriteLine ("\nWaited " + total + " total seconds.");
                Console.WriteLine ("-----------------------------------\n");
        }
    }
}
