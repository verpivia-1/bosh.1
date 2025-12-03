using System;

namespace bosh
{
  
    internal class Program
    {
        static int Test(int a, int b)
        {

            int sum=0;
            for (int i=a; i<=b; i++)
            {
                sum+=i;
            }
            return sum;
        }
        /*
        static int SubTest(int a, int b)
        {
            int Calamity = Test(a,b);
            Test(a,b);
            
            return Calamity;
        }
        */
        
        static void Main(string[] args)
        {
            int[] Arrow = new int[2];
            Arrow[0] = 1;
            Arrow[1] = 6;

            int resurt = Test(Arrow[0], Arrow[1]);
            Console.WriteLine(resurt);
        }
    }
}