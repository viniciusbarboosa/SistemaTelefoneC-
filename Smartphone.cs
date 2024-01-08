using System;

public abstract class Smartphone
{
    public string Numero { get; set; }
    public string Modelo { get; set; }
    public string IMEI { get; set; }
    public int Memoria { get; set; }

    // Métodos
    public abstract void Ligar(string numero);
    public abstract void ReceberLigacao();
    public abstract void InstalarAplicativo();
}
