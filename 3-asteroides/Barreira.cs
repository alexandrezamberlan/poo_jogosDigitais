using System;
namespace _1_jogos
{
    class Barreira : Objeto
    {
        public Barreira(int larguraTela, int alturaTela)
        {
            Random gerador = new Random();
            this.posX = gerador.Next(10, larguraTela - 100);
            this.posY = gerador.Next(10, alturaTela - 10);
            this.altura = 10;
            this.largura = gerador.Next(30, 100);
            this.velocidade = gerador.Next(0, 10);
        }

        public void moverDireita()
        {
            switch (this.velocidade)
            {
                case 1:
                    this.posX = this.posX + 10;
                    break;
                case 2:
                    this.posX = this.posX + 20;
                    break;
                case 3:
                    this.posX = this.posX + 30;
                    break;
                case 4:
                    this.posX = this.posX + 40;
                    break;
                case 5:
                    this.posX = this.posX + 50;
                    break;
                case 6:
                    this.posX = this.posX + 60;
                    break;
                case 7:
                    this.posX = this.posX + 70;
                    break;
                case 8:
                    this.posX = this.posX + 80;
                    break;
                case 9:
                    this.posX = this.posX + 90;
                    break;
                case 10:
                    this.posX = this.posX + 100;
                    break;
            }
        }

        public void moverEsquerda()
        {
            switch (this.velocidade)
            {
                case 1:
                    this.posX = this.posX - 10;
                    break;
                case 2:
                    this.posX = this.posX - 20;
                    break;
                case 3:
                    this.posX = this.posX - 30;
                    break;
                case 4:
                    this.posX = this.posX - 40;
                    break;
                case 5:
                    this.posX = this.posX - 50;
                    break;
                case 6:
                    this.posX = this.posX - 60;
                    break;
                case 7:
                    this.posX = this.posX - 70;
                    break;
                case 8:
                    this.posX = this.posX - 80;
                    break;
                case 9:
                    this.posX = this.posX - 90;
                    break;
                case 10:
                    this.posX = this.posX - 100;
                    break;
            }
        }
    }
}