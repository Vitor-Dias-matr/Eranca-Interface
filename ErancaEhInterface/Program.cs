using ErancaEhInterface.Autenticacao;
using ErancaEhInterface.Funcionarios;
using System;


namespace ErancaEhInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            LogarNoSistema();
            //ValorTotalGastoComBonificacoes();
            Console.ReadKey();
        }

        public static void LogarNoSistema()
        {
            SistemaInerno sistemaInerno = new SistemaInerno();

            Diretor vitor = new Diretor(789);
            vitor.Nome = "Vitor";
            vitor.Senha = "123";

            ParceiroComercial pedro = new ParceiroComercial();

            pedro.Senha = "321";

            sistemaInerno.Logar(vitor, "123");
            sistemaInerno.Logar(pedro, "3112");

        }

        public static void ValorTotalGastoComBonificacoes()
        {
            GereanciadorDeBonificacao totalGastoComBonificacoes = new GereanciadorDeBonificacao();

            Funcionario pedro = new Auxiliar(123);
            pedro.Nome = "Pedro";

            Funcionario joao = new Designer(456);
            joao.Nome = "Joao";

            Funcionario vitor = new Diretor(789);
            vitor.Nome = "Vitor";

            Funcionario gabriela = new GerenteDeConta(321);
            gabriela.Nome = "Gabriela";

            totalGastoComBonificacoes.Resgistra(pedro);
            totalGastoComBonificacoes.Resgistra(joao);
            totalGastoComBonificacoes.Resgistra(vitor);
            totalGastoComBonificacoes.Resgistra(gabriela);

            Console.WriteLine("Total gasto com bonificacoes" +
                totalGastoComBonificacoes.GetTotalDeBonificacoes());


        }
    }
}
