namespace Diamante_De_Letras_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Diamante de Letras V1.0 | Academia de Programação 2024!\n");

                while (true)
                {
                    char[] alfabetoArray;
                    int indexDoArray;
                    dadosDoDiamante(out alfabetoArray, out indexDoArray);

                    if (desejaContinuar("Deseja continuar? (S / N)")) break;
                }
            }


            static bool desejaContinuar(string texto)
            {
                Console.WriteLine(texto);
                string decisao = Console.ReadLine().ToUpper();
                Console.Clear();
                return decisao == "N";
            }

            static tipo obterValor<tipo>(string texto)
            {
                Console.WriteLine(texto);

                string input = Console.ReadLine().ToUpper();
                try
                {
                    return (tipo)Convert.ChangeType(input, typeof(tipo));
                }
                catch
                {
                    Console.WriteLine("Formato inválido!");
                    return obterValor<tipo>(texto);
                }
            }


            static void dadosDoDiamante(out char[] alfabetoArray, out int indexDoArray)
            {
                string letra = obterValor<string>("Digite uma letra para criar o diamante: "); 
                string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                alfabetoArray = alfabeto.ToCharArray(0, alfabeto.Length);
                indexDoArray = alfabeto.IndexOf(letra);
                
                construtorDoDiamante(alfabetoArray, indexDoArray);

            }

            static void construtorDoDiamante(char[] alfabetoArray, int indexDoArray)
            {

                #region Topo do diamante de letras
                for (int i = 0; i <= indexDoArray; i++) 
                {
                    for (int j = 0; j < indexDoArray - i; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(alfabetoArray[i]);
                    if (i > 0)
                    {
                        for (int j = 0; j < 2 * i - 1; j++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(alfabetoArray[i]);

                    }
                    Console.WriteLine();
                }
                #endregion

                #region Base do diamante de letras
                for (int i = indexDoArray - 1; i >= 0; i--)
                {
                    for (int j = 0; j < indexDoArray - i; j++)
                    {
                        Console.Write(" ");

                    }
                    Console.Write(alfabetoArray[i]);

                    if (i > 0)
                    {
                        for (int j = 0; j < 2 * i - 1; j++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(alfabetoArray[i]);
                    }
                    Console.WriteLine();
                }
                #endregion
            }
        }
    }
}