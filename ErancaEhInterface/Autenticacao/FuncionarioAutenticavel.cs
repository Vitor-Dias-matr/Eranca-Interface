using ErancaEhInterface.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErancaEhInterface.Autenticacao
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {

        public string Senha { get; set; }

        public FuncionarioAutenticavel(int cpf, double salario):base(cpf,salario)
        {
                    
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
