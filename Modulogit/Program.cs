using System;

namespace Modulogit
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Atividade:
             * Crie um programa que receba dois valores e calcule a soma desses valores.
             * Ao final exiba o resultado no console.
             */

            #region Base
            Console.WriteLine("Digite 1 para iniciar o programa ou digite 0 para sair");
            int opcao = int.Parse(Console.ReadLine());
            while (opcao != 0)
            {
                int a, b;
                Console.WriteLine("Informe o valor dos valores a serem somandos");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                int resultado = Soma(a, b);
                Console.WriteLine("Soma dos valores é igual a" + resultado);
                Console.WriteLine("Se deseja repitir digite 1 senão digite 0.");
                opcao = int.Parse(Console.ReadLine());

            }
            #endregion  
        }
        static int Soma(int a, int b)
        {
            return a + b;
        }
    }
}
