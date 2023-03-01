using Microsoft.AspNetCore.Mvc;
using dotnet_webapi_info_version.Helpers;

namespace dotnet_webapi_info_version.Controllers;

[ApiController]
[Route("[controller]")]
public class InfoController : ControllerBase
{
    [HttpGet(Name = "GetInfo")]
    public IActionResult Get()
    {
        return Ok(new {
            StatusCode = 1
            , Message = $"Application: {OurUtility.APPLICATION}, Version: {OurUtility.VERSION}"
            , Remark = "user Swagger for more details about APIs"
        });
    }
}
