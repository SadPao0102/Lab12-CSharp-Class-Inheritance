DerivedClass dc = new DerivedClass();
dc.PrintBaseHello();

class BaseClass
{
    public string Hello = "Hello From BaseClass"; // ตัวแปรใน BaseClass
}

class DerivedClass : BaseClass
{
    new public string Hello = "Hello From DerivedClass"; // ตัวแปรใน DerivedClass ที่ซ่อนตัวแปรใน BaseClass

    public void PrintBaseHello()
    {
        string BaseHello = base.Hello; // ใช้งานสมาชิกใน BaseClass โดยคีย์เวิร์ด base
        System.Console.WriteLine(BaseHello); // แสดงค่าจาก BaseClass
    }
}

