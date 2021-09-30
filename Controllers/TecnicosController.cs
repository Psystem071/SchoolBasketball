using Microsoft.AspNetCore.Mvc

namespace SchoolBasketball_WebAPI.controller
{
  [ApiController]
    [Route("[api/controller]")]
  public class TecnicosController : ControllerBase

    [HttpGet]

    public IActionResult Get()
  {
      return ok('Tecnico')

  }

}
