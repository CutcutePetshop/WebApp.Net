using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace PetshopWebApp.Models
{

    [Table("TB_REVIEW")]
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdReview { get; set; }


        [Required(ErrorMessage = "A quantidade de estrelas é obrigatória.")]
        [Column("ReviewStars", TypeName = "NUMBER")]
        [Range(1, 5, ErrorMessage = "A quantidade de estrelas deve ser entre 1 e 5.")]
        public required int Stars { get; set;}


        [Column("ReviewDescription", TypeName = "VARCHAR(200)")]
        [MaxLength(200, ErrorMessage = "A descrição deve ser menor que 200 caracteres.")]
        public string? Description { get; set; }


        [Required(ErrorMessage = "A data publicada é obrigatória.")]
        [Column("ReviewDatePublished", TypeName = "DATE")]
        public required DateTime DatePublished { get; set; }

    }
}
