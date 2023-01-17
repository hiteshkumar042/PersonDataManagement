using System;
using System.Collections.Generic;

namespace PersonDataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Person Data Management..!");
            List<Person> listOfPerson = new List<Person>();
            //UC1 - Creating Person Class and Adding Data
            AddingPersonDetails(listOfPerson);
            //UC2 - 
            PersonDataManagement.RetrieveTop2Below60(listOfPerson);
            //UC3
            PersonDataManagement.AgeBetween13to18(listOfPerson);
            //UC4
            PersonDataManagement.AverageAge(listOfPerson);
            //UC5
            PersonDataManagement.NameCheck(listOfPerson, "Hitesh");
            Console.ReadLine();
        }
        public static void AddingPersonDetails(List<Person> list)
        {
            list.Add(new Person() { SSN = 1, Name = "Hitesh", Address = "Bangalore", Age = 25 });
            list.Add(new Person() { SSN = 2, Name = "Dheeraj", Address = "Hosur", Age = 12 });
            list.Add(new Person() { SSN = 3, Name = "Vishnu", Address = "Vellore", Age = 14 });
            list.Add(new Person() { SSN = 4, Name = "Vikram", Address = "Mumbai", Age = 30 });
            list.Add(new Person() { SSN = 5, Name = "Naresh", Address = "Vasai", Age = 56 });
            list.Add(new Person() { SSN = 6, Name = "Manish", Address = "Jodhpur", Age = 70 });
            list.Add(new Person() { SSN = 7, Name = "Praveen", Address = "Jaipur", Age = 63 });
            DisplayPersonDetails(list);
        }

        public static void DisplayPersonDetails(IEnumerable<Person> list)
        {
            foreach (Person person in list)
            {
                Console.WriteLine(person);
            }
        }
    }
}
