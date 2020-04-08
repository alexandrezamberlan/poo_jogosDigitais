using System;
class Barreira : Objeto
{
    public Barreira(int larguraTela, int altura) 
    {
        Random gerador = new Random();
        this.posX = gerador.Next(10, larguraTela-100);
        this.posY = gerador.Next(10, alturaTela-10);
        this.altura = 10; 
        this.largura = gerador.Next(30, 100);
        this.velocidade = gerador.Next(0,10);
    }

    public void moverDireita()
    {
        switch (this.velocidade)
        {
            case 1: this.posX = this.posX + 10;
            case 2: this.posX = this.posX + 20;
            case 3: this.posX = this.posX + 30;
            case 4: this.posX = this.posX + 40;
            case 5: this.posX = this.posX + 50;
            case 6: this.posX = this.posX + 60;
            case 7: this.posX = this.posX + 70;
            case 8: this.posX = this.posX + 80;
            case 9: this.posX = this.posX + 90;
            case 10: this.posX = this.posX + 100;
        }
    }

    public void moverEsquerda()
    {
        switch (this.velocidade)
        {
            case 1: this.posX = this.posX - 10;
            case 2: this.posX = this.posX - 20;
            case 3: this.posX = this.posX - 30;
            case 4: this.posX = this.posX - 40;
            case 5: this.posX = this.posX - 50;
            case 6: this.posX = this.posX - 60;
            case 7: this.posX = this.posX - 70;
            case 8: this.posX = this.posX - 80;
            case 9: this.posX = this.posX - 90;
            case 10: this.posX = this.posX - 100;
        }
    }
}