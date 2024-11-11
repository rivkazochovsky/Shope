using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Service;
using Entites;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shope.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
{
       Iserviceuser service ;
     public UserController(Iserviceuser _serviceuser)
        {
            service = _serviceuser;
        }
        //        string filePath = "M:\\Api\\Shope\\Shope\\TextFile.txt";

        //GET: api/<UserController>
            [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //        // GET api/<UserController>/5
        //        [HttpGet("{id}")]
        //        public string Get(int id)
        //        {
        //            using (StreamReader reader = System.IO.File.OpenText(filePath))
        //            {
        //                string? currentUserInFile;
        //                while ((currentUserInFile = reader.ReadLine()) != null)
        //                {
        //                    User user = JsonSerializer.Deserialize<User>(currentUserInFile);
        //                    if (user.UserId == id)
        //                        return "USER TO CLIENT";
        //                }
        //            }
        //            return "not user found";

        //        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult<User> Post([FromBody] User user)
        {
            User newUser = service.Adduser(user);
            return CreatedAtAction(nameof(Get), new { id = user.UserId }, newUser);

        }

        [HttpPost]
        [Route("password")]
        public int Postcheck([FromQuery] string password)
        {
            
            return service.checkpassword(password);

        }

        [HttpPost("login")]
        public ActionResult<User> Post([FromQuery] string UserName,string Password)
        {
            User user = service.login(UserName, Password);
            if (user != null)
                return Ok(user);
            return NoContent();
        }
        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User value)
        {
            service.updateUser(id, value);

        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
