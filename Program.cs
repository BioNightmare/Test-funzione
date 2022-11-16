using System;
using System.Collections.Generic;

namespace Test_funzione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            Person francesco = new("Francesco","Rossi",28);
            Person giacomo = new("Andrea","Bianchi",19);
            people.Add(francesco);
            people.Add(giacomo);
            GetInfo();
            void GetInfo()
            {
                foreach (Person person in people)
                {
                    Console.WriteLine($"Nome: {person.Name}, Cognome: {person.LastName}, Età: {person.Age}");
                }
            }
            
        }
    }
    public class Person
    {
        public string Name;
        public string LastName;
        public int Age;

        public Person(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }
    }




    //in ingresso accetta n oggetti
    //scrive su file per ogni oggetto le sue proprietà
    //es. oggetto di tipo persona, deve scrivere per ogni persona nome cognome e data di nascita

}
