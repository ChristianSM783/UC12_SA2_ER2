using Cadastro_Pessoa_FS1.Interfaces;

namespace Cadastro_Pessoa_FS1.Classes
{
    public class PessoaFisica : Pessoa , IPessoaFisica 
    {

        public string ?Cpf { get; set; }
        
        public DateTime ?DataNasc { get; set; }
        

        public bool ValidarDataNasc(DateTime DataNasc)
        {
            throw new DllNotFoundException();
        }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}