using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetshopWebApp.Models
{

    [Table ("TB_PETSHOP")]
    public class Petshop
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id_petshop")]
        public int IdPetshop { get; set; }


        [Required(ErrorMessage = "O nome é obrigatório.")]
        [Column("nm_petshop", TypeName = "VARCHAR(50)")]
        [MaxLength(50, ErrorMessage = "O nome deve ser menor que 50 caracteres.")]
        public required string Name { get; set; }


        [Column("ds_cep", TypeName = "VARCHAR(50)")]
        [MinLength(10, ErrorMessage = "O CEP deve ser maior que 10 caracteres.")]
        [MaxLength(50, ErrorMessage = "O CEP deve ser menor que 50 caracteres.")]
        public string? Cep { get; set; }


        [Column("nr_rating", TypeName = "NUMBER(2, 1)")]
        public decimal Rating { get; set; }

        public ICollection<Review>? Reviews { get; set; }


        public ICollection<Pet>? Pets { get; set; }
        public ICollection<Product>? Products { get; set; }


    }
}
