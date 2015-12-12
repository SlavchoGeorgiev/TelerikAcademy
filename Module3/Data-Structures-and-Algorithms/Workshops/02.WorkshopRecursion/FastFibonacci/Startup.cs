namespace FastFibonacci
{
    using System;

    public class Matrix
    {
        private const int MOD = 1000000007;

        public Matrix()
        {
            this.Table = new long[2, 2];
        }

        public Matrix(long a, long b, long c, long d) : this()
        {
            this.Table[0, 0] = a;
            this.Table[0, 1] = b;
            this.Table[1, 0] = c;
            this.Table[1, 1] = d;
        }

        public Matrix(Matrix A, Matrix B) : this()
        {
            this.Table[0, 0] = A.Table[0, 0] * B.Table[0, 0] + A.Table[0, 1] * B.Table[1, 0];
            this.Table[0, 1] = A.Table[0, 0] * B.Table[0, 1] + A.Table[0, 1] * B.Table[1, 1];
            this.Table[1, 0] = A.Table[1, 0] * B.Table[0, 0] + A.Table[1, 1] * B.Table[1, 0];
            this.Table[1, 1] = A.Table[1, 0] * B.Table[0, 1] + A.Table[1, 1] * B.Table[1, 1];

            this.Table[0, 0] %= MOD;
            this.Table[0, 1] %= MOD;
            this.Table[1, 0] %= MOD;
            this.Table[1, 1] %= MOD;
        }

        public long[,] Table { get; set; }
    }

    public class Startup
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(Pow(new Matrix(1, 1, 1, 0), n).Table[0,1]);

        }

        public static Matrix Pow(Matrix a, long p)
        {
            if (p == 1)
            {
                return a;
            }

            if (p % 2 == 1)
            {
                return new Matrix(Pow(a, p - 1), a);
            }

            a = Pow(a, p / 2);
            return new Matrix(a, a);
        }
    }
}
