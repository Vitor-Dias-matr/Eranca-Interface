namespace ErancaEhInterface.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public int CPF { get; private set; }
        public double Salrio { get; protected set; }

        public Funcionario(int cpf, double salario)
        {
            CPF = cpf;
            Salrio = salario;
        }

     
        public abstract double GetBonificacao();

        public abstract void AumentaSalario();


    }
}
