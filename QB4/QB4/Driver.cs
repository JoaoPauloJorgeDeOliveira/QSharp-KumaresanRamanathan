using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;

namespace Quantum.QB4
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var sim = new QuantumSimulator())
            {
                
                var res = QB4Run.Run(sim).Result;
                var (p0000, p0001, p0010, p0011, p0100, p0101, p0110, p0111, 
                    p1000, p1001, p1010, p1011, p1100, p1101, p1110, p1111) = res;

                // Prints results divided by 10 k. In other words, the results are in p.u..
                System.Console.WriteLine("0000 -> " + String.Format("{0:000.00}", p0000 / 100.0) + " %");
                System.Console.WriteLine("0001 -> " + String.Format("{0:000.00}", p0001 / 100.0) + " %");
                System.Console.WriteLine("0010 -> " + String.Format("{0:000.00}", p0010 / 100.0) + " %");
                System.Console.WriteLine("0011 -> " + String.Format("{0:000.00}", p0011 / 100.0) + " %");
                System.Console.WriteLine("0100 -> " + String.Format("{0:000.00}", p0100 / 100.0) + " %");
                System.Console.WriteLine("0101 -> " + String.Format("{0:000.00}", p0101 / 100.0) + " %");
                System.Console.WriteLine("0110 -> " + String.Format("{0:000.00}", p0110 / 100.0) + " %");
                System.Console.WriteLine("0111 -> " + String.Format("{0:000.00}", p0111 / 100.0) + " %");
                System.Console.WriteLine("1000 -> " + String.Format("{0:000.00}", p1000 / 100.0) + " %");
                System.Console.WriteLine("1001 -> " + String.Format("{0:000.00}", p1001 / 100.0) + " %");
                System.Console.WriteLine("1010 -> " + String.Format("{0:000.00}", p1010 / 100.0) + " %");
                System.Console.WriteLine("1011 -> " + String.Format("{0:000.00}", p1011 / 100.0) + " %");
                System.Console.WriteLine("1100 -> " + String.Format("{0:000.00}", p1100 / 100.0) + " %");
                System.Console.WriteLine("1101 -> " + String.Format("{0:000.00}", p1101 / 100.0) + " %");
                System.Console.WriteLine("1110 -> " + String.Format("{0:000.00}", p1110 / 100.0) + " %");
                System.Console.WriteLine("1111 -> " + String.Format("{0:000.00}", p1111 / 100.0) + " %");
            }
            
            System.Console.ReadKey();
        }
    }
}