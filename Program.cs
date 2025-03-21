namespace calculadora.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //vetores
            string[] historicoOperacoes = new string[100];
            int contadorHistorico = 0;

            Console.WriteLine(historicoOperacoes[0]);

            // Loop de execução - estrutura de repetição

            while (true)
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Calculadora Bruna 2025");
                Console.WriteLine("----------------------------------------");


                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Tabuada");
                Console.WriteLine("6 - Histórico de Operações");
                Console.WriteLine("S - Sair");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("----------------------------------------");
                string opcao = Console.ReadLine();


                if (opcao == "S")
                    break; //quebra o loop = fecha o sistema


                else if (opcao == "5")
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Tabuada");
                    Console.WriteLine("----------------------------------------");

                    Console.Write("Digite o número desejado: ");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());

                    // 1 - contador = variavel de controle
                    // 2 - condição
                    // 3 - mecanismo de incrementação
                    for (int contador = 1; contador <= 10; contador++)

                    {
                        int multiplicacao = numeroTabuada * contador;
                        string linhaDaTabuada = numeroTabuada + " x " + contador + " = " + multiplicacao;

                        Console.WriteLine(linhaDaTabuada);
                    }

                    Console.ReadLine();
                    continue;

                }

                else if (opcao == "6")
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Histórico de Operações");
                    Console.WriteLine("----------------------------------------");

                    for (int contador = 0; contador < contadorHistorico; contador++)
                    {
                        Console.WriteLine(historicoOperacoes[contador]);
                    }

                    Console.ReadLine();
                    continue;

                }

                Console.WriteLine("----------------------------------------");
                Console.Write("Digite o primeiro número: ");

                //determinando uma variável

                decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine()); //convertendo string para int


                Console.Write("Digite o segundo número: ");

                decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

                decimal resultado = 0.0m;

                //estrutura de decisão

                if (opcao == "1") //se
                {
                    resultado = (primeiroNumero + segundoNumero);
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";

                }

                else if (opcao == "2") //se nao
                {
                    resultado = (primeiroNumero - segundoNumero);
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";

                }

                else if (opcao == "3")
                {
                    resultado = (primeiroNumero * segundoNumero);
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} * {segundoNumero} = {resultado}";

                }


                else if (opcao == "4")
                {
                    while (segundoNumero == 0)
                    {
                        Console.Write("Digite o segundo número novamente: ");
                        segundoNumero = Convert.ToDecimal(Console.ReadLine());
                    }

                    resultado = (primeiroNumero / segundoNumero);
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} / {segundoNumero} = {resultado}";

                }

                else
                    continue;

                contadorHistorico++;

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("O resultado da operação é: " + resultado.ToString("F2")); //lendo o valor da variável
                Console.WriteLine("----------------------------------------");
                Console.ReadLine();
            }
        }
    }
}