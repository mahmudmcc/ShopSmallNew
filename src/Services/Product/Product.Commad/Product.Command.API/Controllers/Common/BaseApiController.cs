using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Product.Command.API.Controllers.Common;

[Route("api/[controller]")]
[ApiController]
public class BaseApiController : ControllerBase
{
    private IMediator _mediator;
    protected IMediator _mediatr => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
}
