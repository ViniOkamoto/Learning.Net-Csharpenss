namespace OO.Heranças
{
    public class Ponto
    {
        public int x, y;
        private int distancia;
        public Ponto (int x, int y)
        {
            this.x = x;
            this.y = y;
        }
     protected void CalcularDistancia()
     {
         //É possível que realizar chamada dos privates dentro somente das classes em que foram criadas.
         CalcularDistancia1();
     }
     private void CalcularDistancia1()
     {
         //Calcula distancia 
     }
     //Virtual permite que uma classe filha sobrescreva a atuação dele
     public virtual void CalcularDistancia2()
     {
         //Calcula distancia 
     }
    }
}