namespace ErancaEhInterface.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(int cpf): base(cpf,2000)
        {

        }

        public override void AumentaSalario()
        {
            Salrio *= 0.10;
        }

        public override double GetBonificacao()
        {
           return Salrio * 0.2;

        }

        
    }
}
