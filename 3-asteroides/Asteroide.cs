using System;
class Asteroide : Objeto
{
    public Asteroide(int larguraTela, int altura) 
    {
        Random gerador = new Random();
        this.posX = gerador.Next(10, larguraTela-10);
        this.posY = gerador.Next(10, alturaTela-10);
        this.altura = gerador.Next(10, 50); 
        this.largura = gerador.Next(10, 50);
        this.velocidade = gerador.Next(0,10);
    }
    public void moverBaixo()
    {
        switch (this.velocidade)
        {
            case 1: this.posY = this.posY + 10;
            case 2: this.posY = this.posY + 20;
            case 3: this.posY = this.posY + 30;
            case 4: this.posY = this.posY + 40;
            case 5: this.posY = this.posY + 50;
            case 6: this.posY = this.posY + 60;
            case 7: this.posY = this.posY + 70;
            case 8: this.posY = this.posY + 80;
            case 9: this.posY = this.posY + 90;
            case 10: this.posY = this.posY + 100;
        }
    }
}