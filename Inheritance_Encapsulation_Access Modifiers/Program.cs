using Domain1;
using Inheritance_Encapsulation_Access_Modifiers.Data;
using Inheritance_Encapsulation_Access_Modifiers.Models;
using System;
using System.Reflection;

namespace Inheritance_Encapsulation_Access_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {

            //Person person1 = new Person();
            //person1.age = 44;
            //Console.WriteLine(person1.age);
            //Employee employee1 = new Employee();
            //employee1.age = person1.age;
            //Console.WriteLine(employee1.age);
            //
            //employee1.name = "Natiq";
            //employee1.surname = "Huseynov";
            //Console.WriteLine($"{employee1.name} {employee1.surname} {employee1.age}");
            //Employee employee1 = new Employee("050-87812-18");
            //Dog dog1 = new Dog("Max");
            //Console.WriteLine(dog1.name);
            //Dog dog2 = new Dog("Rio");
            //Console.WriteLine(dog2.name);
            //Test test1 = new Test("weqeqwewq");
            //Person person1 = new Person();
            ////person1.ShowSurname();
            // show private fields with reflection
            //typeof(Person).GetField("surname", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(person1, "xxxxx");
            //var showSurname = typeof(Person).GetField("surname", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(person1);
            //Console.WriteLine(showSurname);

            //Person person1 = new Person();
            //person1.Age = 22;
            //person1.Age = 88;
            //Console.WriteLine(person1.Age);

            //Car car1 = new Car();
            //Test test1 = new Test();
            Group group1 = new Group();

        }
    }
}
