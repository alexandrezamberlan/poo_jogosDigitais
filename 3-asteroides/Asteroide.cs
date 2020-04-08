using System;
class Asteroide : Objeto
{
    public Asteroide(int larguraTela, int alturaTela) 
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
                    break;
            case 2: this.posY = this.posY + 20;
                    break;
            case 3: this.posY = this.posY + 30;
                    break;            
            case 4: this.posY = this.posY + 40;
                    break;            
            case 5: this.posY = this.posY + 50;
                    break;            
            case 6: this.posY = this.posY + 60;
                    break;            
            case 7: this.posY = this.posY + 70;
                    break;            
            case 8: this.posY = this.posY + 80;
                    break;            
            case 9: this.posY = this.posY + 90;
                    break;            
            case 10: this.posY = this.posY + 100;
                    break;
        }
    }
}