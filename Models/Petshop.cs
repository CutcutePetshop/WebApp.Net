using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetshopWebApp.Models
{

    [Table ("TB_PETSHOP")]
    public class Petshop
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPetshop { get; set; }


        [Required(ErrorMessage = "O nome é obrigatório.")]
        [Column("PetshopName", TypeName = "VARCHAR(50)")]
        [MaxLength(50, ErrorMessage = "O nome deve ser menor que 50 caracteres.")]
        public required string Name { get; set; }


        [Column("PetshopCEP", TypeName = "VARCHAR(50)")]
        [MinLength(10, ErrorMessage = "O CEP deve ser maior que 10 caracteres.")]
        [MaxLength(50, ErrorMessage = "O CEP deve ser menor que 50 caracteres.")]
        public string? Cep { get; set; }

    }
}
