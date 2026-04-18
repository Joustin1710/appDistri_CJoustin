using System.ComponentModel.DataAnnotations;

namespace app.clientesMendoza.entities.models
{
    public class EntityBase
    {
        [Key]

        public int Id { get; set; }
        public bool Estado { get; set; }
        public DateTime Fecha { get; set; }
    }

    public class Cliente : EntityBase
    {
        [Required]
        [StringLength(30)]
        public string? Nombre { get; set; }

        [Required]
        [StringLength(30)]
        public string? Apellido { get; set; }

        [Required]
        [StringLength(50)]
        public string? Email { get; set; }

        [Required]
        [StringLength(10)]
        public string? CedulaIdentidad { get; set; }

        [Required]
        public DateTime? FechaNacimiento { get; set; }

        [StringLength(15)]
        public string? Telefono { get; set; }


        public ICollection<DireccionCliente>? Direcciones { get; set; }
        public object Edad { get; set; }
        public object Activo { get; set; }
    }

    public class DireccionCliente : EntityBase
    {
        [Required]
        public int ClienteId { get; set; }

        [Required]
        [StringLength(50)]
        public string? Provincia { get; set; }

        [Required]
        [StringLength(50)]
        public string? Ciudad { get; set; }

        [Required]
        [StringLength(150)]
        public string? Direccion { get; set; }

        [StringLength(10)]
        public string? CodigoPostal { get; set; }

        public Cliente? Cliente { get; set; }
    }
}
