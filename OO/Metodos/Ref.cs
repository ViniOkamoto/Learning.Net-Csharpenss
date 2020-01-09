using System;

namespace OO.Metodos
{
    public class Ref
    {
        //O que fazermos dentro do método não afeta quem chamá-lo.
        static void Inverter(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void Inverter()
        {
            int i = 1, j =2;
            // Quanto utilizamos o ref, não passaremos mais o valor e sim como uma referência.
            Inverter(ref i, ref j);
            Console.WriteLine($"{i} {j}"); 
        }
    }
}