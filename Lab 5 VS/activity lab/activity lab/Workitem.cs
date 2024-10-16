using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Workitem
    {
        private int id;
        private string name;
        private int age;

        public Workitem()
        {
            age = 0;
            id = 0;
            name = "no name";
        }

        public Workitem(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        /*public int setgetname()
        {
            set
            {
                
            }
        }*/


        public void display()
        {
            Console.WriteLine("age is " + age);
            Console.WriteLine("name is " + name);
            Console.WriteLine("ID is " + id);
        }

    }

