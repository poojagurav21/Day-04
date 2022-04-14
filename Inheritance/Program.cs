//WXP1 wxp1 = new WXP1();
//wxp1.Display();
//wxp1.Access();

//WXP2 wxp2=new WXP2();
//wxp2.Display();
//wxp2.Access();
//wxp2.Camera();


//WXP1 wxp3 = new WXP2();
//wxp3.Display();
//wxp3.Access();

//class WXP1
//{
//    public void Display()
//    {
//        Console.WriteLine("XP display");
//    }
//    public void Access()
//    {
//        Console.WriteLine(" XP Access");
//    }
//}


//class WXP2: WXP1
//{
//    public void Camera()
//    {
//        Console.WriteLine("XP camera");
//    }
//}


//C c1 = new C();
//c1.CShow();
//c1.BShow();

//B a = new B();
//a.BShow();



//class A
//{
//    protected void AShow()
//    {
//        Console.WriteLine("Ashow");
//    }
//}

//class B : A
//{
//    public void BShow()
//    {
//        Console.WriteLine("Bshow");
//        AShow();
//    }
//}
//class C : B
//{
//    public void CShow()
//    {
//        Console.WriteLine("CShow");
//        AShow();
//    }
//}


Address add = new Address("nagar", "Anagar");
Student s1=new Student("Pooja",add);

Student s2 = new Student("Bhagyshree", add);

Address add1 = new Address("kedgaon", "Angar");

Student s3 = new Student("Shweta", add1);


s1.Display();
s2.Display();
s3.Display();

class Address
{
    public string City;
    public string Dist;

    public Address(string city, string dist)
    {
        City = city;
        Dist = dist;
    }

}
class Student
{
    string name;
    public Address address;
    public Student(string name,Address add)
    {
        this.name = name; 
        this.address = add;
    }
    public void Display()
    {
        Console.WriteLine($"{name}  ,  {address.City}   ,   {address.Dist}");
    }
}





















