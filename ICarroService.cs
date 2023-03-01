

namespace estacionamento
{
    public interface ICarroService
    {
        public void CadastrarCarro();
        public Carro ObterCarro(string placa);
    }
}