using System;

public class Lab05_Q1
{
    static void Main()
    {
        Student student = new Student("233511",20,"BSCS","Abdul wasay sial");
        student.display();

        Console.WriteLine();
        student.setName("Faseeh");
        student.display();
    }
}
