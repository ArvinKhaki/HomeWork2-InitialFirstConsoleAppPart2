namespace HomeWork2.Task3And4;
internal class Statistics
{
    public void AnalyzeNumbers(int num1, ref int num2, out int num3)
    {
        num3 = num1 + num2;

        num2 = num2 * num2;
    }

    public void AnalyzeArray(double[] array, ref int max, out double average)
    {
        if (array == null || array.Length == 0)
        {
            max = 0;
            average = 0.0;
            return;
        }

        double sum = 0;
        max = (int)array[0]; 
        foreach (double value in array)
        {
            sum += value;

            if (value > max)
                max = (int)value;
        }

        average = sum / array.Length;
    }
} 
