namespace Assignment_5._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();

            int size = rng.Next(2, 5);
            int[][] matrix = new int[size][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[size];
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = rng.Next(10);
                }
            }

            Console.WriteLine("The matrix is: ");
            foreach (var row in matrix)
            {
                foreach (var item in row)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Addition of the right diagonal elements is: {SumMatrixRightDiagonal(matrix)}");
        }

        static int SumMatrixRightDiagonal(int[][] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i][i];
            }
            return sum;
        }
    }
}
