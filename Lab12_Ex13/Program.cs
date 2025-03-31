DerivedClass DC = new DerivedClass();
System.Console.WriteLine($"DC.Field1 = {DC.Field1}"); // แสดง Field1 ของ DerivedClass

BaseClass BC = (BaseClass)DC; // แปลง DC เป็น BaseClass
System.Console.WriteLine($"BC.Field1 = {BC.Field1}"); // แสดง Field1 ของ BaseClass

class BaseClass
{
    public string Field1 = "Field1 of BaseClass"; // ตัวแปรใน BaseClass
}

class DerivedClass : BaseClass
{
    new public string Field1 = "Field1 of DerivedClass"; // ตัวแปรใน DerivedClass ที่ซ่อน Field1 ของ BaseClass
}

