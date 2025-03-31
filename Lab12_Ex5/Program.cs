DerivedClass dc = new DerivedClass();

class BaseClass1
{
    public BaseClass1()
    {
        System.Console.WriteLine("This is BaseClass1");
    }
}

class BaseClass2
{
    public BaseClass2()
    {
        System.Console.WriteLine("This is BaseClass2");
    }
}

class DerivedClass : BaseClass1
{
    private BaseClass2 baseClass2; // ใช้ composition เพื่อเข้าถึง BaseClass2

    public DerivedClass()
    {
        baseClass2 = new BaseClass2(); // สร้าง instance ของ BaseClass2
        System.Console.WriteLine("This is DerivedClass");
    }
}
