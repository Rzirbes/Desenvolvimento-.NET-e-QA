// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using HospedagemHotel.Model;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("Rômulo", "Zirbes");
Pessoa p2 = new Pessoa("Anderson", "Rocha"); 

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite("Premiu", 2, 100.00M);

Reserva reserva = new Reserva(id: 1, diasReservados: 9);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor Total: {reserva.CalcularValorDiaria()}");


