using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Instancia que vai gerar valores randomicos
            //Random random = new Random();
            //// Lista de inteiros que vai receber os valores randomicos
            //List<int> listaSelecionados = new List<int>();

            //Console.Write("Digite o número de repetições desejado: ");

            //// A variavel repeticoes vai receber o valor que for escrito no console e se a conversão do parse for feita com sucesso
            //if (int.TryParse(Console.ReadLine(), out int repeticoes))
            //{
            //    // loop com a quantidade de vezes que o usuario quer
            //    for (int i = 0; i < repeticoes; i++)
            //    {
            //        // randomNext vai gerar numeros no maximo até o valor que solicitou de repeticoes
            //        int randomNumber = random.Next(repeticoes);
            //        // Adiciona o valor gerado na lista
            //        listaSelecionados.Add(randomNumber);
            //    }

            //    // Impressão de todos os valores gerados
            //    Console.Write((listaSelecionados));
            //    Console.Write("\n");

            //    // loop pela quantidade de elementos da lista que é igual a de repeticoes
            //    for (int i = 0; i < listaSelecionados.Count; i++)
            //    {
            //        // Quantidade de elementos repetido de acordo com o index da lista
            //        int valoresRepetidos = listaSelecionados.Count(x => x == i);
            //        // Definições da string final
            //        string resultadoTexto = valoresRepetidos == 1 ? "vez" : "vezes";
            //        // Mensagem concatenada por interpolarização
            //        Console.WriteLine($"{i} ocorre {valoresRepetidos} {resultadoTexto}");
            //    }
            //}

            // Instancia que vai gerar valores randomicos
            Random random = new Random();
            // Lista de inteiros que vai receber os valores randomicos
            List<int> listaSelecionados = new List<int>();

            Console.Write("Digite o número de repetições desejado: ");

            // A variavel repeticoes vai receber o valor que for escrito no console e se a conversão do parse for feita com sucesso
            if (int.TryParse(Console.ReadLine(), out int repeticoes))
            {
                // loop com a quantidade de vezes que o usuario quer
                for (int i = 0; i < repeticoes; i++)
                {
                    // randomNext vai gerar numeros no maximo até o valor que solicitou de repeticoes
                    int randomNumber = random.Next(repeticoes);
                    // Adiciona o valor gerado na lista
                    listaSelecionados.Add(randomNumber);
                }

                listaSelecionados.ForEach(x => Console.Write(x + " "));
                Console.Write("\n");

                // loop pela uqantidade de elementos da lista que é igual a de repeticoes
                for (int i = 0; i < listaSelecionados.Count; i++)
                {
                    // Quantidade de elementos repetido de acordo com o index da lista
                    int value = listaSelecionados.Count(x => x == i);                                  
                    // Definições da string final
                    string result = value == 1 ? "vez" : "vezes";
                    
                    
                    if (value >= 1)
                    {
                        // Mensagem concatenada por interpolarização
                        Console.WriteLine($"{i} ocorre {value} {result}");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
