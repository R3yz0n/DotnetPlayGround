public class WorkingWithString
{

    public WorkingWithString()
    {
        // Console.WriteLine("Working with strings in C#");
        // I'm working on a single file as of now we'll proceed with multiple files later on.


        // string firstName = "              BOb         sagar ";
        string firstName = " Sagar     Reyzon   ";

        // The Trim() method removes all the whitespaces in the front as wellas back wee also have TrimStart() and TrimEnd()
        // to remove whitespaces from the start and end respectively


        Console.WriteLine($"{firstName} {firstName.Length}");



        string sayHello = "Hello World!";
        // Console.WriteLine(sayHello);
        sayHello = sayHello.Replace("Hello", "Greetings");


        var name = "<name>";
        // var name = "sagar";
        // Console.WriteLine($"Hello {name}!");




        var names = new[] { "<name>", "Felipe", "Emillia" };
        System.Console.WriteLine(names);
        foreach (var name in names)
        {
            Console.WriteLine($"Hello {name.ToUpper()}!");
        }
    }
}