namespace array_project;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many groups of students?");
        int amountOfGroups = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("How many students per group?");
        int amountOfStudents = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        int[,] gradesArray = new int[amountOfGroups, amountOfStudents];
        int[] averageArray = new int[amountOfGroups];

        for (int row = 0; row < gradesArray.GetLength(0); row++)
        {
            int sumGroup = 0;
            for (int column = 0; column < gradesArray.GetLength(1); column++)
            {
                Console.WriteLine("Input grades into array");
                Console.Write($"Group {row + 1}, student {column + 1}: ");
                gradesArray[row, column] = Convert.ToInt32(Console.ReadLine());

                sumGroup += gradesArray[row, column];
                Console.Clear();
            }
            averageArray[row] = sumGroup / gradesArray.GetLength(1);
        }

        for (int i = 0; i < averageArray.Length; i++)
        {
            Console.WriteLine($"The average of group {i + 1} is: {averageArray[i]}.");
        }
    }
}

