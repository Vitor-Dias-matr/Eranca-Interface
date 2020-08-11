namespace ErancaEhInterface.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(int cpf) : base(cpf,3000)
        {

        }
        public override double GetBonificacao()
        {
            return Salrio *= 0.5;
        }

        public override void AumentaSalario()
        {
            Salrio *= 1.5;
        }
    }
}
