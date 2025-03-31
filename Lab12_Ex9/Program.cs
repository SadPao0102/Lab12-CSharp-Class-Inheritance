DerivedClass dc = new DerivedClass();
dc.Greeting();

class BaseClass
{
    public string Hello = "Hello From BaseClass";
    public void Greeting()
    {
        Console.WriteLine("This is method in BaseClass");
        Console.WriteLine(Hello);
    }
}

class DerivedClass : BaseClass
{
    public string Hello = "Hello From DerivedClass";
    public new void Greeting()  // ใช้ new เพื่อบอกว่าเป็น Method Hiding
    {
        Console.WriteLine("This is method in DerivedClass");
        Console.WriteLine(Hello);
    }
}

