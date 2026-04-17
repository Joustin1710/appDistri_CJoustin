using Microsoft.AspNetCore.Mvc;

namespace app.clientesMendoza.api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ClienteCorntroller : Controller
    {
        public ClienteCorntroller() {
        
        }

        [HttpGet]

        public IActionResult GetHolaMundo()
        {
            return Ok("Hola Mundo  --  ClienteController");
        }
    }
}
