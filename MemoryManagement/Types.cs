class Types
{
    public Types()
    {


        //Value types are Primitive datatype while reference types are objects


        int yint = 100;
        Test obj = new Test();
        obj.Age = 100;
        Test obj1;
        int zint = yint;
        obj1 = obj;
        int temp = 9999;
        obj1.Age = temp;

        // System.Console.WriteLine(temp);
        System.Console.WriteLine(obj1.Age);

    }

    class Test
    {

        public string Name = string.Empty;
        public int Age;

    }


}

