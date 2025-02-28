using DevFreela.Application.InputModels;
using DevFreela.Application.Services.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project_estudo.src.Models;
namespace project_estudo.src.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {


private readonly IProjectService _projectServices;
        public ProjectsController(IProjectService  projectService)
        {
                _projectServices = projectService;
        }

        // private readonly IMediator _mediator;
        [HttpGet]
        public IActionResult Get(string query )
        {

            var project = _projectServices.GetAll(query);
            return Ok(project);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var project = _projectServices.GetById(id);

            if (project == null)
            {
                return NotFound();
            }

            return Ok();

     /*       var query = new GetProjectByIdQuery(id);

           var project = await _mediator.Send(query);

            if (project == null)
            {
                return NotFound();
            }

            return Ok(project);
*/
        }
            [HttpPost]
            public async Task<IActionResult> PostComment([FromBody] NewProjectInputModel inputModel)
            {
               
                var id = _projectServices.Create(inputModel);

                //padrão mediator vai controlar acesso a outras dependencias
                //   var id = await _mediator.Send(command);
                // 1- Nome da api que vai obter detalhes do que foi cadastrado
                // 2- objeto autonimo que vai ter o parametro para achar o objeto criado
                // 3- objeto cadastrado
               return CreatedAtAction(nameof(GetById), new { id = 1 }, inputModel);

            }


            [HttpPut("{id}")]
            public IActionResult Put(int id , [FromBody] UpdateProjectInputModel updateProject)
            {
                if (updateProject.Description.Length > 2000)
                {
                    return BadRequest();
                }
                
                _projectServices.Update( updateProject);
                return NoContent();
            }

            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                _projectServices.Delete(id);
                return NoContent();
            }

            [HttpPost("{id}/comments")]
            public IActionResult PostComments(int id, [FromBody] CreateCommentInputModel inputModel)
            {
                _projectServices.CreateComment( inputModel);
                return NoContent();
            }

            [HttpPut("{id}/start")]
            public IActionResult Start(int id)
            {
                _projectServices.Start(id);
                return NoContent();
            }

            [HttpPut("{id}/finish")]
            public IActionResult Finish(int id)
            {
                    _projectServices.Finish(id);
                return NoContent();
            }

        }
    }
