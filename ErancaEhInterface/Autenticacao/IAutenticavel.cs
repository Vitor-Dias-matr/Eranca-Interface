using ErancaEhInterface.Funcionarios;
using System;

namespace ErancaEhInterface.Autenticacao
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
