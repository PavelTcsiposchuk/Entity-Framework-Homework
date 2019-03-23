using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Homework
{
    public class Band
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public virtual ICollection<Musician> Members { get; set; }
        public Band()
        {
            Members = new List<Musician>();
        }
        public override string ToString()
        {
            string result = "=======================================\n";
            result = result + "Name of Band:" + Name + " " + (Genre != null ? ("Genre:" + Genre) : "");
            if (Members != null)
            {
                result = result + "\nMembers:";
                foreach (var member in Members)
                {
                    result += member.ToString();
                }

            }
            return result;
               
        }

    }
}
