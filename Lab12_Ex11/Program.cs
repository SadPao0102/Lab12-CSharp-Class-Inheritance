DerivedClass dc = new DerivedClass();
System.Console.WriteLine(dc.Hello);

class BaseClass
{
    public string Hello = "Hello From BaseClass"; // ตัวแปรใน BaseClass
}

class DerivedClass : BaseClass
{
    new public string Hello = "Hello From DerivedClass"; // ตัวแปรใน DerivedClass ที่ซ่อนตัวแปรใน BaseClass
}

