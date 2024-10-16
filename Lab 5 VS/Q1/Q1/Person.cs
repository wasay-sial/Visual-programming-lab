using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    protected string name;

    public Person()
    {
        name = null;
    }
}

public class Student : Person
{
    private string id;
    private int age;
    private string department;

    public Student()
    {
        age = 0;
        id = null;
        id = null;
    }

    public Student(string id, int age, string department,string name)
    {
        this.id = id;
        this.age = age;
        this.department = department;
        this.name = name;
    }

    public void setName(string n)
    {
        name = n;
    }
    public string getName()
    {
        return name;
    }

    public void setAge(int a)
    {
        age = a;
    }

    int getAge()
    {
        return age;
    }

    public void setDept(string dep)
    {
        department= dep;
    }

    string getDept()
    {
        return department;
    }

    public void display()
    {
        Console.WriteLine("Name is: " + name);
        Console.WriteLine("Age is: " + age);
        Console.WriteLine("ID is: " + id);
        Console.WriteLine("Department is: " + department);
    }

}
