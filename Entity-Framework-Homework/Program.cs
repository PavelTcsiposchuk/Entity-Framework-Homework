using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext context = new ApplicationContext())
            {

                
                var bands = context.Bands.ToList<Band>();
                var members = context.Musicians.ToList<Musician>();
                //Console.WriteLine(bands.Count<Band>());
                foreach (var band in bands)
                {
                    Console.WriteLine(band.ToString());
                    //if (band.Members == null)
                    //    Console.WriteLine("null");
                    //else Console.WriteLine(band.Members.Count());

                }
                    
                
                    
                
            }
            Console.Read();

        }
    }
}
