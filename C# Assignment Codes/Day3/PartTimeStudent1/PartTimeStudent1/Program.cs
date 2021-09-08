using System;

namespace PartTimeStudent1
{
    interface IStudent
    {
        string LibCardNumber { get; set; }
        int Year { get; set; }
        void Register();
        void PostCourseWork(string work);
    }
    class Employee
    {
        public int employeeId;
        public string employeeName;
        public Employee() { }
        public Employee(int id, string name)
        {
            employeeId = id;
            employeeName = name;
        }

    }
    class PartTimeStudent : Employee,IStudent
    {
        public string libCardNumber="3112PW";
        public int year=3;
        public string LibCardNumber
        {
            get { return this.libCardNumber; }
            set { this.libCardNumber = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public void PostCourseWork(string work)
        {
            Console.WriteLine($"{work}");
        }

        public void Register()
        {
            Console.WriteLine($"{employeeName} is Registered, Your Library card has generated {libCardNumber}");
        }
    }
    
    class AddEmployee
    {
        static void Main(string[] args)
        {
            PartTimeStudent emp1 = new PartTimeStudent();
            emp1.Register();
            emp1.PostCourseWork("");
        }
    }
}
