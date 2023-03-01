
namespace estacionamento
{
  public class TicketsServices
  {
    private CarroServices _carroServices = new CarroServices();
    public void GerarTicket()
    {
      Console.WriteLine("Qual a placa do Veículo");
      string placa = Console.ReadLine();

      var carro = _carroServices.ObterCarro(placa);
      if (carro == null)
      {
        Console.WriteLine("Carro não cadastrado");
        return;
      }

      foreach (var ticket in carro.Tickets)
      {
        if (ticket.Ativo == true)
        {
          Console.WriteLine("Veiculo já esta no estacionamento");
          return;
        }
      }

      Ticket ticketNovo = new Ticket();
      carro.Tickets.Add(ticketNovo);
      Console.WriteLine("Ticket Gerado!");
    }


    public void FecharTicket()
    {
      Console.WriteLine("Qual a placa do Veículo");
      string placa = Console.ReadLine();

      var carro = _carroServices.ObterCarro(placa);
      if (carro == null)
      {
        Console.WriteLine("Carro não cadastrado");
        return;
      }

      Ticket ticketAberto = null;
      foreach (var ticket in carro.Tickets)
      {
        if (ticket.Ativo == true)
        {
          ticketAberto = ticket;
        }
      }
      if (ticketAberto == null)
      {
        Console.WriteLine("Não Há tickets em aberto para o veiculo");
        return;
      }

      ticketAberto.FecharTicket();
    }

    public void Historico()
    {
      Console.WriteLine("Qual a placa do Veículo");
      string placa = Console.ReadLine();

      var carro = _carroServices.ObterCarro(placa);
      if (carro == null)
      {
        Console.WriteLine("Carro não cadastrado");
        return;
      }

      Console.WriteLine("Entrada              |Saída                 |Ativo   | Valor ");

      foreach (var ticket in carro.Tickets)
      {
        if (ticket.Ativo == true)
        {
          Console.WriteLine($"{ticket.Entrada} | -------------------- | {ticket.Ativo.ToString()} | R$--,--");
        }
        else
        {
          Console.WriteLine($"{ticket.Entrada} | {ticket.Saida} | {ticket.Ativo.ToString()} | R${ticket.CalcularValor()}");
        }
      }
    }
  }
}