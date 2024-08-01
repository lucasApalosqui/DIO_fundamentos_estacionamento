using DioFundamentosEstacionamento.Models;

namespace DioFundamentosEstacionamento.MenuScreens
{
    public static class MenuInicial
    {
        public static double ValorInicialLoad()
        {
            Console.Clear();
            Console.WriteLine("Seja bem vindo ao estacionamento");
            Console.WriteLine("Digite o preço inicial: ");
            var resposta = Console.ReadLine();
            if (!double.TryParse(resposta, out var valor))
                ValorInicialLoad();

            return valor;
        }

        public static double ValorHoraLoad()
        {
            Console.WriteLine("Digite o preço por hora: ");
            var resposta = Console.ReadLine();
            if (!double.TryParse(resposta, out var valor))
            {
                Console.Clear();
                ValorHoraLoad();
            }
            return valor;
        }
    }
}
