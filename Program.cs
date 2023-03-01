using estacionamento;

CarroServices _carroServices = new CarroServices();
TicketsServices _ticketServices = new TicketsServices();

string opcao;

do{
  Console.WriteLine("\n\nOlá bem vindo ao estacionamento Pare Aqui, Selecione a opção desejada:");
  Console.WriteLine("1 - Cadastrar Carro");
  Console.WriteLine("2 - Marcar Entrada");
  Console.WriteLine("3 - Marcar Saída");
  Console.WriteLine("4 - Consultar Histórico");
  Console.WriteLine("5 - Sair");
  opcao = Console.ReadLine();

  if(opcao == "1"){
    _carroServices.CadastrarCarro();
  }
  if(opcao == "2"){
    _ticketServices.GerarTicket();
  }
  if(opcao == "3"){
    _ticketServices.FecharTicket();
  }
  if(opcao == "4"){
    _ticketServices.Historico();
  }

}while (opcao != "5");
