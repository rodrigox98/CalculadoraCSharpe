using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool on = false;
            do
            {
                string ligar, off;
                int valor;
                Console.WriteLine("Calculadora desligada. Ligue a calculadora, digite  - Ligar: ");
                ligar = Console.ReadLine();
                if (ligar == "Ligar")
                {

                    do
                    {
                        int x1, x2, resultado;

                        Console.WriteLine("Bem vindo novamente a calculadora ");
                        Console.WriteLine("Digite o valor o primeiro numero");
                        x1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor o segundo numero ");
                        x2 = int.Parse(Console.ReadLine());


                        Console.WriteLine("Digite o valor para operação " +
                        "1 para somar \n 2 para subtrair \n 3 para multiplicar \n 4 para dividir");

                        valor = int.Parse(Console.ReadLine());
                        switch (valor)
                        {
                            case 1:
                                Console.WriteLine("O resultado é " + Somar(x1, x2));
                                break;

                            case 2:
                                Console.WriteLine("O resultado é " + Subtracao(x1, x2));
                                break;
                            case 3:
                                Console.WriteLine("O resultado é " + Multiplicar(x1, x2));
                                break;
                            case 4:
                                try
                                {
                                    resultado = Dividir(x1, x2);
                                    Console.WriteLine($"O valor do resultado da divisão é {resultado}");
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine($"ERRO {e}");
                                }
                                break;
                            default:
                                Console.WriteLine("Operação inválida");
                                break;
                        }
                        Console.WriteLine("Digite -Desligar-  para desligar a calculadora ou qualquer valor para continuar ");
                        off = Console.ReadLine();

                    } while (off != "Desligar");
                }
            } while (on == false);





            static int Somar(int n1, int n2)
            {
                return n1 + n2;
            }
            static int Subtracao(int n1, int n2)
            {
                return n1 - n2;
            }
            static int Multiplicar(int n1, int n2)
            {
                return n1 * n2;
            }


            static int Dividir(int n1, int n2)
            {

                if (DiferenteDeZero(n2)) throw new Exception("Divisor não pode ser 0!");

                return n1 / n2;

                bool DiferenteDeZero(int n2)
                {
                    if (n2 == 0) return true;

                    return false;
                }
            }
        }
    }
}


