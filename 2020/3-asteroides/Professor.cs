using System;
namespace _1_jogos
{
    class Professor : Pessoa
    {
        public string funcao;

        public Professor(int matricula, string nome, string funcao)
        {
            this.Matricula = matricula;
            this.Nome = nome;
            this.funcao = funcao;
        }
    }
}
