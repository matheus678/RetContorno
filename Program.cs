using System;

namespace RetContorno
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            [console: RetContorno] Exiba o contorno de um retângulo, com altura e largura digitados pelo usuário (entre 1 e 10).
            Ex.:
            Tamanho do retângulo:
            Largura..: 10
            Altura...: 6
            **********
            *        *
            *        *
            *        *
            *        *
            **********
            */

            int largura;
            // valor que representara a largura do retângulo
            int altura;
            // valor que representara a altura do retângulo
            bool fim = false;

            while (!fim)
            {
                Console.Write("Insira a medida da largura do seu retângulo...");
                bool largurabool = Int32.TryParse(Console.ReadLine(), out largura);
                Console.Write("Insira a medida da altura do seu retângulo...");

                bool alturabool = Int32.TryParse(Console.ReadLine(), out altura);

                if (!largurabool || !alturabool)
                // || = ou/e
                {
                    Console.WriteLine("Número invalido.");
                    Console.WriteLine("Tente novamente,  digitando outro valor.");
                    Console.WriteLine();
                    Console.ReadKey();
                }
                else
                {
                    int valor = 1;
                    while (valor <= altura)
                    {

                        int valor2 = 1;
                        while (valor2 <= largura)
                        {
                            if (valor == 1 || valor2 == 1 || valor == altura || valor2 == largura)
                                Console.Write(". ");
                            else
                                Console.Write("  ");
                            valor2++;
                            // ++ = adicionador dos pontos ". "
                        }
                        
                        valor++;
                        // ++ = adicionador dos pontos ". "
                        Console.WriteLine();
                    }
                    fim = true;
                }
            }
        }
    }
}
