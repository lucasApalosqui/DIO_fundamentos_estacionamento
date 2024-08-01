using DioFundamentosEstacionamento.Models;
using DioFundamentosEstacionamento.Utils;

namespace DioFundamentosEstacionamento.MenuScreens
{
    public static class MenuPrincipal
    {
        public static void Load(Estacionamento estacionamento)
        {
            Console.Clear();
            MenuWrite.OptionGen(new List<string> { "Cadastrar Veiculo", "Remover Veiculo", "Listar Veiculos", "Encerrar"});

            try
            {
                Console.WriteLine("Selecione a opção:");
                var option = short.Parse(Console.ReadLine()!);
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Informe a placa do veiculo: ");
                        var placa = Console.ReadLine().ToUpper();
                        if (!PlacaDeVeiculoUtils.VerificarPlacaValida(placa))
                        {
                            Console.WriteLine("Placa inválida tente novamente");
                            Console.ReadKey();
                            Load(estacionamento);
                        }
                        Console.WriteLine("Informe o modelo do veiculo: ");
                        var modelo = Console.ReadLine();
                        if (modelo == null)
                        {
                            Console.WriteLine("Modelo inválido tente novamente");
                            Console.ReadKey();
                            Load(estacionamento);
                        }
                        estacionamento.AdicionarVeiculo(new Carro(placa, modelo));
                        Console.ReadKey();
                        Load(estacionamento);
                        break;

                    case 2:
                        Console.WriteLine("selecione a placa do veiculo que quer remover:");
                        string respostaPlaca = Console.ReadLine().ToUpper();
                        var veiculo = estacionamento.Veiculos.FirstOrDefault(x => x.Placa == respostaPlaca);

                        if (veiculo == null)
                        {
                            Console.WriteLine("Veiculo não encontrado tente novamente");
                            Console.ReadKey();
                            Load(estacionamento);
                        }
                        Console.WriteLine("Quantas horas o veiculo permaneceu estacionado?");
                        if(!int.TryParse(Console.ReadLine(), out var valor) ){
                            Console.WriteLine("Numero de horas inválido, tente novamente");
                            Console.ReadKey();
                            Load(estacionamento);
                        }

                        estacionamento.RemoverVeiculo(veiculo, valor);
                        Console.ReadKey();
                        Load(estacionamento);
                        break;

                    case 3:
                        estacionamento.ListarVeiculos();
                        Console.ReadKey();
                        Load(estacionamento);
                        break;

                    case 4:
                        Console.WriteLine("Finalizando sistema");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Opção inválida tente novamente");
                        Console.ReadKey();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Opção inválida tente novamente");
                Console.ReadKey();
                Load(estacionamento);
            }

        }
    }
}
