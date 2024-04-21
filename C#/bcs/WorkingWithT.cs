public class WorkingWithT
{

    public int reyzon;
    public WorkingWithT()
    {
        System.Console.WriteLine(typeof(List<string>));
        System.Console.WriteLine(typeof(String));
        int[] numbers = new int[] { 1, 2 };

        numbers = [.. numbers, 99];
        System.Console.WriteLine(numbers);

        foreach (var number in numbers)
        {
            System.Console.WriteLine(number);
        }

        var names = new List<string>() { "Reyzon", "Sagar", "Thapa" };

        System.Console.WriteLine(typeof(List<string>));




        System.Console.WriteLine(names[^2]);


        // foreach (var name in names)
        // {
        //     System.Console.WriteLine(name);
        // }










    }
}