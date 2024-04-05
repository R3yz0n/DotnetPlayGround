
using System.Runtime.InteropServices;

class WorkingWithConditions
{
    public WorkingWithConditions()
    {
        int a = 5;
        int b = 6;

        if ((a + b) > 10)
        {
            System.Console.WriteLine("The answer is greater than 10 ");
        }





        int[] numbers = { 1, 2, 3, 4, 5 };

        // Iterate over each element in the array
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }


    }
}