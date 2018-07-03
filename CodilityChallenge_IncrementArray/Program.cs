using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityChallenge_IncrementArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 1, 0, 0, 0, 0, 0, 0 };

            ArrayIncrementer ai = new ArrayIncrementer();
            ai.Solution(A);

            Console.ReadKey();
        }
    }
}
