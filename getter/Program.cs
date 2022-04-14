
Student s=new Student();
s.Name = "pooja";   //set
Console.WriteLine(s.Name);  //get


class Student
{
    private int id;
    private string name;

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }

    public int Id
    {
        get
        {
            return this.id;
        }
    }
}