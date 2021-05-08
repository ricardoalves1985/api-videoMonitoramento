using FluentValidation;


namespace Manager.Domain.Validators{
    public class ServidorValidator{
         public class ServidorValidator : AbstractValidator<Servidor>{

             public ServidorValidator()
             {
                RuleFor(x => x)
                    .NotEmpty()
                    .WithMessage("A entidade não pode ser vazia.")
                    
                    .NotNull()
                    .WithMessage("A entidade não pode ser nula.");
                    
                RuleFor(x => x.NameServidor)
                    .NotEmpty()
                    .WithMessage("A entidade não pode ser vazia.")
                    
                    .NotNull()
                    .WithMessage("A entidade não pode ser nula.")  

                    .MinimunLength(3)
                    .WithMessage("O nome deve ter no mínimo 3 caracteres.") 
                    
                    .MaximunLength(80)
                    .WithMessage("O nome deve ter no máximo 80 caracteres.") ;

                

             }
         }
    }
}