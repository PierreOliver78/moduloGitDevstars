using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo_Git
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Atividade:
             * Crie um programa que receba dois valores e calcule a soma desses valores,
             * ao final exiba o resultado no console.
             */
            #region Base
            Console.WriteLine("Digite 1 para iniciar o programa ou digite 0 para sair");
            int opcao = int.Parse(Console.ReadLine());
            while (opcao != 0)
            {
                int a, b;
                Console.WriteLine("Informe o valor dos numeros a serem somados");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());                
                Console.WriteLine("Soma dos valores é igual a " + Soma(a,b));
                Console.WriteLine("Se desejar repetir digite 1 senão digite 0.");
                opcao = int.Parse(Console.ReadLine());


            }
            #endregion

            #region INSTRUCAO GIT
            {
                //Console.WriteLine("Informe o valor a ser somado");
                //git add .
                //git commit -m 
                //git push

                //git log --oneline
                //git ignore
            }
            #endregion
        }


        static int Soma(int a, int b)
        {
            return a + b;
        } 
        
        static int Subtracao (int a, int b)
        {
            return a - b;
        }

        
    }
}
