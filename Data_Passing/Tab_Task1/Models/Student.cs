using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tab_Task1.Models
{
    public class Student
    {
        public string Name;
        public string Id;
        public Student(string name, string id)
        {
            Name= name;
            Id = id;  
        }
    }
}