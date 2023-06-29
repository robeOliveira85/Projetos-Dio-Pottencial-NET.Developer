using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemasParaCelulares.Models
{
  public abstract class Smartphone
  {
    public string Numero { get; set; }
    private string Modelo { get; set; }
    private string IMEI { get; set; }
    private int Memoria { get; set; }


    /// <summary>
    /// Método construtor
    /// </summary>
    /// <param name="Numero"></param>
    /// <param name="Modelo"></param>
    /// <param name="IMEI"></param>
    /// <param name="Memoria"></param>
    public Smartphone(
        string Numero,
        string Modelo,
        string IMEI,
        int Memoria
    )
    {
      this.Numero = Numero;
      this.Modelo = Modelo;
      this.IMEI = IMEI;
      this.Memoria = Memoria;
    }

    #region Ligar
    /// <summary>
    /// Método que realiza a ligação
    /// </summary>
    public void Ligar()
    {
      Console.WriteLine($"Ligando para ... {Numero}");
    }
    #endregion

    #region Receber ligação
    /// <summary>
    /// Método que recebe a ligação
    /// </summary>
    public void ReceberLigacao()
    {
      Console.WriteLine($"Recebendo ligação de  ... {Numero}");
    }
    #endregion

    #region Instalar Aplicativo
    /// <summary>
    /// Método modelo para instalação do aplicativo
    /// </summary>
    /// <param name="NomeApp"></param>
    public abstract void InstalarAplicativo(string NomeApp);
    #endregion

  }
}