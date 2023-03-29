using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////exercicio 1
            // int x;
            //     float total;
            // Console.WriteLine("digite o numero do x");
            // x= int.Parse(Console.ReadLine());
            // if (x < 12)
            //   total = x * 0.35f;
            // else
            //     total = x * 0.28f;
            // Console.WriteLine(total); 
            // Console.ReadLine();

            //exercicio 2
            //int x, total,resultado;

            //Console.WriteLine("digite o ano de nascimento");
            //x = int.Parse(Console.ReadLine());
            //resultado = (2023 - x);
            //if (resultado >= 16)

            //    Console.WriteLine("pode votar");

            //else
            //    Console.WriteLine("não pode votar");
            // Console.ReadKey();


            ////exercicio 3
            //int num1, num2, num3;
            //Console.WriteLine("digite o numero1");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("digite o numero2");
            //num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("digite o numero3");
            //num3 = int.Parse(Console.ReadLine());

            //if (num1 == num2 && num2 == num3)
            //    Console.WriteLine("equilatero");
            //else

            //if ((num1 == num2 && num2 != num3) || (num1 == num3 && num1 != num2) || (num3 == num2 && num3 != num1))
            //    Console.WriteLine("isoceles");
            //else
            //    Console.WriteLine("escaleno");
            //Console.ReadKey();


            // exercicio 4
            // int a, b, c, delta;
            // double x1, x2;
            // Console.WriteLine("digite o valor de a");
            // a = int.Parse(Console.ReadLine());
            // Console.WriteLine("digite o valor de b");
            // b = int.Parse(Console.ReadLine());
            //Console.WriteLine("digite o valor de c");
            // c = int.Parse(Console.ReadLine());

            // delta = b * b - 4 * a * c;
            // x1 = -b + Math.Sqrt(delta) / 2 * a;
            //  x2 = -c + Math.Sqrt(delta) / 2 * a;

            // Console.WriteLine(x1);
            // Console.WriteLine(x2);

            // Console.ReadKey();

            // exercicio 5

            //int numero;
            //Console.WriteLine("digite um numero inteiro");
            //numero= int.Parse(Console.ReadLine());

            //if (numero % 3 == 0 && numero % 5 == 0)
            //    Console.WriteLine("numero é divisivel por 3 e 5");
            //else
            //    if (numero % 3 == 0) 
            //Console.WriteLine("numero é divisivel por 3 ");

            //else
            //    if (numero % 5 == 0)
            //    Console.WriteLine("numero é divisivel por 5");

            //else
            //    Console.WriteLine("numero não é divisivel por 3 nem 5");
            //Console.ReadKey();

            //// exercicio 6

            //    float num1, num2, num3;
            //Console.WriteLine("digite o numero do angulo 1");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("digite o numero  do angulo 2");
            //num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("digite o numero  do angulo 3");
            //num3 = int.Parse(Console.ReadLine());

            //if (num1 + num2 + num3 == 180)

            //    if (num1 == 90 || num2 == 90 || num3 == 90)
            //        Console.WriteLine("o triangulo é retangulo");

            //    else
            //            if (num1 > 90 || num2 > 90 || num3 > 90)
            //        Console.WriteLine("o triangulo é obtusangulo");

            //    else

            //        Console.WriteLine("o triangulo é acutangulo");
            //else
            //    Console.WriteLine(" valores invalidos");
            //Console.ReadKey();

            // Exercício 7
            //Console.WriteLine("Digite três valores inteiro");

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if (a < b && a < c)
            //{

            //    if (b < c)
            //    {
            //        Console.WriteLine(a + "," + b + "," + c);
            //    }
            //    else
            //    {
            //        Console.WriteLine(a + ", " + c + ", " + b);
            //    }
            //}
            //else if (b < a && b < c)
            //{
            //    if (a < c)
            //    {
            //        Console.WriteLine(b + ", " + a + ", " + c);
            //    }
            //    else
            //    {
            //        Console.WriteLine(b + ", " + c + ", " + a);
            //    }
            //}
            //else
            //{
            //    if (a < b)
            //    {
            //        Console.WriteLine(c + ", " + a + ", " + b);
            //    }
            //    else
            //    {
            //        Console.WriteLine(c + ", " + b + ", " + a);
            //    }
            //}

            //Exercício 8
            //Console.Write("Informe um ano: ");
            //int ano = int.Parse(Console.ReadLine());

            //if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
            //{
            //    Console.WriteLine("O ano informado é bissexto.");
            //}
            //else
            //{
            //    Console.WriteLine("O ano informado não é bissexto.");
            //}

            //Exercício 9
            //Console.Write("Digite o primeiro número: ");
            //float num1 = float.Parse(Console.ReadLine());
            //Console.Write("Digite o segundo número: ");
            //float num2 = float.Parse(Console.ReadLine());

            //Console.Write("Digite a operação (+, -, *, /): ");
            //string operacaoStr = Console.ReadLine();
            //float resultado;
            //if (operacaoStr == "+")
            //{
            //    resultado = num1 + num2;
            //}
            //else if (operacaoStr == "-")
            //{
            //    resultado = num1 - num2;
            //}
            //else if (operacaoStr == "*")
            //{
            //    resultado = num1 * num2;
            //}
            //else if (operacaoStr == "/")
            //{
            //    resultado = num1 / num2;
            //}
            //else
            //{
            //    Console.WriteLine("Operação inválida.");
            //    return;
            //}

            //Console.WriteLine("Resultado: " + resultado);

            // exercício 10
            //Na linguagem C#, a geração de números aleatórios é realizada através da classe Random, que oferece métodos para gerar números inteiros e reais de maneira aleatória.

            //Exemplo
            //Random rand = new Random();
            //int numeroAleatorio = rand.Next(1, 101);







        }
    }
}




