
Account a = new Account(1234,"Pooja Gurav",10000,"saving");
a.Display();
a.Name = "Pooja G.";
Console.WriteLine(a.AccNo);
a.Bal = 15000;
a.TypeOfaccount = "Salary";
a.Display();





class Account
{
    private int _accNo;
    private String _name;
    private int _bal;
    private string _typeOfAccount;


    public Account(int accno, string name,int bal, string typeofaccount)
    {
        this._accNo = accno;
        this._name = name;   
        this._bal = bal;
        this._typeOfAccount = typeofaccount;
    }
    public int AccNo
    {
        get
        {
            return this._accNo;
        }
    }

    public string Name
    {
        get
        {
            return this._name;
        }
        set
        {
            this._name = value;
        }
    }

    public int Bal
    {
        get
        {
            return this._bal;
        }
        set
        {
            this._bal = value;
        }
    }

    public string TypeOfaccount
    {
        get
        {
            return this._typeOfAccount;
        }
        set
        {
            this._typeOfAccount = value;
        }
    }

    public void Display()
    {
        Console.WriteLine($" AccountNo: {_accNo}\nName: {_name}\nBalance: {_bal}\nTypeOfAccount: {_typeOfAccount}\n");
    }
}
