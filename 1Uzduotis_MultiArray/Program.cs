namespace _1Uzduotis_MultiArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthX = Convert.ToInt32(Console.ReadLine());
            int lengthY = Convert.ToInt32(Console.ReadLine());
            int[,] numberArray2D = new int[lengthX, lengthY];

            for (int i = 0; i < lengthX; i++)
            {
                for (int j = 0; j < lengthY; j++)
                {
                    int inputNumber = Convert.ToInt32(Console.ReadLine());
                    numberArray2D[i, j] = inputNumber;
                }
            }
            for (int i = 0; i < lengthX; i++)
            {
                for (int j = 0; j < lengthY; j++)
                {
                    Console.Write(numberArray2D[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}