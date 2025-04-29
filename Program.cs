namespace Calculator
{
    class Program
    {
        static float[] valores = new float[2];
        static bool valoresLidos = false;

        static void Main(string[] args)
        {
            Console.Clear();
            Menu();
        }

        static void Menu()
        {
            while (true)
            {
                int opcao = ExibirOpcoes();

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        valores = LerValores();
                        break;
                    case 2:
                        Console.Clear();
                        if (!VerificarValores()) break;
                        Soma(valores[0], valores[1]);
                        ExibirOpcoesPosOperacao();
                        break;
                    case 3:
                        Console.Clear();
                        if (!VerificarValores()) break;
                        Subtracao(valores[0], valores[1]);
                        ExibirOpcoesPosOperacao();
                        break;
                    case 4:
                        Console.Clear();
                        if (!VerificarValores()) break;
                        Divisao(valores[0], valores[1]);
                        ExibirOpcoesPosOperacao();
                        break;
                    case 5:
                        Console.Clear();
                        if (!VerificarValores()) break;
                        Multiplicacao(valores[0], valores[1]);
                        ExibirOpcoesPosOperacao();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo da calculadora...");
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Algo inesperado aconteceu. Retornando ao menu...");
                        break;
                }
            }
        }

        static int ExibirOpcoes()
        {
            int opcao;
            while (true)
            {
                Console.WriteLine("Calculadora Simples");
                if (valoresLidos)
                {
                    Console.WriteLine($"Valores lidos: {valores[0]} e {valores[1]}");
                }
                else
                {
                    Console.WriteLine("Valores não lidos. Você precisa ler os valores primeiro.");
                }
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Ler valores");
                Console.WriteLine("2 - Soma");
                Console.WriteLine("3 - Subtração");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Multiplicação");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Digite o número da operação desejada:");
                if (int.TryParse(Console.ReadLine(), out opcao) && opcao >= 0 && opcao <= 5)
                {
                    return opcao;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida. Por favor, insira um número entre 0 e 5.");
                }
            }
        }

        static void ExibirOpcoesPosOperacao()
        {
            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Retornar ao menu");
                Console.WriteLine("0 - Sair da calculadora");

                int opcao;
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    if (opcao == 1)
                    {
                        Console.Clear();
                        return; // Retorna ao menu
                    }
                    else if (opcao == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Encerrando o programa...");
                        Environment.Exit(0); // Encerra o programa
                    }
                }

                Console.Clear();
                Console.WriteLine("Opção inválida. Por favor, escolha 1 ou 0.");
            }
        }

        static float[] LerValores()
        {
            float v1, v2;

            while (true)
            {
                Console.WriteLine("Primeiro valor: ");
                if (float.TryParse(Console.ReadLine(), out v1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                }
            }

            while (true)
            {
                Console.WriteLine("Segundo valor: ");
                if (float.TryParse(Console.ReadLine(), out v2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                }
            }

            valoresLidos = true;
            Console.Clear();

            return [v1, v2];
        }

        static bool VerificarValores()
        {
            if (!valoresLidos)
            {
                Console.WriteLine("Primeiro, você precisa ler os valores.");
                ExibirOpcoesPosOperacao(); // Permite ao usuário decidir o que fazer
                return false;
            }
            return true;
        }

        static void Soma(float v1, float v2)
        {
            Console.WriteLine($"O resultado da soma entre {v1} e {v2} é: {v1 + v2}");
        }

        static void Subtracao(float v1, float v2)
        {
            Console.WriteLine($"O resultado da subtração entre {v1} e {v2} é: {v1 - v2}");
        }

        static void Divisao(float v1, float v2)
        {
            if (v2 == 0)
            {
                Console.WriteLine("Divisão por zero não é permitida.");
            }
            else
            {
                Console.WriteLine($"O resultado da divisão entre {v1} e {v2} é: {v1 / v2}");
            }
        }

        static void Multiplicacao(float v1, float v2)
        {
            Console.WriteLine($"O resultado da multiplicação entre {v1} e {v2} é: {v1 * v2}");
        }
    }
}