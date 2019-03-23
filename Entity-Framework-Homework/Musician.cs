using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Homework
{
    public class Musician
    {
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public string Role { get; set; }
        public Band Band { get; set; }

        public override string ToString()
        {
            return "\nSurname:" + Surname + " " + "Name:" + FirstName + " " + (Age != 0 ? ("Age:" + Age + " ") : "") + (Country != null ? ("Country:" + Country + " ") : "") + (Role != null ? ("Role:" + Role + " ") : "");

        }

    }
}
