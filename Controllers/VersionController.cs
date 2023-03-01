using Microsoft.AspNetCore.Mvc;
using dotnet_webapi_info_version.Helpers;

namespace dotnet_webapi_info_version.Controllers;

[ApiController]
[Route("[controller]")]
public class VersionController : ControllerBase
{
    [HttpGet(Name = "GetVersion")]
    public IActionResult Get()
    {
        return Ok(new {
            StatusCode = 1
            , Version = OurUtility.VERSION
        });
    }
}
