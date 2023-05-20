using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices.Logic
{
    public class Exe34
    {
        
        private int[,] _matrix;
        private int _n; // rows
        private int _m; // columns

        public object N { get; private set; }

        public Exe34()
        {
            _n = 11;
            _m = 11;
            _matrix = new int[_n, _m];     
        }

       

        public void Fill()
        {
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _m; j++)
                {
                    _matrix[i, j] = (i * 2) + j;
                }
            }

        }

        public string Wacth()
        {
            
            var output = string.Empty;
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _m; j++)
                {
                    if (i <= _n / 2)
                    {
                        if (j >= i && j < _m - i)
                        {
                            output += $"{_matrix[i, j]}\t";
                            
                        }
                        else
                        {
                            output += "\t";
                        }
                        
                    }
                    else
                    {
                        if (j >= _m - i - 1 && j <= i)
                        {
                            output += $"{_matrix[i, j]}\t";
                        }
                        else
                        {
                            output += "\t";
                        }
                        
                    }
                }
                output += "\n";
            }
            return output;
        }

      

        public override string ToString()
        {
            var output = string.Empty;
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _m; j++)
                {
                    output += $"{_matrix[i, j]}\t";
                }
                output += "\n";
            }
            return output;
        }


    }
}
