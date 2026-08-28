using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinaria_3DS.Models
{
    public class Tutor
    {
        /*
        create table TOTOR(
        id_tutor int primary key auto_increment,
        nome varchar(50) not null,
        telefone varchar(15) not null,
        email varchar(30) not null
        );         
         */
        [Display(Name = "Codigo")]
        public int id { get; set; }

        [Required(ErrorMessage = "O nome do tutor é obrigatorio")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Required(ErrorMessage = "O Telefone do tutor é obrigatorio")]
        [Display(Name = "Telefone")]
        public string telefone { get; set; }

        [Required(ErrorMessage = "O E-mail do tutor é obrigatorio")]
        [Display(Name = "E-mail")]
        public string email { get; set; }
    }
}
