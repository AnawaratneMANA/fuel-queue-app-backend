using Microsoft.AspNetCore.Mvc;
using MongoDBTestProject.Model;
using MongoDBTestProject.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MongoDBTestProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            return userService.GetStudents();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(String id)
        {
            var user = userService.Get(id);
            if (user == null)
            {
                return NotFound($"Student with Id = {id} not found");
            }

            return user;
        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult<User> Post([FromBody] User user)
        {
            userService.Create(user);
            return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public ActionResult Put(String id, [FromBody] User user)
        {
            var existingUse = userService.Get(id);

            if (existingUse == null)
            {
                return NotFound($"Student with Id = {id} not found");
            }

            userService.Update(id, user);

            return NoContent();
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(String id)
        {
            var user = userService.Get(id);

            if (user == null)
            {
                return NotFound($"Student with Id = {id} not found");
            }

            userService.Remove(user.Id);

            return Ok($"Student with Id = {id} deleted");
        }
    }
}
