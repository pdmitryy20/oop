using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab3_zavd2
{
   class User
    {
        protected string name;
        protected int age;
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public int getAge()
        {
            return age;
        }
    }
    class Worker : User
    {
        private int salary;
        public void setSalary(int salary)
        {
            this.salary = salary;
        }
        public int getSalary()
        {
            return salary;
        }
    }
    class Student : User
    {
        private int scholarship;
        private int course;
        public void setScholarshir(int scholarship)
        {
            this.scholarship = scholarship;
        }
        public int getScholarship()
        {
            return scholarship;
        }
        public void setCourse(int course)
        {
            this.course = course;
        }
        public int getCourse()
        {
            return course;
        }
    }
    class Driver : Worker
    {
        private int drivingExperience;
        private string drivingCategory;
        public void setDrivingExperience(int drivingExperience)
        {
            this.drivingExperience = drivingExperience;
        }
        public int getDrivingExperince()
        {
            return drivingExperience;
        }
        public void setDrivingCategory(string drivingCategory)
        {
            this.drivingCategory = drivingCategory;
        }
        public string getDrivingCategory()
        {
            return drivingCategory;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker Ivan = new Worker();
            Ivan.setName("Іван");
            Ivan.setAge(20);
            Ivan.setSalary(1000);
            Worker Vasya = new Worker();
            Vasya.setName("Вася");
            Vasya.setAge(26);
            Vasya.setSalary(2000);
            int totalSalary = Ivan.getSalary() + Vasya.getSalary();
            Console.WriteLine("Сума зарплат Івана та Васі є " + totalSalary);
        }
    }
}
