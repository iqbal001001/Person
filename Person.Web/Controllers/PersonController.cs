using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Person.Web.data;
using Person.Web.Models;

namespace Person.Web.Controllers
{
    public class PersonController : Controller
    {
        private PersonDataContext _context;

        public PersonController()
        {
            _context = new PersonDataContext();
        }
        // GET: Person
        public ActionResult Index(FormCollection form)
        {
            var selectedRace = form["ddlRace"] == null ? "Angles" : form["ddlRace"].ToString();
            var persons = _context.PersonList
                .Select(p => new PersonDTO
                {
                    Name = p.Name,
                    Age = p.Age,
                    Race = ((IRace)p).Race,
                    Height = ((IHeight)p).Height
                });

            PersonIndexView personIndexDTO = new PersonIndexView
            {
                Persons = persons.Where(p => p.Race == selectedRace).ToList(),
                Races = persons.Select(x => x.Race)
                .Distinct()
                .Select(p => new SelectListItem { Text = p , Value = p, Selected = selectedRace == p}).ToList() ,
                SelectedRace = selectedRace
            };

            return View(personIndexDTO);
        }
    }

  
}
