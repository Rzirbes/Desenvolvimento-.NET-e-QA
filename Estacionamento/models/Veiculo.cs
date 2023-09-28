using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento.models;

public class Veiculo
{
     public string Placa { get; set; }
    public string Modelo { get; set; }

    public Veiculo(string placa, string modelo)
    {
        Placa = placa;
        Modelo = modelo;
    }
}