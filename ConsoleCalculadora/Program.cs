using System;

namespace ConsoleCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0, val1=0, val2=0;
            Console.WriteLine("Pressione qualquer tecla para ligar a calculadora");
            Console.ReadKey();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("====== MENU ======");
                Console.WriteLine("==================");
                Console.WriteLine("[1] Somar");
                Console.WriteLine("[2] Subtrair");
                Console.WriteLine("[3] Multiplicar");
                Console.WriteLine("[4] Dividir");
                Console.WriteLine("[5] Desligar");
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                    if (opcao == 5) break;
                    if (opcao > 5)
                    {
                        Erros.Invalido();
                        continue;
                    }
                }
                catch
                {
                    Erros.Invalido();
                    continue;
                }


                Console.Clear();
                Console.WriteLine("Insira o 1º valor:");
                try { val1 = int.Parse(Console.ReadLine()); }
                catch 
                {
                    Erros.valorNumerico();
                    continue;
                }
                Console.WriteLine("Insira o 2º valor");
                try { val2 = int.Parse(Console.ReadLine()); }
                catch
                {
                    Erros.valorNumerico();
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        Somar(val1, val2);
                        break;

                    case 2:
                        Subtrair(val1, val2);
                        break;

                    case 3:
                        Multiplicar(val1, val2);
                        break;

                    case 4:
                        try
                        {
                            Dividir(val1, val2);
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e);
                            Console.ReadKey();
                        }
                        break;
                }
            }
        }

        public static void Somar(int n1, int n2)
        {
            Console.WriteLine($"\n{n1} + {n2} = {n1 + n2}");
            Console.ReadKey();
        }

        public static void Subtrair(int n1, int n2)
        {
            Console.WriteLine($"\n{n1} - {n2} = {n1 - n2}");
            Console.ReadKey();
        }

        public static void Multiplicar(int n1, int n2)
        {
            Console.WriteLine($"\n{n1} x {n2} = {n1 * n2}");
            Console.ReadKey();
        }

        public static void Dividir(float n1, float n2)
        {
            if (DivisorZero(n2)) throw new Exception("Error: não é possível realizar este cálculo!");

            Console.WriteLine($"\n{n1} ÷ {n2} = {n1 / n2}");

            bool DivisorZero(float a)
            {
                if (a <= 0) return true;
                return false;
            }

            Console.ReadKey();
        }

        class Erros
        {
            public static void Invalido()
            {
                Console.WriteLine("Opção inválida! Digite novamente.");
                Console.ReadKey();
            }

            public static void valorNumerico()
            {
                Console.WriteLine("ERRO: digite um número para que o programe funcione");
                Console.ReadKey();
            }
        }
    }
}
