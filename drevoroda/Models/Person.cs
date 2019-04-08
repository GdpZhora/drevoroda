using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace drevoroda.Models
{
    public class Person
    {
        public int Id { get; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set;  }
        public Person Father { get; set; }
        public Person Mother { get; set; }
    }
}
