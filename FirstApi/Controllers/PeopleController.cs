using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FirstApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        [HttpGet("get-all-users")]
      public async Task<IActionResult> GetAllUsers()
        {
            List<string> people = new List<string>()
            {
                "Riko","Arif","Arifali"
            };
            return Ok(people);
        }
        [HttpPost("create-person")]
        public async Task<IActionResult> CreatePerson(Person person)
        {
            return Ok("new person added");
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public string  Surname { get; set; }
        public int Age { get; set; }
        public string Nickname { get; set; }
    }
}
