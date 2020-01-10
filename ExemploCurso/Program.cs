using System;
using ExemploCurso.src;
namespace ExemploCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            Acoes funcao = new Acoes();
            Aluno[] alunos = new Aluno[5];
            int indice = 0;
            string op = ObterOpcao();
            while (op.ToUpper() != "X")
            {
                switch (op)
                {
                    case "1":
                    if(indice == alunos.Length){
                            Console.WriteLine("Não é possível cadastrar mais alunos");
                        }
                        funcao.AdicionarAluno(alunos, ref indice);
                        // adicionar aluno
                        break;
                    case "2":
                        funcao.ListarAlunos(alunos, ref indice);
                        //Listar alunos
                        break;
                    case "3":
                        //Calcular média geral
                        break;
                    default:
                        Console.WriteLine("Digite um valor válido!");
                        break;

                }
                op = ObterOpcao();
                if (op.ToUpper() == "X")
                {
                    Console.WriteLine("Encerrando \n Obrigado!");
                }
            }

            static string ObterOpcao()
            {
                Console.WriteLine("Informe a opção desejada: \n 1- Inserir novo aluno  \n 2- Listar Alunos  \n 3- Calcular média geral \n 4 - Buscar informações sobre o aluno \n X - Para fechar a aplicação. ");
                string op = Console.ReadLine();
                return op;
            }


            // Console.WriteLine("1- Inserir novo aluno");
            // Console.WriteLine("2- Listar alunos");
            // Console.WriteLine("3- Calcular média geral");
            // Console.WriteLine("4- Buscar Informações aluno");
            // Console.WriteLine("X- Sair")
        }
    }
}
