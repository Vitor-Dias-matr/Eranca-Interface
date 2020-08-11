using ErancaEhInterface.Autenticacao;

namespace ErancaEhInterface.Funcionarios
{
    public class Diretor :FuncionarioAutenticavel
    {
        public Diretor(int cpf) : base(cpf, 5000)
        {

        }

        public override void AumentaSalario()
        {
            Salrio *= 1.15;
        }
        public override double GetBonificacao()
        {
            return Salrio * 0.5;
        }

    }
}
