
namespace estacionamento
{
    public class CarroServices : ICarroService
    {
        static List<Carro> carros = new List<Carro>();
        public void CadastrarCarro(){
            Carro carro = new Carro();
            Console.WriteLine("Digite a placa");
            carro.Placa = Console.ReadLine();
            Console.WriteLine("Digite a Modelo");
            carro.Modelo = Console.ReadLine();
            Console.WriteLine("Digite a Cor");
            carro.Cor = Console.ReadLine();
            Console.WriteLine("Digite a Marca");
            carro.Marca = Console.ReadLine();
            carros.Add(carro);
        }

        public Carro ObterCarro(string placa){
            foreach(var carro in carros){
                if (placa == carro.Placa){
                return carro;
                }
            }
            return null;
        }

    }
}