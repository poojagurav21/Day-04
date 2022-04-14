//B a = new B();
//a.DisplayB();
////a.Display();



//class A
//{
//    protected void Display()
//    {
//        Console.WriteLine("A display");
//    }
//}

//class B:A
//{
//    public void DisplayB()
//    {
//        Console.WriteLine("B display");
//        Display();
//    }
//}


A a = new();
A b=new();
A c=new();
A d=new();
a.Display();
Console.WriteLine(A.count);

class A
{
    public static int count = 0;
    public A()
    {
        count++;
    }
    public void Display()
    {
        Console.WriteLine("Count= " + count);
    }
}