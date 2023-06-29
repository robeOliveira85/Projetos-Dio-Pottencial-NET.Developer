using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
  public class Estacionamento
  {
    private decimal precoInicial = 0;
    private decimal precoPorHora = 0;
    private List<string> veiculos = new List<string>();

    /// <summary>
    ///   Os parâmetros para calcular as horas declarado no constructor
    /// </summary>
    /// <param name="precoInicial"></param>
    /// <param name="precoPorHora"></param>
    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
      this.precoInicial = precoInicial;
      this.precoPorHora = precoPorHora;
    }

    /// <summary>
    ///   Recebe uma placa digitada pelo usuário e guarda na variável veículos
    /// </summary>
    public void AdicionarVeiculo()
    {
      Console.WriteLine("Digite a placa do veículo para estacionar: ");
      string placa = Console.ReadLine();

      veiculos.Add(placa);

      Console.WriteLine($"Carro com placa: {placa} cadastrado com sucesso.");
    }

    /// <summary>
    ///   Verificar se um determnado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento
    ///   <c>Calculo = precoInicial * precoPorHora</c>
    /// </summary>
    public void RemoverVeiculo()
    {
      Console.WriteLine("Digite a placa do veículo para remover: ");

      string placa = Console.ReadLine();

      if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
      {
        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
        int horas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(horas);
        decimal valorTotal = (precoInicial + precoPorHora) * horas;

        veiculos.Remove(placa);

        Console.WriteLine(@$"
          O veículo de placa: {placa} foi removido com sucesso.
          Preço total foi de : R${valorTotal}
          "
        );
      }
      else
      {
        Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
      }

    }

    /// <summary>
    ///   Lista todos os veículos presentes atualmente no estacionamento
    /// </summary>
    public void ListarVeiculos()
    {
      if (veiculos.Any())
      {
        Console.WriteLine("Os veículos estacionados são: ");

        foreach (var placas in veiculos)
        {
          Console.WriteLine($"Carro: {placas}");
        }
      }
    }

    /// <summary>
    /// Encerra o sistema se a opção "encerrar" do menu for selecionada.
    /// </summary>
    public void FinalizarSistema()
    {
      Console.WriteLine("Encerrando Sistema.");
      Environment.Exit(0);
    }
  }
}