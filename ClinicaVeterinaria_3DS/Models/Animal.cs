using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinaria_3DS.Models
{
    public class Animal
    {
        /*
        create table ANIMAL(
        id_animal int primary key auto_increment,
        id_tutor int,
        id_especie int,
        id_raca int,
        nome varchar(30) not null 
        );
         */
        [Display(Name = "Codigo")]
        public int id { get; set; }

        [Required(ErrorMessage = "O nome do tutor é obrigatorio")]
        [Display(Name = "Nome")]
        public string nome { get; set; }
        
        [Display(Name = "Raca")]
        public Raca refRaca { get; set; }

        [Display(Name = "Especie")]
        public Especie refEspecie { get; set; }
    }
}
