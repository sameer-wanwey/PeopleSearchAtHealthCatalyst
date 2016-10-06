using PeopleSearchAtHealthCatalyst.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace PeopleSearchAtHealthCatalyst.Controllers
{
    public class DataServiceController : Controller
    {
        IPersonRepository _PersonRepository;

        public DataServiceController(IPersonRepository personRepo)
        {
            _PersonRepository = personRepo;
        }

        [HttpPost]
        public ActionResult GetPeople()
        {
            return Json(_PersonRepository.GetPeople());
        }
        [HttpPost]
        public ActionResult SearchPerson(string name)
        {
            return Json(_PersonRepository.SearchPerson(name));
        }

        [HttpPost]
        public ActionResult DelayInSearchPerson(string name)
        {
            Thread.Sleep(2000);
            return SearchPerson(name);
        }

        
    }
}