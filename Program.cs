namespace Assignment_5._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = [[1,2],[3,4]];

            Console.WriteLine("The matrix is: ");
            foreach (var row in matrix)
            {
                foreach (var element in row)
                {
                    Console.Write($"{element} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Addition of the right diagonal elements is: {SumMatrixRightDiagonal(matrix)}");
        }

        static int SumMatrixRightDiagonal(int[][] matrix)
        {
            int sum = 0;
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                sum += matrix[r][r];
            }
            return sum;
        }
    }
}
