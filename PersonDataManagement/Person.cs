namespace PersonDataManagement
{
    public class Person
    {
        public int SSN { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"SSN:{SSN}  Name : {Name}  Address : {Address}  Age : {Age}";
        }
    }
}
