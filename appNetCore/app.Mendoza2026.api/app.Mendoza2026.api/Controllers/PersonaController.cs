using Microsoft.AspNetCore.Mvc;

namespace app.Mendoza2026.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonaController : ControllerBase
    {
        //Lista que simula una base de datos 
        private static List<Persona> personas = new List<Persona>()
        {
            new Persona { Id = 1, Nombre = "Juan", Edad = 30, Fecha = DateTime.Now, Activo = true },
            new Persona { Id = 2, Nombre = "María", Edad = 25, Fecha = DateTime.Now,Activo = false },
            new Persona { Id = 3, Nombre = "Pedro", Edad = 40, Fecha = DateTime.Now,Activo = true }
        };


        [HttpGet]
        public IActionResult GetPersonas()
        {
            try
            {

                return Ok(personas);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpGet("{idPersona}")]
        public IActionResult GetPersona(int idPersona)
        {
            try
            {
                var persona = personas.FirstOrDefault(p => p.Id == idPersona);

                if (persona == null) {

                    return BadRequest("Persona no Encontrada");
                }

                return Ok(persona);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Persona persona)
        {
            try
            {
                if (persona == null) {
                    return BadRequest("Persona es requerida");
                }

                persona.Id = personas.Max(p => p.Id) + 1;
                persona.Fecha = DateTime.Now;

                personas.Add(persona);

                return Ok(personas);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpPut("{id}")]
        public IActionResult PutActualizar(int id, [FromBody] Persona persona)
        {
            try
            {
                var personaExiste = personas.FirstOrDefault(p => p.Id == id);

                if (personaExiste == null)
                {

                    return BadRequest("Persona no Encontrada");
                }

                personaExiste.Nombre = persona.Nombre;
                personaExiste.Edad = persona.Edad;
                personaExiste.Activo = persona.Activo;

                return Ok(personaExiste);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpDelete("{id}")]
        public IActionResult DeletePersona(int id)
        {
            try
            {
                var persona = personas.FirstOrDefault(p => p.Id == id);

                if (persona == null)
                {
                    return BadRequest("Persona no Encontrada");
                }

                personas.Remove(persona);
            
                return Ok("Persona Elimina Correctamente");

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}