public class WorkingWithT
{

    public int reyzon;
    public WorkingWithT()
    {
        System.Console.WriteLine(typeof(List<string>));
        System.Console.WriteLine(typeof(String));
        int[] numbers = { 1, 2 };
        var names = new List<string>() { "Reyzon", "Sagar", "Thapa" };
        System.Console.WriteLine(typeof(List<string>));

        System.Console.WriteLine(names[0]);

        foreach (var name in names)
        {
            System.Console.WriteLine(name);
        }










    }
}