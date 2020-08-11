using ErancaEhInterface.Funcionarios;

namespace ErancaEhInterface
{
    public class GereanciadorDeBonificacao
    {
        private double _totalDeBonificacao;

        public void Resgistra(Funcionario funcionario)
        {
            _totalDeBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalDeBonificacoes()
        {
            return _totalDeBonificacao;
        }
    }
}
