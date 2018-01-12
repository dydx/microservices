using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
  [Route("/")]
    public class IndexController : Controller
  {
    // GET /
    [HttpGet]
    public string Get()
    {
      return ".NET microservice";
    }
  }
}
