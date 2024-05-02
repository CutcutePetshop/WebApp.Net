using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetshopWebApp.Models
{

    [Table("TB_PRODUCT")]
    public class Product
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id_product")]
        public int IdProduct { get; set; }


        [Required(ErrorMessage = "O nome é obrigatório.")]
        [Column("nm_product", TypeName = "VARCHAR(50)")]
        [MaxLength(50, ErrorMessage = "O nome deve ser menor que 50 caracteres.")]
        public required string Name { get; set; }


        [Column("ds_product", TypeName = "VARCHAR(200)")]
        [MinLength(20, ErrorMessage = "A descrição deve ser maior que 20 caracteres.")]
        [MaxLength(200, ErrorMessage = "A descrição deve ser menor que 200 caracteres.")]
        public string? Description { get; set; }


        [Required(ErrorMessage = "O preço é obrigatório.")]
        [Column("vl_product", TypeName = "NUMBER(7, 2)")]
        [Precision(7, 2)]
        public required decimal Price { get; set; }


        [Column("nr_rating", TypeName = "NUMBER(2, 1)")]
        public decimal Rating { get; set; }

        public ICollection<Review>? Reviews { get; set; }


        [ForeignKey("Petshop")]
        [Required(ErrorMessage = "O produto deve pertencer a um petshop.")]
        [Column("id_petshop")]
        public required int PetshopId { get; set; }
        public Petshop? Petshop { get; set; }

    }
}
