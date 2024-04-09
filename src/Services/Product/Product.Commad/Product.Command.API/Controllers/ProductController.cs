using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product.Command.API.Controllers.Common;
using Product.Command.Application.Command;

namespace Product.Command.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : BaseApiController
{
    [HttpPost("add")]
    public async Task<IActionResult> Add(AddProductCommand command)
    {
        return await _mediatr.Send(command);
    }


}
