using ProjetoHospedagemHotel.Models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("Denis", "Ribeiro");
Pessoa p2 = new Pessoa("João", "Fonseca");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipo: "Premium", capacidade: 3, valorDiaria:  30);

Reserva reserva = new Reserva(10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");