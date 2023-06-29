using System;

using Estacionamento.Models;
namespace SistemaEstacionamento
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Coloca o encoding para UTF8 para exibir acentuação
      Console.OutputEncoding = System.Text.Encoding.UTF8;

      decimal precoInicial = 0;
      decimal precoPorHora = 0;

      Console.WriteLine(@$"
        Seja bem vindo ao sistema de estacionamento!
        Digite o preço inicial:"
      );

      precoInicial = Convert.ToDecimal(Console.ReadLine());

      Console.WriteLine("Agora digite o preço por hora:");
      precoPorHora = Convert.ToDecimal(Console.ReadLine());

      var estacionamento = new Estacionamento.Models.Estacionamento(precoInicial, precoPorHora);

      string opcao = string.Empty;
      bool exibirMenu = true;

      while (exibirMenu)
      {
        Console.Clear();
        Console.WriteLine(@$"
          Digite a sua opcao:
            1 - Cadastrar veículo
            2 - Remover veículo
            3 - Listar veículo
            4 - Encerrar
        ");

        switch (Console.ReadLine())
        {
          case "1":
            estacionamento.AdicionarVeiculo();
            break;

          case "2":
            estacionamento.RemoverVeiculo();
            break;

          case "3":
            estacionamento.ListarVeiculos();
            break;

          case "4":
            estacionamento.FinalizarSistema();
            break;

          default:
            Console.WriteLine("Opção inválida!!!");
            break;
        }

        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
      }
      Console.WriteLine("O programa se encerrou");
    }
  }
}