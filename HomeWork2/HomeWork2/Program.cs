using HomeWork2.Task3And4;
class Program
{
    public static void MainMenu()
    {
        Console.Clear();
        Console.Write(
            """
            1. Analyze Numbers
            2. Analyze Array
            3. Exit
            Choose Your Action(By Number): 
            """);
    }
    public static void NumberAnalyzer()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine()!);

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine()!);

        Console.Write("Enter third number: ");
        int num3 = int.Parse(Console.ReadLine()!);

        Statistics statistics = new Statistics();

        Console.WriteLine(
            $"""
            Initial Numbers:
            number 1 = {num1}
            number 2 = {num2}
            number 3 = {num3}
            """);

        statistics.AnalyzeNumbers(num1, ref num2, out num3);

        Console.WriteLine(
          $"""
            Numbers After Changes:
            number 1 = {num1}
            number 2 = {num2}
            number 3 = {num3}
            """);
    }
    public static void ArrayAnalyzer()
    {
        Console.Write("Enter the size of Array you want to create: ");
        int arraySize = int.Parse(Console.ReadLine()!);

        double[] array = new double[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write($"Please Enter {i + 1}st Number: ");
            array[i] = double.Parse(Console.ReadLine()!);
        }

        Statistics statistics = new Statistics();

        int max = 0;
        double average;

        statistics.AnalyzeArray(array, ref max, out average);

        Console.WriteLine($"Maximum value: {max}");
        Console.WriteLine($"Average value: {average}");
    }
    static void Main()
    {
        string input = "";
        do
        {
            MainMenu();
            input = Console.ReadLine()!;
            switch (input)
            {
                case "1":
                    NumberAnalyzer();
                    Console.ReadKey();
                    break;

                case "2":
                    ArrayAnalyzer();
                    Console.ReadKey();
                    break;

                case "3":
                    Console.WriteLine("Exiting........");
                    break;

                default:
                    Console.WriteLine("Invalid option. Press any key...");
                    Console.ReadKey();
                    break;
            }
        } while (input != "3");
    }
}