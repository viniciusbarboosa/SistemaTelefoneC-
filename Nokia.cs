
using System;

public class Nokia : Smartphone
{
   
    public override void InstalarAplicativo()
    {
        Console.WriteLine("Instalando aplicativo na loja da Nokia...");
    }

    
    public override void Ligar(string numero)
    {
        Console.WriteLine($"Ligando para {numero} via Nokia.");
    }

    public override void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação no Nokia.");
    }
}
