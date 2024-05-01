using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace PetshopWebApp.Models
{

    [Table("TB_PET")]
    public class Pet
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPet { get; set; }


        [Required(ErrorMessage = "O nome é obrigatório.")]
        [Column("PetName", TypeName = "VARCHAR(20)")]
        [MinLength(3, ErrorMessage = "O nome deve ser maior que 3 caracteres.")]
        [MaxLength(20, ErrorMessage = "O nome deve ser menor que 20 caracteres.")]
        public required string Name { get; set; }


        [Column("PetDescription", TypeName = "VARCHAR(200)")]
        [MaxLength(200, ErrorMessage = "A descrição deve ser menor que 200 caracteres.")]
        public string? Description { get; set; }


        [Required(ErrorMessage = "A espécie é obrigatória.")]
        [Column("PetSpecies", TypeName = "VARCHAR(20)")]
        [MaxLength(20, ErrorMessage = "A espécie deve ser menor que 20 caracteres.")]
        public required string Species { get; set; }


        [Column("PetRace", TypeName = "VARCHAR(20)")]
        [MaxLength(20, ErrorMessage = "A raca deve ser menor que 20 caracteres.")]
        public string? Race { get; set; }


        [Column("PetSex", TypeName = "VARCHAR(1)")]
        [MaxLength(1, ErrorMessage = "O sexo deve conter somente 1 caractere.")]
        public string? Sex { get; set; }


        [Column("PetBirthday", TypeName = "DATE")]
        public DateTime? Birthday { get; set; }


        [Required(ErrorMessage = "O porte é obrigatório.")]
        [Column("PetPort", TypeName = "VARCHAR(20)")]
        [MaxLength(20, ErrorMessage = "O porte deve ser menor que 20 caracteres")]
        public required string Port { get; set; }


        [Column("PetWeight", TypeName = "NUMBER(5, 2)")]
        [Precision(5, 2)]
        public decimal? Weight { get; set; }


        [Required(ErrorMessage = "A imagem é obrigatória.")]
        [Column("PetImagePath", TypeName = "VARCHAR(200)")]
        [MaxLength(200, ErrorMessage = "O caminho da imagem deve ser menor que 200 caracteres")]
        public string? ImagePath { get; set; }

    }
}
