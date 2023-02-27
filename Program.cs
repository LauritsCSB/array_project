namespace array_project;
class Program
{
    static void Main(string[] args)
    {
        int[,] grades = new int[2, 5];
        int sumGroupOne = 0;
        int sumGroupTwo = 0;

        Console.WriteLine("Input grades into array");
        for (int row = 0; row < grades.GetLength(0); row++)
        {
            for (int column = 0; column < grades.GetLength(1); column++)
            {
                Console.Write($"Group {row + 1}, student {column + 1}: ");
                grades[row, column] = Convert.ToInt32(Console.ReadLine());

                if (row < grades.GetLength(0) - 1)
                {
                    sumGroupOne += grades[row, column];
                }
                else
                {
                    sumGroupTwo += grades[row, column];
                }
            }
        }
   
        Console.WriteLine($"The average of group 1 is: {sumGroupOne / grades.GetLength(1)}.");
        Console.WriteLine($"The average of group 2 is: {sumGroupTwo / grades.GetLength(1)}.");
    }
}

