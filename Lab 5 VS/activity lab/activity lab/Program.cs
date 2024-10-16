using System;
using System.IO;
class activity
{
    static void Main()
    {
        double a = 100, b = 2;
        double result = 0;
         try
         {
            result = safeDiv(a, b);
            Console.WriteLine("the result is: "+ result);
         }
        catch (DivideByZeroException )
         {
             Console.WriteLine("You entered zero.....cannot divide by zero");
         }

        file();
        Workitem obj1 = new Workitem(233511,"wasay",20);
        obj1.display();
        
    }


    static void file()
    {
        StreamWriter sw = null;

        try
        {
            sw = new StreamWriter(@"C:\Users\233511\Desktop\filty.txt");
            sw.WriteLine("hello");
        }

        catch(FileNotFoundException e)
        {
            Console.WriteLine("file not found");
        }
        catch(IOException)
        {
            Console.WriteLine("Input is not found");
        }
        finally
        {
            sw.Close();
        }




    }


    static double safeDiv(double n1, double n2)
    {
        if (n2 == 0)
        {
            throw new System.DivideByZeroException();
        }
        return n1 / n2;
    }
}





