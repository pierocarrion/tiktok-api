using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using TikTokAPI.Application.Video.Commands;
using TikTokAPI.Extensions;

namespace TikTokAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class VideoController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    [Consumes(MediaTypeNames.Application.Json)]
    [Produces(MediaTypeNames.Application.Json)]
    public async Task<IActionResult> Upload([FromBody] UploadVideoCommand command) => (await mediator.Send(command)).ToActionResult();
}
