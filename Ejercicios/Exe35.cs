using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercices.Logic
{
    public class Exe35
    {
        private int _n;


        public int N { get; }

        public List<int> Factors(int N)
        {
            List<int> factors = new List<int>();
            for (int i = 2; i <= _n; i++)


            {
                while (N % i == 0)
                {
                    factors.Add(i);
                    N /= i;
                }

            }
            return factors;

        }


    }


}









