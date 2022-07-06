using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1_avaliacao_lp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - Faça um programa que receba o nome do aluno, nota de trabalho, nota da prova 1 e nota da prova 2. Calcule a média  final (média simples) e apresente o conceito obtido seguindo a seguinte formula:

            //O conceito da será calculado da seguinte forma:
            //Se a nota final for maior ou igual a 8.5, então o conceito é A.
            //Se a nota final estiver entre 7.0 e 8.4, então o conceito é B.
            //Se a nota final estiver entre 6.0 e 6.9, então o conceito é C.
            //Se a nota final estiver entre 0.1 e 5.9, então o conceito é D.
            //Se a nota final for igual a 0.0, então o conceito é E.

            // Eduardo Augusto Nilson Parada RA 6322529.

            double n1, p1, p2, media;
            string nome;
            Console.WriteLine("Digite o nome do Aluno:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite nota do trabalho:");
            n1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota da P1:");
            p1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota da P2:");
            p2 = Double.Parse(Console.ReadLine());

            media = (n1 + p1 + p2) / 3;

            if (media <= 10 && media >= 8.5)
            {
                Console.WriteLine("Aluno " + nome + " conceito A");

            }
            else if (media < 8.5 && media >= 7)
            {
                Console.WriteLine("Aluno " + nome + " conceito B");

            }
            else if (media < 7 && media >= 6)
            {
                Console.WriteLine("Aluno " + nome + " conceito C");

            }
            else if (media < 6 && media >= 0.1)
            {
                Console.WriteLine("Aluno " + nome + " conceito D");

            }
            else if (media == 0)
            {
                Console.WriteLine("Aluno " + nome + " conceito E");

            }
            else
            {
                Console.WriteLine("Não é possível calcular a nota do aluno " + nome);
            }
            Console.ReadKey();

        }
                        
    }

}
