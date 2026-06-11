namespace 期末考第二題
{
    public class Employee
    {
        public string Name { get; set; }
        public int IdNumber { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }

        public Employee()
        {
            Name = "";
            IdNumber = 0;
            Department = "";
            Position = "";
        }

        public Employee(string name, int idNumber)
        {
            Name = name;
            IdNumber = idNumber;
            Department = "";
            Position = "";
        }

        public Employee(string name, int idNumber, string department, string position)
        {
            Name = name;
            IdNumber = idNumber;
            Department = department;
            Position = position;
        }
    }
}