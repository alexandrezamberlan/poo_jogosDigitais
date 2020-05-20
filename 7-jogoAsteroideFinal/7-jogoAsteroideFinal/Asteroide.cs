using System;
namespace _7_jogoAsteroideFinal
{
    public class Asteroide
    {
        public String velocidade; //lenta, média, rápida
        public String tamanho; //pequeno, médio, grande
        public double x;
        public double y;
        public double altura;
        public double largura;

        public Asteroide(string tamanho, double x, double y)
        {
            switch (tamanho.ToUpper())
            {
                case "GRANDE":
                    this.velocidade = "LENTA";
                    this.largura = 100;
                    this.altura = 50;
                    break;
                case "MEDIO":
                    this.velocidade = "MEDIA";
                    this.largura = 70;
                    this.altura = 30;
                    break;
                case "PEQUENO":
                    this.velocidade = "RAPIDA";
                    this.largura = 50;
                    this.altura = 10;
                    break;
                default:
                    break;
            }
            
            this.tamanho = tamanho;
            this.x = x;
            this.y = y;
        }
    }
}
