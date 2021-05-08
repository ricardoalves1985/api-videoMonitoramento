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
            _errors = new list<string>();
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

    
    }
}