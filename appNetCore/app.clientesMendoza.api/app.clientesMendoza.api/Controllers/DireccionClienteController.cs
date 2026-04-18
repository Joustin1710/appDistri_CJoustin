using app.clientesMendoza.common.DTOS;
using app.clientesMendoza.services.Inplementations;
using app.clientesMendoza.services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace app.clientesMendoza.api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class DireccionClienteController : Controller
    {

        private readonly IDireccionClienteService _direccionClienteService;
        public DireccionClienteController(IDireccionClienteService direccionClienteService)
        {
            _direccionClienteService = direccionClienteService;
        }

        [HttpGet("obtener-todos")]
        public async Task<IActionResult> ObtenerTodos()
        {
            var result = await _direccionClienteService.SeleccionarTodos();

            if (result.Success)
                return StatusCode(500, result);
            
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Obtener(int id)
        {
            var result = await _direccionClienteService.SeleccionarUno(id);

            if (result.Success)
                return StatusCode(500, result);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] DireccionClienteDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            var result = await _direccionClienteService.Insertar(dto);

            if (!result.Success)
                return StatusCode(500, result);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Actualizar(int id, [FromBody] DireccionClienteDTO dto)
        {
        
        if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _direccionClienteService.Actualizar(id, dto);

            if (!result.Success)
                return StatusCode(500, result);

            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            var result = await _direccionClienteService.Eliminar(id);

            if (!result.Success)
                return StatusCode(500, result);

            return Ok(result);
        }
    }
}
