using MediatR;
using Microsoft.AspNetCore.Mvc;
using SaveProductCommand = Commands.Application.Commands.SaveProduct.Command;
using DeleteProductCommand = Commands.Application.Commands.DeleteProduct.Command;

namespace TrueCode.API.Controllers;

[Route("[controller]/[action]")]
[ApiController]
public class ProductController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> SaveProduct([FromBody] SaveProductCommand command)
    {
        var id = await mediator.Send(command);

        return Ok(id);
    }

    [HttpPost]
    public async Task<IActionResult> DeleteProduct([FromBody] DeleteProductCommand command)
    {
        await mediator.Send(command);

        return Ok();
    }
}