namespace DesafioEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        public List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.Write("Digite a placa do veículo para estaciona: ");
            string placaVeiculo = Console.ReadLine();
            veiculos.Add(placaVeiculo);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
            Console.WriteLine("Veiculo adicionado com Sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.Write("Digite a placa do veículo para Remover: ");
            string placaVeiculo = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placaVeiculo.ToUpper()))
            {
                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placaVeiculo);

                Console.WriteLine($"O veículo {placaVeiculo} foi removido e o preço total foi de: R$ {valorTotal}" );
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não encontrado. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if(veiculos.Any())
            {
                Console.WriteLine($"Os veículos estacionados são:");
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não ha veículos estacionados.");
            }
        }
    }
}