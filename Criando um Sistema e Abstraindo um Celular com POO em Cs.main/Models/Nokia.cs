using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemasParaCelulares.Models
{
  public class Nokia : Smartphone
  {
    /// <summary>
    /// Método construtor
    /// </summary>
    /// <param name="Numero"></param>
    /// <param name="Modelo"></param>
    /// <param name="IMEI"></param>
    /// <param name="Memoria"></param>
    public Nokia(
        string Numero,
        string Modelo,
        string IMEI,
        int Memoria
    ) : base(Numero, Modelo, IMEI, Memoria) { }

    #region Instalar Aplicativo
    /// <summary>
    /// Método para instalação de aplicativos no modelo Nokia
    /// </summary>
    /// <param name="NomeApp"></param>
    public override void InstalarAplicativo(string NomeApp)
    {
      Console.WriteLine($"instalando App {NomeApp} no número: {Numero}");
    }
    #endregion
  }
}