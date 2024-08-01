using DioFundamentosEstacionamento.MenuScreens;
using DioFundamentosEstacionamento.Models;

Estacionamento estacionamento = new Estacionamento();
double valorInicial = MenuInicial.ValorInicialLoad();
double valorHora = MenuInicial.ValorHoraLoad();

estacionamento.PrecoHora = valorHora;
estacionamento.PrecoInicial = valorInicial;

MenuPrincipal.Load(estacionamento);



