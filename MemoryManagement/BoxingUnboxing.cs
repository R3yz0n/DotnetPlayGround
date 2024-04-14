using System;
class BoxingUnboxing
{
    public BoxingUnboxing()
    {

        System.Console.WriteLine("Boxing unboxing");
        //Boxing When variables/objects moves from Stack to Heap
        //UnBoxing When variables/objects moves from Heap to Stack

        int inti = 100;
        Object obj = inti; //This is boxing
        System.Console.WriteLine(obj);
        int intz = Convert.ToInt32(obj); //This is unboxing
        System.Console.WriteLine(intz);


    }


}