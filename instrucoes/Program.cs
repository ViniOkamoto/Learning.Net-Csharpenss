using System;

namespace instrucoes
{
    class Program
    {
            static void Declaracoes()
            {
                int a;
                int b = 2, c = 3;
                const int d = 4;
                a = 1;
                Console.WriteLine(a + b + c + d);
            }
            static void InstucaoIf(string[] args){
                if(args.Length == 0)
                {
                    Console.WriteLine(" Nenhum argumento");
                }
                else if(args.Length == 1)
                {
                    Console.WriteLine("Um argumento");
                }
                else
                {
                    Console.WriteLine($"{args.Length} argumentos");
                }
            }
            static void InstrucaoSwitch(string[] args)
            {
                int numeroDeArgumentos = args.Length;
                switch(numeroDeArgumentos)
                {
                    case 0:
                        Console.WriteLine("Nenhum argumento");
                        break;
                    case 1:
                        Console.WriteLine("Um argumento");
                        break;
                    default:
                        Console.WriteLine("Nenhum argumento");
                        break;
                      
                    
                }     
            }
            static void IntrucaoWhile(string[] args)
            {
                int i = 0;
                while (i< args.Length)
                {
                    Console.WriteLine($"Quantidade {args[i]}");
                    i++;
                }
            }
            static void IntrucaoDo(string[] args)
            {
                string texto;
                do
                {
                    texto = Console.ReadLine();
                    Console.WriteLine(texto);
                } while (!string.IsNullOrEmpty(texto));
            }
            static void IntrucaoFor(string[] args)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine(args[i]);
                }
            }
             static void IntrucaoForEach(string[] args)
            {
                foreach (string s in args)
                {
                    Console.WriteLine(s);
                }
            }
              static void IntrucaoBreak(string[] args)
            {
                while(true)
                {
                    string s = Console.ReadLine();
                    if(string.IsNullOrEmpty(s)) break;
                    
                    Console.WriteLine(s);
                }
                
            }
              static void IntrucaoContinue(string[] args)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if(args[i].StartsWith("/")) continue;
                    
                    Console.WriteLine(args[i]);
                }                
            }
              static void IntrucaoReturn(string[] args)
            {
                int Somar(int a, int b)
                {
                    return a + b;    
                }            

                if(args.Length == 0){
                    Console.WriteLine("Não há argumento");
                    return;
                }
                Console.WriteLine(Somar(4,5));
                return;
            }

            static void IntrucoesTryCatchFinnalyThrow(string[] args)
            {
                double Dividir(double x, double y)
                {
                        if(y == 0 )
                        throw new DivideByZeroException();
                    return x / y;
                }

                try
                {
                    if(args.Length != 2)
                    {
                        throw new InvalidOperationException("Informe 2 números");
                    }

                    double x = double.Parse(args[0]);
                    double y = double.Parse(args[1]);
                    Console.WriteLine(Dividir(x, y));
                }
                catch(InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Erro genérico: {e.Message}");
                }
                finally 
                {
                    Console.WriteLine("Código finalizado");
                }
            }

        static void InstrucaoUsing(string[] args)
        {
            using(System.IO.TextWriter w = System.IO.File.CreateText("texte.txt"))
            {
                w.WriteLine("Oi/n");
                w.WriteLine("funcionou/n");
                w.WriteLine("vamos lá!");
            }
        }
        static void UsandoArrayMatrizes(string[] args)
        {
            // Array unidimensional
            int[] a = new int [10];
            for (int i = 0; i< a.Length; i++)
            {
                a[i] = i * i;
            }
            for (int i = 0; i< a.Length; i++)
            {
                Console.WriteLine($"a[{i}] = a {a[i]}");
            }

            int[,] b = new int [10, 5];
            int [,,] c = new int [10, 5, 2];
        }

    }
}
