using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    internal class Program
    {
        static int count = 0;
        static void Main(string[] args)
        {
            towerofHanoi(3, 'A', 'B', 'C');
            Console.WriteLine(count);
        }
        public static void towerofHanoi(int n, char fromRod, char toRod, char auxRod)
        {
           
            if (n == 1)
            {
                Console.WriteLine("Move disk 1 from " + fromRod + " to rod " + toRod);
                count++;
                return;
            }
            else
            {
                towerofHanoi(n - 1, fromRod, auxRod, toRod);
                Console.WriteLine("Move disk " + n + " from rod " + fromRod + " to rod " + toRod);
                count++;
                towerofHanoi(n - 1, auxRod, toRod, fromRod);
              
            }
           
        }
    }
}
