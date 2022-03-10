using System;
using practice.Model;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region anonimus class
            //var telebe1 = new
            //{
            //    name = "Sebine",
            //    surname = "Novruzova",
            //    age = 21
            //};
            //var telebe2 = new
            //{
            //    name = "Heyat",
            //    surname = "Abdullayeva",
            //    age = 20
            //};
            #endregion
            #region class
            //Student telebe1 = new Student();
            //telebe1.name = "Sebine";
            //telebe1.surname = "Novruzova";
            //telebe1.FullName();
            //Student telebe2 = new Student();
            //telebe2.name = "Nezrin";
            //telebe2.surname = "Zeynalova";
            //telebe2.age = 19;
            //telebe2.GetInfo();
            Student stu1 = new Student("Sebine", "Novruzova", 21);
            Console.WriteLine($"Ad:{stu1.name}, Soyad:{stu1.surname}, Yaş:{stu1.age}");
            Teacher t1 = new Teacher();
        }
            #endregion
        
        
           
        
    }
}



