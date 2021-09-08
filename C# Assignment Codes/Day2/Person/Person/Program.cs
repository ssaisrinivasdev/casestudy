using System;

namespace Person
{
    class Personn
    {
        public string name, dob, address, martialStatus;

        public Personn(string name, string dob, string address, string martialStatus)
        {
            this.name = name;
            this.dob = dob;
            this.address = address;
            this.martialStatus = martialStatus;
        }
        public string Name { set { this.name = value; } get { return name; } }
        public string Dob { set { this.dob = value; } get { return dob; } }
        public string Address { set { this.address = value; } get { return address; } }
        public string MartialStatus { set { this.martialStatus = value; } get { return martialStatus; } }
        public int GetAge()
        {
            string iDate = dob;
            DateTime oDate = Convert.ToDateTime(iDate);
            int age = 0;
            age = DateTime.Now.Subtract(oDate).Days;
            age = age / 365;
            return age;
        }
        public bool CanMarry()
        {
            if (GetAge() > 18 && martialStatus.Equals("single"))
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            string canmarry = "";
            if (CanMarry())
            {
                canmarry = "can marry";
            }
            else
            {
                canmarry = martialStatus;
            }
            return $"{name} lives at {address}, born on {dob}, {martialStatus}, {GetAge()} years old and {canmarry}";
        }
    }   
    class Program
    {
        static void Main(string[] args)
        {
            Personn p = new Personn("Sai Srinivas","12/18/1999","add","not single");
            Console.WriteLine(p.GetAge());
            Console.WriteLine(p.ToString());
        }
    }
}
