using System;
using System.Collections.Generic;
using Manager.Domain.Validators;


namespace Manager.Domain.Entites{
    public class Servidor : Base{
    

        public int ID{ get; private set; }
        public string NameServidor{ get; private set; }
        public string  EnderecoIP{ get; private set; }
        public int PortaIP { get; private set; }

            public Servidor(){}
            public Servidor(int iD, string nameServidor, string enderecoIP, int portaIP)
        {
            ID = iD;
            NameServidor = nameServidor;
            EnderecoIP = enderecoIP;
            PortaIP = portaIP;
            _errors = new List<string>();
        }
        
        public void ChangeNameServidor(string nameServidor){
            NameServidor = nameServidor;
            Validate();
        }
        public void ChangeEnderecoIP(string enderecoIP){
            EnderecoIP = enderecoIP;
            Validate();
        }
        public void ChangeEnderecoIP(int portaIP){
            PortaIP = portaIP;
            Validate();
        }

        public override bool Validate(){

            var validator = new ServidorValidator();
            var validation = validator.Validate(this);

            if(!validation.IsValid){
                foreach(var error in validation.Errors)
                _errors.Add(error.ErrorMessage);

                throw new Exception("Alguns campos estão invalidos, por favor os corrija" + _errors[0]);
            }

            return true;

        }

    
    }
}