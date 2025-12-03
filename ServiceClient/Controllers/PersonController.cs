using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Logic.PersonManagement.Contract;
using Microsoft.AspNetCore.Mvc;

namespace ServiceClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonManager _personManager;
        public PersonController(IPersonManager personManager)
        {
            _personManager = personManager;
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
