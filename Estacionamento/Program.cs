using System;
using Estacionamento.models;

EstacionamentoClass estacionamento = new EstacionamentoClass(capacidadeMaxima: 10, valorPorHora: 5); // Defina a capacidade máxima desejada.

while (true)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Adicionar carro");
    Console.WriteLine("2. Remover carro");
    Console.WriteLine("3. Listar carros estacionados");
    Console.WriteLine("4. Sair");

    Console.Write("Escolha uma opção: ");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Write("Digite a placa do veículo: ");
            string placa = Console.ReadLine();
            Console.Write("Digite o modelo do veículo: ");
            string modelo = Console.ReadLine();
            Veiculo novoVeiculo = new Veiculo(placa, modelo);
            estacionamento.EstacionarVeiculo(novoVeiculo);
            break;

        case "2":
            Console.Write("Digite a placa do veículo a ser removido: ");
                    string placaRemocao = Console.ReadLine();

                    Console.Write("Digite a quantidade de horas estacionadas: ");
                    if (double.TryParse(Console.ReadLine(), out double horasEstacionadas))
                    {
                        double valorPagar;
                        estacionamento.RetirarVeiculo(placaRemocao, horasEstacionadas, out valorPagar);
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido para as horas estacionadas.");
                    }
            break;

        case "3":
            estacionamento.ListarVeiculosEstacionados();
            break;

        case "4":
            Console.WriteLine("Saindo do programa.");
            return;

        default:
            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
            break;
    }
}
