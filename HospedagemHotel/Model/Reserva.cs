using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospedagemHotel.Model;

public class Reserva
{
    public Reserva(int id, int diasReservados)
    {
        Id = id;
        DiasReservados = diasReservados;
    }

    public int Id { get; set; }
    public List<Pessoa>? Hospedes { get; set; }
    public Suite? Suite { get; set; }
    public int DiasReservados { get; set; }


    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        try
        {
            if (hospedes.Count <= Suite!.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Capacidade excedida");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        return Hospedes!.Count;
    }

    public decimal CalcularValorDiaria()
    {
        decimal valorTotal = DiasReservados * Suite!.ValorDiaria;

        if (DiasReservados >= 10)
        {
            decimal desconto = valorTotal * 0.1M;
            return valorTotal - desconto;
        }
        return DiasReservados * Suite.ValorDiaria;
    }

}