namespace ErancaEhInterface.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(int cpf) : base(cpf,3000)
        {

        }

        public override void AumentaSalario()
        {
            Salrio *= 0.11;
        }

        public override double GetBonificacao()
        {
            return Salrio * 0.17;
        }
    }
}
