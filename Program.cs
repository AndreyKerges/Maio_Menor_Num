using System;

namespace MediaDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarando as variáveis do tipo DOUBLE e INT
             double soma, media;
             int maior=0, menor, i=0, numero=0, tl=0 ;


            Console.WriteLine("-----Maior e Menor-----");

            // Solicita a quantidade de números que serão digitados
            Console.Write("Digite a quantidade de números que deseja digitar: ");
            tl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            // Solicitando o primeiro número ao usuário
             Console.Write("Digite o 1 número: ");
             numero = Convert.ToInt32(Console.ReadLine()); //Lê a entrada do usuário e converte para int
             maior = numero; //fala que o maior número digitado é o primeiro
             menor = numero; //fala que o menor número digitado é o primeiro
             i = 1; //Inicia o contador em 1

            //Loop para solicitar os demais números e identificar o maior e o menor
             for(i = 2; i <= tl; i++) //Começa o loop a partir do segundo número (i = 2) até o último número (tl)
             {
                Console.Write("Digite o "+ i +" número: "); //Solicita ao usuário o número que está sendo digitado
                numero = Convert.ToInt32(Console.ReadLine()); //Lê a entrada do usuário e converte para int
                if(numero < menor)//Verifica se o número digitado é menor do que o menor número encontrado até agora
                {
                    menor = numero; //Atualiza o valor do menor número
                }
                if(numero > maior) //Verifica se o número digitado é maior do que o maior número encontrado até agora
                {
                    maior = numero; // Atualiza o valor do maior número
                }
             }
            Console.WriteLine();
             // Cálculo da soma e da média dos números
             soma = maior + menor;
             media = soma / 2;

            // Exibição dos resultados
             Console.WriteLine("Entre esse números, o maior é:" + maior);
            Console.WriteLine("Entre esse números, o menor é:" + menor);
            Console.WriteLine("A soma do maior e do menor é: " + soma);
            Console.WriteLine("A média do maior e do menor é: " + media);
            Console.WriteLine();
        }
    }
}