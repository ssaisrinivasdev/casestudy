using System;

namespace PartTimeStudent_2
{
    
    interface IStudent
    {
        string LibCardNumber { get; set; }
        int Year { get; set; }
    }
    public class Employee
    {
        public int employeeId;
        public string employeeName;
        public Employee(){ }
        public Employee(int employeeId, string employeeName)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
        }

        public int EmployeeId { set; get; }
        public string EmployeeName { set; get; }
    }
    public class PartTimeStudent : Employee, IStudent
    {
            
        public string libCardNumber;
        public int year;
        public string work;

        public PartTimeStudent(){ }

        public PartTimeStudent(int employeeId,string libCardNumber,int year,string work) {
            this.employeeId = employeeId;
            this.libCardNumber = libCardNumber;
            this.year = year;
            this.work = work;
        }

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
            throw new NotImplementedException();
        }

        public string Register()
        {
            return $"{this.employeeId} is registerd with {this.libCardNumber}";
        }
    }
    class AddEmployee
    {
        static void Main(string[] args)
        {
            PartTimeStudent emp1 = new PartTimeStudent(1234,"Sai Srinivas",12,"work");
            emp1.LibCardNumber ="3215ad";
            Console.WriteLine(emp1.Register());
        }
    }
    
}
