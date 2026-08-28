using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinaria_3DS.Models
{
    public class Especie
    {/*
      create table ESPECIE(
      id_especie int	primary key auto_increment,
      nome varchar(30) not null
      );
      */
        [Display(Name = "Codigo")]
        public int id { get; set; }

        [Required(ErrorMessage = "O nome do tutor é obrigatorio")]
        [Display(Name = "Nome")]
        public string nome { get; set; }
    }
}
