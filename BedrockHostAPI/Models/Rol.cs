using System.ComponentModel.DataAnnotations;

namespace BedrockHostAPI.Models
{
    public class Rol
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
    }
}