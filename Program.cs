using System;

namespace ExProgramacaoUnidade1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             
            ex 1

             double c, f;
             Console.WriteLine("Digite a temperatura que deseja converter");
             c = Double.Parse(Console.ReadLine());
             f = (c * 1.8) + 32;
             Console.WriteLine(f);*/

            /* ex 2*/

            /* double salario;

             Console.WriteLine("Digite o valor da hora aula");
             double horaAula = Double.Parse(Console.ReadLine());

             Console.WriteLine("Digite a quantidade de horas trabalhadas");
             int qtdHoras = int.Parse(Console.ReadLine());

             Console.WriteLine("Digite o valor de percentual desconto do INSS");
             double desconto = Double.Parse(Console.ReadLine());

             salario = (qtdHoras * horaAula) - ((qtdHoras * horaAula*desconto) / 100);

             Console.WriteLine("Seu salário liquido é {0}",salario);*/



            /* ex 3*/

            /*Console.WriteLine("Digite um numero");
            double num = Double.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine(Math.Sqrt(num));
            } else
            {
                Console.WriteLine(Math.Pow(num, 2));
            } */

            /* ex 4*/

            /* const double pi = 3.1415;

             Console.WriteLine("Digite o valor do raio:");
             double raio = Double.Parse(Console.ReadLine());

             double area = pi * Math.Pow(raio, 2);

             Console.WriteLine("O valor da área é: {0}", area);*/

            /*ex 5*/

            /* int anoAtual = DateTime.Now.Year;

             Console.WriteLine("Digite o ano de nascimento");
             int anoNascimento = int.Parse(Console.ReadLine());

             int idadeAtual = anoAtual - anoNascimento;
             int idade2022 = 2022 - anoNascimento;

             Console.WriteLine("Sua idade atual é:{0}", idadeAtual);
             Console.WriteLine("Sua idade em 2022 é:{0}", idade2022);*/


            /* ex 6 */


            /*  double precoFabrica, precoFinal, lucro, imposto;

              Console.WriteLine("Digite o valor de fábrica:");
              precoFabrica = Double.Parse(Console.ReadLine());

              Console.WriteLine("Digite o valor do % de lucro:");
              lucro = Double.Parse(Console.ReadLine());

              Console.WriteLine("Digite o valor do % de imposto:");
              imposto = Double.Parse(Console.ReadLine());

              lucro = (precoFabrica * lucro) / 100;
              imposto = (precoFabrica * imposto) / 100;
              precoFinal = lucro + precoFabrica + imposto;

              Console.WriteLine($"O  valor  correspondente  ao  lucro  do  distribuidor é: {lucro}");
              Console.WriteLine("O  valor  correspondente  aos impostos são: {0}", imposto);
              Console.WriteLine("O preço final do veículo é: {0}", precoFinal);*/

            /* ex_prog 7*/

            /* Console.WriteLine("Digite a altura do degrau em cm:");
             int alturaDegrau = int.Parse(Console.ReadLine());

             Console.WriteLine("Digite a altura que deseja alcançar em cm:");
             int alturaTotal = int.Parse(Console.ReadLine());

             double qtdDegrais = alturaTotal / alturaDegrau;

             if (alturaTotal % alturaDegrau != 0)
             {
                 qtdDegrais++;
             }

             Console.WriteLine("O usuário devera subir {0} degrais.", qtdDegrais);*/

            /* ex 8 */

            /*double salarioMinimo = 1192.40;
            double horaTrabalhda = 1192.40 / 2;
            int imposto = 3;

            Console.WriteLine("Digite o numero de horas trabalhadas:");
            int qtdHorasTrab = int.Parse(Console.ReadLine());

            double salarioBruto = qtdHorasTrab * horaTrabalhda;
            double impostoFinal = (salarioBruto * imposto) / 100;

            Console.WriteLine("O valor da hora trabalhada é: {0}", horaTrabalhda);
            Console.WriteLine("O valor do salário bruto é: {0}", salarioBruto);
            Console.WriteLine("O valor do imposto é: {0}", impostoFinal);
            Console.WriteLine("O salário a receber é: {0}", (salarioBruto - impostoFinal));*/

            /* ex 9 */

            /* int opcao = 1;

             Console.WriteLine("Digite um numero de 1 a 4");
             opcao = int.Parse(Console.ReadLine());

                 switch (opcao)
                 {
                     case 1:
                         Console.WriteLine("O presente é PS4");
                         break;

                     case 2:
                         Console.WriteLine("o presente é uma boneca");
                         break;

                     case 3:
                         Console.WriteLine("O presente é uma bola");
                         break;

                     case 4:
                         Console.WriteLine("O presente é uma pipa");
                         break;

                     default:
                         Console.WriteLine("Opção não identificada, Tente novamente!");
                         break;
                 }
            */
        }
    }
}
