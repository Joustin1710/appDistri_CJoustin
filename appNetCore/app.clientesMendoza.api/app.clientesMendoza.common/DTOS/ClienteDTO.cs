using System.ComponentModel.DataAnnotations;

namespace app.clientesMendoza.common.DTOS
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public bool Estado { get; set; }
        
        [Required(ErrorMessage = "El campo Nombre es Obligatorio")]
        public string? Nombre { get; set; }
        
        [Required(ErrorMessage = "El campo Apellido es Obligatorio")]
        public string? Apellido { get; set; }
        
        [Required(ErrorMessage = "El campo Email es Obligatorio")]
        public string? Email { get; set; }
        
        [Required(ErrorMessage = "El campo CedulaIdentidad es Obligatorio")]
        public string? CedulaIdentidad { get; set; }
        
        [Required(ErrorMessage = "El campo FechaNacimiento es Obligatorio")]
        public DateTime? FechaNacimiento { get; set; }

        [Required(ErrorMessage = "El campo Telefono es Obligatorio")]
        public string? Telefono { get; set; }
        
        }
    }
