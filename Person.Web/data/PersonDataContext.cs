using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Person.Web.Models;
using person = Person.Web.Models.Person;


namespace Person.Web.data
{
    public  class PersonDataContext
    {
        private static List<person> instance;

        public  List<person> PersonList
        {
            get
            {
                if (instance == null)
                {
                    instance = InitPeople();
                }
                return instance;
            }
        }

        private static List<person> InitPeople()
        {
            List<person> people = new List<person>();

            Random rnd = new Random();

            for (int i = 0; i < 10000; i++)
            {
                var p = new person()
                {
                    Name = "Person #" + i.ToString(),
                    Age = rnd.Next(1, 99),
                };

                var race = rnd.Next(1, 5);
                switch (race)
                {
                    case 1: p = new Angles { Name = p.Name, Age = p.Age };
                        break;
                    case 2: p = new Saxons{ Name = p.Name, Age = p.Age };
                        break;
                    case 3: p = new Jutes{ Name = p.Name, Age = p.Age };
                        break;
                    case 4: p = new Asians{ Name = p.Name, Age = p.Age };
                        break;
                }
                people.Add(p);
            }
            return people;
        }

        public void IncreaseAge(int i)
        {
            instance.All(x => { x.Age = x.Age + i; return true; });
        }
    }
}