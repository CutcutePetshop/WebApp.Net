using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace PetshopWebApp.Models
{

    [Table("TB_USER")]
    public class User
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id_user")]
        public int IdUser { get; set; }


        [Required(ErrorMessage = "O nome é obrigatório.")]
        [Column("nm_user", TypeName = "VARCHAR(50)")]
        [MinLength(5, ErrorMessage = "O nome deve ser maior que 5 caracteres.")]
        [MaxLength(50, ErrorMessage = "O nome deve ser menor que 50 caracteres.")]
        public required string Name { get; set; }


        [Required(ErrorMessage = "A senha é obrigatória.")]
        [Column("ds_password", TypeName = "VARCHAR(200)")]
        [MinLength(8, ErrorMessage = "A senha deve ser maior que 8 caracteres.")]
        public required string Password { get; set; }


        [Column("ds_email", TypeName = "VARCHAR(80)")]
        [EmailAddress]
        public string? Email { get; set; }


        [Column("ds_user", TypeName = "VARCHAR(200)")]
        [MaxLength(200, ErrorMessage = "A descrição deve ser menor que 200 caracteres.")]
        public string? Description { get; set; }


        [Column("ds_phonenumber", TypeName = "VARCHAR(20)")]
        [MaxLength(20, ErrorMessage = "O número de telefone deve ser menor que 20 caracteres.")]
        public string? PhoneNumber { get; set; }


        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [Column("ds_cpf", TypeName = "VARCHAR(14)")]
        [MaxLength(14, ErrorMessage = "O CPF deve ser menor que 14 caracteres.")]
        public string? Cpf { get; set; }


        [Column("dt_birthday", TypeName = "DATE")]
        public DateTime? Birthday { get; set; }


        [Column("ds_gender", TypeName = "VARCHAR(20)")]
        public string? Gender { get; set; }


        [Column("ds_img_path", TypeName = "VARCHAR(200)")]
        [MaxLength(200, ErrorMessage = "O caminho da imagem deve ser menor que 200 caracteres")]
        public string? ImagePath { get; set; }


        public ICollection<Review>? Reviews { get; set; }

    }
}
