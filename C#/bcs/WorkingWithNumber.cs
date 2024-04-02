public class WorkingWithNumber
{

    public WorkingWithNumber()
    {

        // int firstNumber = 327679999;
        // int secondNumber = 327600009;
        // long result = checked(firstNumber * secondNumber);
        // System.Console.WriteLine(result);
        // Console.WriteLine(typeof(short));
        // Console.WriteLine((firstNumber + secondNumber));
        // Console.WriteLine($"{firstNumber} {secondNumber}");

        // int guessTheNumber = Convert.ToInt32(Console.ReadLine());
        // decimal decinmalValue = 5.5M;

        // Console.WriteLine(decinmalValue);
        // Console.WriteLine("hello");
        // double n = Convert.ToDouble("222.22");
        // Console.WriteLine(n);
        // System.Console.WriteLine("Hello World");
        // System.Console.WriteLine(typeof(int));

        float f1 = 90.2F;
        double d1 = 90.0;
        // System.Console.WriteLine(f1 == f2);
        double d = f1 + d1;
        System.Console.WriteLine(d);
        // System.Console.WriteLine((decimal)((42.1 + 21.1F)));
        // System.Console.WriteLine(short.MinValue);



        //TO solve this issue we could use decimal
        decimal dc1 = 10.1M;
        decimal dc2 = 20.1M;
        decimal dc3 = dc1 + dc2;
        System.Console.WriteLine(dc3);



    }
}