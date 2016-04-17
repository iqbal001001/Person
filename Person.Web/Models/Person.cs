using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Person.Web.Models
{

    public interface IHeight
    {
        double Height { get; }
    }

    public interface IRace
    {
        string Race { get; }
    }

    public class Person 
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {

            return "My name is '" + Name + "' and I am " + Age + " years old.";

        }
    }

    public class Angles : Person, IRace, IHeight
    {
        public string Race { get { return "Angles"; } }

        public double Height
        {
            get
            {
                return (1.5 + (Age * 0.45));
            }
        }
    }

    public class Saxons : Person, IRace, IHeight
    {
        public string Race { get { return "Saxons"; } }

        public double Height
        {
            get
            {
                return (1.5 + (Age * 0.45));
            }
        }

    }

    public class Jutes : Person, IRace, IHeight
    {
        public string Race { get { return "Jutes"; } }

        public double Height
        {
            get
            {
                return ((Age * 1.6) / 2);
            }
        }
    }

    public class Asians : Person, IRace, IHeight
    {
        public string Race { get { return "Asians"; } }

        public double Height
        {
            get
            {
                return  (1.7 + ((Age + 2) * 0.23));
            }
        }
    }

    

    
}