using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculadora_de_Bhaskara
{
    class Program
    {


        static void Main(string[] args)
        {
            bool resposta = true;
            string respostaescrita = "";

            while (resposta == true) 
                { 

            double A, B, C, delta, x1, x2 = 0;
            Console.WriteLine("Digite o numero correspondente ao A");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o numero correspondente ao B");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o numero correspondente ao C");
            C = Convert.ToDouble(Console.ReadLine());

            delta = (Math.Pow(B, 2)) - 4 * A * C;
            Console.WriteLine(delta);
                Console.Clear();
            if (delta < 0) {
                Console.WriteLine("Não foi possivel encontrar um valor real para a expressão, o delta é menor do que 0");
            }
            else if (delta > 0)
            {
                x1 = (-B + Math.Sqrt(delta)) / 2 * A;
                x2 = (-B - Math.Sqrt(delta)) / 2 * A;

                Console.Write("O valor para x1 é: ");
                Console.WriteLine(x1);
                Console.Write("O valor para x2 é: ");
                Console.WriteLine(x2);
                }
            else if (delta == 0)
            {
                x1 = (-B + delta) / 2 * A;
                Console.Write("O valor para x1 e x2 é: ");
                Console.WriteLine(x1);
            }
                Console.WriteLine("Gostaria de Calcular novamente? Digite Sim ou Não!");
                respostaescrita = Console.ReadLine();
                respostaescrita = respostaescrita.Trim();
                respostaescrita = respostaescrita.ToLower();

                
                if (respostaescrita == "sim")
                {
                    resposta = true;
                }
                else
                {
                    resposta = false;
                }
                Console.Clear();
               
            }
        }
    }
}
