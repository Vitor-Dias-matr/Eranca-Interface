using ErancaEhInterface.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErancaEhInterface.Autenticacao
{
    public class SistemaInerno
    {
        public bool Logar(IAutenticavel funcionario , string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Seja Bem-vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Usuario ou senha Invalida");
                return false;
            }
        }
    }
}
