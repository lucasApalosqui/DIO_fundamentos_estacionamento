namespace DioFundamentosEstacionamento.Models
{
    public class Estacionamento
    {
        public Estacionamento(double precoInicial, double precoHora)
        {
            PrecoInicial = precoInicial;
            PrecoHora = precoHora;
        }

        public Estacionamento() { }

        public List<Veiculo> Veiculos { get; set; } = new List<Veiculo>();
        public double PrecoInicial { get; set; }
        public double PrecoHora { get; set; }


        public void ListarVeiculos()
        {
            if (Veiculos.Count == 0)
                Console.WriteLine("Ainda não existem veiculos estacionados");
            else
            {
                foreach (var veiculo in Veiculos)
                {
                    Console.WriteLine($"Modelo: {veiculo.Modelo} / Placa {veiculo.Placa}");
                }
            }
            
        }

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            Veiculos.Add(veiculo);
            Console.WriteLine($" Veiculo com Modelo: {veiculo.Modelo} / Placa {veiculo.Placa} / adicionado com sucesso!");
        }

        public void RemoverVeiculo(Veiculo veiculo, int horas)
        {
            Veiculos.Remove(veiculo);
            Console.WriteLine($" Veiculo com Modelo: {veiculo.Modelo} / Placa {veiculo.Placa} / removido com sucesso!");
            Console.WriteLine($"Valor total foi de R$ {PrecoInicial + (PrecoHora * horas)}");
        }

    }
}
