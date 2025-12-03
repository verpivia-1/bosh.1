using System;

namespace bosh
{
  
    internal class Program
    {
        static void Swap(ref int a,ref int b)
        {
            int c = a;
            a = b;
            b = c;
            
        }
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Swap(ref x,ref y);
            Console.WriteLine($"{x},{y}");

        }
    }
}