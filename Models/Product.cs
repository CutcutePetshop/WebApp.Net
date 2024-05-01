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
        public int IdProduct { get; set; }


        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Column("ProductDescription", TypeName = "VARCHAR(200)")]
        [MinLength(20, ErrorMessage = "A descrição deve ser maior que 20 caracteres.")]
        [MaxLength(200, ErrorMessage = "A descrição deve ser menor que 200 caracteres.")]
        public string? Description { get; set; }


        [Required(ErrorMessage = "O preço é obrigatório.")]
        [Column("ProductPrice", TypeName = "NUMBER(7, 2)")]
        [Precision(7, 2)]
        public required decimal Price { get; set; }

    }
}
