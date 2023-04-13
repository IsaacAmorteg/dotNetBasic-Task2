using System; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Array Numbers Swapper");
        Console.WriteLine("Enter the array values, separated by commas:");
        string input = Console.ReadLine();
        string[] values = input.Split(',');
        int[] array = new int[values.Length];

        for (int i = 0; i< values.Length; i++)
        {
            array[i] = int.Parse(values[i]);
        }

        int swap;

        for (int i = 0; i < array.Length / 2; i++)
        {
            swap = array[i];
            array[i] = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = swap;
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.ReadKey();
    }
}