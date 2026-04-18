using app.clientesMendoza.common.DTOS;
using app.clientesMendoza.services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace app.clientesMendoza.api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ClienteCorntroller : Controller
    {
        private readonly IClienteService _clienteService;
        
        public ClienteCorntroller(IClienteService clienteService) 
        {
            _clienteService = clienteService;

        }

        [HttpGet]

        public IActionResult GetHolaMundo()
        {
            return Ok("Hola Mundo  --  ClienteController");
        }


        [HttpGet("obtener-todos")]
        public async Task<IActionResult> ObtenerTodos()
        {
            var result = await _clienteService.SeleccionarTodos();

            if (result.Success)
            {
                return Ok(result);
            }

            else
            {
                return StatusCode(500, result);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Obtener(int id)
        {
            var result = await _clienteService.SeleccionarUno(id);

            if (result.Success)
            {
                return Ok(result);
            }

            else
            {
                return BadRequest(result);
            }

        }
        
        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] ClienteDTO clienteDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            var result = await _clienteService.Insertar(clienteDTO);
            
            if (!result.Success)
                
                return StatusCode(500, result);
            
            return Ok(result);
            
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Actualizar(int id, [FromBody] ClienteDTO clienteDTO)
        { 
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _clienteService.Actualizar(id, clienteDTO);

            if (!result.Success)
                return StatusCode(500, result);

            return Ok(result);
        }
        
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            var result = await _clienteService.Eliminar(id);

            if (!result.Success)
                return StatusCode(500, result);

            return Ok(result);
        }
    }
}
