using ErancaEhInterface.Autenticacao;

namespace ErancaEhInterface.Funcionarios
{
    public class GerenteDeConta :Funcionario, IAutenticavel
    {
        public GerenteDeConta(int cpf) : base(cpf,4000)
        {

        }

        public override void AumentaSalario()
        {
            Salrio *= 0.05;
        }

        public bool Autenticar(string senha)
        {
            throw new System.NotImplementedException();
        }

        public override double GetBonificacao()
        {
            return Salrio = 0.25;
        }
    }
}
