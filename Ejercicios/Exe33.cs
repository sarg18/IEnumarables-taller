namespace Ejercicios
{
    public class Exe33
    {
        private int[,] A; private int[,] B; private int[,] C;

        public int N { get; }
        public int M { get; }
        public int P { get; }

        public Exe33(int _m, int _n, int _p)
        {
            N = _n; M = _m; P = _p;
            A = new int[_m, _n];
            B = new int[_n, _p];
            C = new int[_m, _p];

        }

        public void FillA()
        {
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = (i + 1) * j;
                }
            }
        }

        public void FillB()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < P; j++)
                {
                    B[i, j] = (j + 1) * i;
                }
            }

        }

        public void FillC()
        {
            var result = 0;
            var i = 0;
            var j = 0;
            for (int k = 0; k < M; k++)
            {

                for (int w = 0; w < P; w++)
                {
                    for (int l = 0; l < M + 1; l++)
                    {
                        result += A[k, l] * B[l, w];
                    }

                    C[i, j] = result;
                    result = 0;
                    j++;

                }

                j= 0;
                i++;
            }
            
        }


        public string PrintB()
        {
            var outputB = string.Empty;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < P; j++)

                {
                    outputB += $"{B[i, j]}\t";
                }
                outputB += "\n";

            }
            return outputB;
        }

        public string PrintC()
        {
            var outputC = string.Empty;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < P; j++)

                {
                    outputC += $"{C[i, j]}\t";
                }
                outputC += "\n";

            }
            return outputC;
        }

        public override string ToString()
        {
            var outputA = string.Empty;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    outputA += $"{A[i, j]}\t";
                }
                outputA += "\n";

            }

            return $"{outputA}";
        }



    }

}