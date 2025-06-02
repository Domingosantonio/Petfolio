using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.Features.Pets.Commands;
using Petfolio.Application.Features.Pets.Queries;
using Petfolio.Comunication.Requests;

namespace Petfolio.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(RequestPetJson),StatusCodes.Status201Created)]
    public IActionResult Register([FromBody] RequestPetJson request)
    {
        var response=new RegisterPetCommand().Execute(request);
        return Created(string.Empty,response);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult Update(RequestPetJson request) {

        new UpdatePetCommand().Execute(request);
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Delete([FromRoute] int id)
    {
        new DeleteByIdPetCommand().Execute(id);
        return Ok();
    }

    [HttpGet]
    public IActionResult GetById([FromRoute] int id) { 
        
        var response = new GetByIdPetQuery().Execute(id);
        return Ok(response);
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var response = new GetAllPetQuery().Execute();
        return Ok(response);
    }
}
