using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApi1.Models
{
    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string JobTitle { get; }

        public Person(string First, string Last, string Job) {
            FirstName = First;
            LastName = Last;
            JobTitle = Job;
        }

        public Person()
        {

        }
    }
}