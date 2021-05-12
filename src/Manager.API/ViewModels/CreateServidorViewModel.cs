using System.ComponentModel.DataAnnotations;

namespace Manager.API.ViewModes{
    public class CreateUserViewModel{
        
        [Required(ErrorMessage = "O nome do servidor não pode ser vazio.")]
        [MinLength(3, ErrorMessage = "O nome do servidor deve ter no mínimo 3 caracteres.")]
        [MaxLength(20, ErrorMessage = "O nome doservidor deve ter no máximo 80 caracteres.")]
        public string Name { get; set; }

        
    }
}