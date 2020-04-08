abstract class Objeto
{
    public int posX, posY;
    public int altura, largura; //definir o tamanho em pixels
    public int velocidade; // 0 a 10, sendo 0 muito lento, 10 muito rápido

    public Objeto(int posX, int posY, int altura, int largura, int velocidade) 
    {
        this.posX = posX;
        this.posY = posY;
        this.altura = altura;
        this.largura = largura;
        this.velocidade = velocidade;
    }
}