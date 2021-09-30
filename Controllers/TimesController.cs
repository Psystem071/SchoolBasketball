using Microsoft.AspNetCore.Mvc

namespace SchoolBasketball_WebAPI.controller
{
  [ApiController]
    [Route("[api/controller]")]
  public class TimesController : ControllerBase
  {
  [HttpGet]

    public IActionResult Get()
  {
      return ('Times');

  }


  }
}
