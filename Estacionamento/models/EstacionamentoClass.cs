using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento.models
{
    public class EstacionamentoClass
    {
        private List<Veiculo> veiculosEstacionados;
        private int capacidadeMaxima;
        private double valorPorHora;

    public EstacionamentoClass(int capacidadeMaxima, double valorPorHora)
    {
        this.capacidadeMaxima = capacidadeMaxima;
        this.valorPorHora = valorPorHora;
        veiculosEstacionados = new List<Veiculo>();
    }

    public bool EstacionarVeiculo(Veiculo veiculo)
    {
        if (veiculosEstacionados.Count < capacidadeMaxima)
        {
            veiculosEstacionados.Add(veiculo);
            Console.WriteLine($"O veículo {veiculo.Modelo} com placa {veiculo.Placa} foi estacionado.");
            return true;
        }
        else
        {
            Console.WriteLine("O estacionamento está lotado. Não é possível estacionar o veículo.");
            return false;
        }
    }

    public bool RetirarVeiculo(string placa, double horasEstacionadas, out double valorPagar)
    {
         Veiculo veiculo = veiculosEstacionados.Find(v => v.Placa == placa);
        if (veiculo != null)
        {
            veiculosEstacionados.Remove(veiculo);
            valorPagar = horasEstacionadas * valorPorHora;
            Console.WriteLine($"O veículo {veiculo.Modelo} com placa {veiculo.Placa} foi retirado do estacionamento.");
            Console.WriteLine($"Valor a pagar: R${valorPagar}");
            return true;
        }
        else
        {
            Console.WriteLine("Veículo não encontrado no estacionamento.");
            valorPagar = 0;
            return false;
        }
    }

    public void ListarVeiculosEstacionados()
    {
        Console.WriteLine("Veículos estacionados:");
            Console.WriteLine("=================================================");
        foreach (var veiculo in veiculosEstacionados)
        {
            Console.WriteLine($"Placa: {veiculo.Placa}, Modelo: {veiculo.Modelo}");
        }
            Console.WriteLine("=================================================");
    }
    }
}