using System;

namespace ExemploCurso.src
{
    public class Acoes
    {
        public void AdicionarAluno(Aluno[] alunos, ref int indice)
        {
            decimal nota = -1;
            Aluno aluno = new Aluno();
            Console.WriteLine("Digite o nome do aluno");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do aluno");
            if (int.TryParse(Console.ReadLine(), out int idade))
            {
                aluno.Idade = idade;
            }
            else
            {
                throw new ArgumentException("Valor da idade deve ser inteiro");
            }
            
            Console.WriteLine("Digite a nota do aluno");
            while(nota < 0 || nota > 10 ){
            if (decimal.TryParse(Console.ReadLine(), out nota))
            {
                if(nota >= 0 && nota <= 10) {
                    aluno.Nota = nota;
                    
                }
                else
                {
                    Console.WriteLine("Digite um valor entre 0 e 10");
                } ;
            }
            else
            {
            Console.WriteLine("Valor da nota deve ser em decimal");
            nota = -1;
            Console.WriteLine("Digite a nota em um valor entre 0 e 10");
            };
                alunos[indice] = aluno;
                    indice++;
            }
        }
        public void ListarAlunos(Aluno[] alunos, ref int indice)
        {   
            Console.WriteLine("ALUNOS");
            for (int i = 0; i < indice; i++)
            {
               Console.WriteLine($"Aluno: {alunos[i].Nome} \n Idade: {alunos[i].Idade } \n Nota: {alunos[i].Nota} \n");
            }
        }
    }
}