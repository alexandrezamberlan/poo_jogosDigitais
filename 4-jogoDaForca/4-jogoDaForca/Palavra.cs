using System;
namespace _4_jogoDaForca
{
    public class Palavra
    {
        public string texto;
        public string categoria;

        public Palavra(string palavra, string categoria)
        {
            this.texto = palavra.ToUpper();
            this.categoria = categoria.ToUpper();
        }
    }
}
