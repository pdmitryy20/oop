using System;
using System.Xml.Serialization;

namespace lab7
{
    class University
    {
        public string Name { get; set; }
        public void printUniversityName()
        {
            Console.WriteLine("Назва університету: К-ПНУ");
        }

    }
    class Faculty
    {
        public string Name { get; set; }
        public void printFacultyName()
        {
            Console.WriteLine("Назва факультету: Фізико-математичний факультет");
        }
        public int CountOfTeachers { get; set; }
        public void Teachers(int count)
        {
            CountOfTeachers = count;
        }
        public void printCOF()
        {
            Console.WriteLine("Кількість викладачів: " + CountOfTeachers);
        }
    }
    class Professor
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public void Professorr(string name, string position, decimal salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }
    public void CalculateSalary()
        {
            decimal salary = Salary;
            Console.WriteLine($"Зарплата викладача {Name} за місяць: {Salary} грн");
        }
   }
    class FullTimeProfessor : Professor
    {
        public decimal Bonus { get; set; }
        public FullTimeProfessor(string name, string position, decimal salary)
        {
            Bonus = Bonus;
        }
        public void CalculateSalary()
        {
            decimal salary = Bonus + Salary;
            Console.WriteLine($"Зарплата викладача {Name} за місяць: {salary} грн");
        }
    }   
    internal class Program
    {
        static void Main(string[] args)
        {
            University university = new University();
            university.printUniversityName();
            Faculty faculty = new Faculty();
            faculty.printFacultyName();
            faculty.printCOF();
            Professor professor = new Professor();
            professor.CalculateSalary();

        }
    }
}