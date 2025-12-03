using DavidTielke.PMA.CrossCutting.DataClasses;
using Microsoft.AspNetCore.Mvc;
using PersonManagement;

namespace ServiceClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly PersonManager _personManager;

        public PersonController()
        {
            _personManager = new PersonManager();
        }

        [HttpGet]
        [Route("/Persons/Adults")]
        public IEnumerable<Person> GetAdults()
        {
            return _personManager.GetAllAdults();
        }
        [HttpGet]
        [Route("/Persons/Children")]
        public IEnumerable<Person> GetChildren()
        {
            return _personManager.GetAllChildren();
        }
    }
}
