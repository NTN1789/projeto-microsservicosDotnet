using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project_estudo.src.Models;

namespace project_estudo.src.Controller
{
    [Route("api/[users]")]
    [ApiController]
    public class UsersController : ControllerBase
    {



        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult Post([FromBody] CreateUserModel createUserModel)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1 }, createUserModel);
        }

        [HttpPut("{id}/login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login ( int id , [FromBody] LoginModel login )
        {


            return NoContent();
         /*   var loginUserviewModel = await _mediator.Send(command);

            if (loginUserviewModel == null)
            {
                return BadRequest();
            }

         return Ok(loginUserviewModel);*/


        }
    }
}
