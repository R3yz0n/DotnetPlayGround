
public class WhatGoesWhere
{
    public WhatGoesWhere()
    {

        //Primitive Data Type (value type) are stored in Stack and objects (refernce type) are stored in Heap 
        //Object reference pointer are stored on stack while actual object is stored on heap
        // Obj is stored in stack(it is the reference to actual object) Obj.Name ,Obj.age are stored in heap     

        // ****EVen primitive DT can go  stored in heap****** 

        //But there is a catch ????????????????


        // ******  Here comes the confusion ********
        // In a stack primitive data types  memory address points to the actual value
        // In object its memory address points to other memory address points and that memory address towards the actual object data

        int yint;
        Test obj = new Test();
        bool xbool;
        System.Console.WriteLine(obj);

        yint = 100;
        obj = new Test();
        obj.Name = "Shiv";
        obj.Age = 30;
        xbool = true;



    }

    class Test
    {

        public string Name = string.Empty;
        public int Age;

    }

}