using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Person.Web.Models
{
    public class PersonIndexView
    {
        public List<PersonDTO> Persons;

        public List<SelectListItem> Races;

        public string SelectedRace;
    }
}