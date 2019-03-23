using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Homework
{
    class ApplicationContextInitializater : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext db)
        {
            if (db == null)
                Console.WriteLine("Null");
            
            Band Rammstein = new Band { Name = "Rammstein", Genre = "Industrial", Members = new List<Musician>() };
            Band OstFront = new Band { Name = "OstFront", Members = new List<Musician>() };
            Band BI2 = new Band { Name = "Би-2", Genre = "Rock", Members = new List<Musician>() };
            Musician m1 = new Musician { FirstName = "Till", Surname = "Lindemann", Band = Rammstein, Age = 56, Country = "German", Role = "Vocal" };
            Musician m2 = new Musician { FirstName = "Richard", Surname = "Kruppe", Band = Rammstein, Age = 51, Country = "German", Role = "Guitar" };
            Musician m3 = new Musician { FirstName = "Oliver", Surname = "Riedel", Band = Rammstein, Age = 47, Country = "German", Role = "Guitar" };
            Musician m4 = new Musician { FirstName = "Paul", Surname = "Landers", Band = Rammstein, Age = 54, Country = "German", Role = "Guitar" };

            Musician m5 = new Musician { FirstName = "Patrik", Surname = "Lange", Band = OstFront, Role = "Vocal" };
            Musician m6 = new Musician { FirstName = "Vilgelm", Surname = "Routfall", Band = OstFront };

            Musician m7 = new Musician { FirstName = "Егор", Surname = "Бортник", Band = BI2, Country = "Беларусь", Role = "Vocal" };
            Musician m8 = new Musician { FirstName = "Александр", Surname = "Уман", Band = BI2, Country = "Беларусь" };

            Rammstein.Members.Add(m1);
            Rammstein.Members.Add(m2);
            Rammstein.Members.Add(m3);
            Rammstein.Members.Add(m4);

            OstFront.Members.Add(m5);
            OstFront.Members.Add(m6);

            BI2.Members.Add(m7);
            BI2.Members.Add(m8);

            AddBandsToDatabase(db, Rammstein, OstFront, BI2);

            AddMusicansToDatabase(db, m1, m2, m3, m4, m5, m6, m7, m8);
            //Console.WriteLine("Я в инициализаторе");

            db.SaveChanges();

            //var bands = db.Bands;
            ////var members = context.Musicians;
            ////Console.WriteLine(bands.Count<Band>());
            //foreach (var band in bands)
            //{
            //    Console.WriteLine(band.ToString());
            //    if (band.Members == null)
            //        Console.WriteLine("null");
            //    else Console.WriteLine(band.Members.Count());

            //}

        }

        private void AddMusicansToDatabase(ApplicationContext db,params Musician [] musician)
        {
            foreach(var st in musician)
            {
                db.Musicians.Add(st);

                
            }
        }

        private void AddBandsToDatabase(ApplicationContext db, params Band [] bands)
        {
            foreach (var st in bands)
            {
                db.Bands.Add(st);
                //if (st.Members == null)
                //    Console.WriteLine("null");
                //else Console.WriteLine(st.Members.Count());
            }
        }

    }
}
