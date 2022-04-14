
//overloading


//A a = new A();
//a.Show();
//a.Show(5);
//a.Show(5.7f);
//a.Show(5, 7);
//a.Show(6, 7.9f);

//class A
//{
//    public void Show()
//    {
//        Console.WriteLine("Showing");
//    }
//    public void Show(int a)
//    {
//        Console.WriteLine("Showing " + a);
//    }
//    public void Show(float b)
//    {
//        Console.WriteLine("Showing " + b);
//    }
//    public void Show(int a,int b)
//    {
//        Console.WriteLine("int "+a+",int "+b);
//    }
//    public void Show(int a, float b)
//    {
//        Console.WriteLine("int " + a + ",float " + b);

//    }
//}



//overriding
//Animal a = new Animal();
//a.eat();
//Dog aa = new Dog();
//aa.eat();
//Cat bb = new Cat();
//bb.eat();

//class Animal
//{
//    public  void eat()
//    { 
//        Console.WriteLine("eating style...");
//    }

//}

//class Dog:Animal
//{
//    public  void eat()
//    {
//        Console.WriteLine("licking...");
//    }
//}

//class Cat:Animal
//{
//    public  void eat()
//    {
//        Console.WriteLine("drinking....");
//    }
//}



// Abstraction

Animal a = new Dog();
a.Sound();
a.Show();

Animal b = new Cow();
b.Sound();
b.Show();

abstract class Animal
{
    public abstract void Sound();
    public void Show()
    {
        Console.WriteLine("Abstract showing");
    }
}
class Dog:Animal
{
    public override void Sound()
    {
        Console.WriteLine("bhau bhau....");
    }
    public void eat()
    {
        Console.WriteLine("dog eating");
    }
    public void Display()
    {
        Console.WriteLine("Dog Show");
    }
}

class Cow:Animal
{
    public override void Sound()
    {
        Console.WriteLine("hmmmmm");
    }
    public void eat()
    {
        Console.WriteLine("Cow eating");
    }
    public void Display()
    {
        Console.WriteLine("Cow Show");
    }
}