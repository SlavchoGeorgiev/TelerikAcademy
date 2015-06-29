namespace MyClasses
{
    using System;
    using System.Text;

    public class Matrix<T>
        where T : IComparable<T>
    {
        private T[,] mtx;

        public Matrix(int rows, int cols)
        {
            this.mtx = new T[rows, cols];
            this.Rows = rows;
            this.Cols = cols;
        }

        public int Rows { get; private set; }

        public int Cols { get; private set; }

        public T this[int row, int col]
        {
            get
            {
                return this.mtx[row, col];
            }

            set
            {
               this.mtx[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Cols != matrix2.Cols || matrix1.Rows != matrix2.Rows)
            {
                throw new ArgumentException("Matrices must be with the same size.");
            }

            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix1.Cols);
            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    result[row, col] = (dynamic)matrix1[row, col] + (dynamic)matrix2[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Cols != matrix2.Cols || matrix1.Rows != matrix2.Rows)
            {
                throw new ArgumentException("Matrices must be with the same size.");
            }

            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix1.Cols);
            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    result[row, col] = (dynamic)matrix1[row, col] - (dynamic)matrix2[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Cols || matrix1.Cols != matrix2.Rows)
            {
                throw new ArgumentException();
            }

            var result = new Matrix<T>(matrix1.Rows, matrix2.Cols);
            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    for (int index = 0; index < matrix1.Cols; index++)
                    {
                        result[row, col] += (dynamic)matrix1[row, index] * (dynamic)matrix2[index, col];
                    }
                }
            }

            return result;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            return BooleanOperator(matrix, true);
        }

        public static bool operator false(Matrix<T> matrix)
        {
            return BooleanOperator(matrix, false);
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            for (int rol = 0; rol < this.Rows; rol++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    result.Append(string.Format("{0,5}", this.mtx[rol, col]));
                }

                result.AppendLine();
            }

            return result.ToString();
        }

        private static bool BooleanOperator(Matrix<T> matrix, bool boolCheck)
        {
            foreach (var element in matrix.mtx)
            {
                if (!element.Equals(default(T)))
                {
                    return boolCheck;
                }
            }

            return !boolCheck;
        }
    }
}
