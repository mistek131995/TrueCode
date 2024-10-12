using MediatR;
using Microsoft.AspNetCore.Mvc;
using SaveProductCommand = Commands.Application.Commands.SaveProduct.Command;
using DeleteProductCommand = Commands.Application.Commands.DeleteProduct.Command;
using GetProductListQuery = Queries.Application.Queries.ProductList.Query;
using GetProductQuery = Queries.Application.Queries.Product.Query;

namespace TrueCode.API.Controllers;

[Route("[controller]/[action]")]
[ApiController]
public class ProductController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> SaveProduct([FromForm] SaveProductCommand command)
    {
        var file = HttpContext.Request.Form.Files.FirstOrDefault();

        if (file != null)
        {
            using var memoryStream = new MemoryStream();
            await file.CopyToAsync(memoryStream);
            
            command.ImageName = file.FileName;
            command.Image = memoryStream.ToArray();
        }

        var id = await mediator.Send(command);

        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> DeleteProduct([FromBody] DeleteProductCommand command)
    {
        await mediator.Send(command);

        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetProductList([FromQuery] GetProductListQuery query) => 
        Ok(await mediator.Send(query));

    [HttpGet]
    public async Task<IActionResult> GetProduct([FromQuery] GetProductQuery query) =>
        Ok(await mediator.Send(query));
}