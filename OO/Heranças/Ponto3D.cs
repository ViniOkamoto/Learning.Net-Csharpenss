namespace OO.Heranças
{   // Filho/ Pai
    public class Ponto3D : Ponto
    {
        public int z;
        //Da base vem os parâmetros de ponto.
        public Ponto3D(int x, int y, int z) : base(x,y)
        {
             this.z = z;
             CalcularDistancia();
        }
        public static void Calcular()
        {
        }
        //Quando colocamos um override, transcrevemos a função dentro de Ponto por ela ser virtual.
        public override void CalcularDistancia2()
        {
            base.CalcularDistancia2();
        }
    }
}