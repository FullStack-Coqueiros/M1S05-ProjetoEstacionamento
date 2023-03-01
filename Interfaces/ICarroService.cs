using estacionamento.Model;

namespace estacionamento.Interfaces
{
    public interface ICarroService
    {
        public void CadastrarCarro();
        public Carro ObterCarro(string placa);
    }
}