using Chat.Domain.Status;
using Microsoft.AspNetCore.Mvc;

namespace Chat.Controllers;

[ApiController]
[Route("system")]
public class SystemController : ControllerBase
{
    private readonly ILogger<SystemController> _logger;

    public SystemController(ILogger<SystemController> l)
    {
        _logger = l;
    }

    [HttpGet("status")]
    public ActionResult Status()
    {
        return Ok(StatusModel.OkStatus().ToEntity());
    }
}
