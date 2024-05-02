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
        [Column("id_review")]
        public int IdReview { get; set; }


        [Required(ErrorMessage = "A quantidade de estrelas é obrigatória.")]
        [Column("qt_stars", TypeName = "NUMBER")]
        [Range(1, 5, ErrorMessage = "A quantidade de estrelas deve ser entre 1 e 5.")]
        public required int Stars { get; set;}


        [Column("ds_review", TypeName = "VARCHAR(200)")]
        [MaxLength(200, ErrorMessage = "A descrição deve ser menor que 200 caracteres.")]
        public string? Description { get; set; }


        [Required(ErrorMessage = "A data publicada é obrigatória.")]
        [Column("dt_published", TypeName = "DATE")]
        public DateTime DatePublished { get; set; }


        [Required(ErrorMessage = "O usuario é obrigatório.")]
        [ForeignKey("id_usuario")]
        public required int UserId { get; set; }
        public required User User { get; set; }


        [ForeignKey("Product")]
        [Column("id_product")]
        public int? ProductId { get; set; }

        public Product? Product {  get; set; }


        [ForeignKey("Petshop")]
        [Column("id_petshop")]
        public int? PetshopId { get; set; }

        public Petshop? Petshop { get; set; }

    }
}
