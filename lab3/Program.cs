using System;

namespace lab3
{
    class Person
    {
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public int Age { get; set; }
        public void setAge(int age)
        {
            Age = age;
            Console.WriteLine(age);
        }
    }
    class Student : Person
    {
        void Study()
        {
            Console.WriteLine("I'm studying");
        }
    public void showAge()
        {
            Console.WriteLine("My age is " + Age + " years old");
        }
    }
    class Professor : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
    internal class Program
    {
       static void Main(string[] args)
        {
            Person person = new Person();
            person.Greet();
            Student student = new Student();
            student.setAge(18);
            student.Greet();
            student.showAge();
            Professor profesr = new Professor();
            Professor professor = new Professor();
            professor.setAge(40);
            professor.Greet();
            profesr.Explain();
        }
    }
}
