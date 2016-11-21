using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SaveLinks.Services.PersonService;

namespace SaveLinks.Controllers
{
    /*
     * Controllere trebuie sa fie simple. Maxim 5 randuri per Actiune
     * Toata logica trebuie sa stea in Service.
     * Se pot injecta oricate service-uri e nevoie pentru a alcatui modelul final.
     * 1 controller: Mai multe Serviceuir
     * 1 Service: Mai multe repository-uri
     * In general serviceuri nu ar trebui sa aibe nevoie de un alt service (la fel si repository)
     */

    //only logged users
    [Authorize]
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        // GET: Person
        public ActionResult Index()
        {
            var pers = _personService.GetFakePersons();
            return View(pers);
        }
    }
}