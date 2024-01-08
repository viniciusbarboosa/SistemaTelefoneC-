using System;


public class IPhone : Smartphone
{
    
    public override void InstalarAplicativo()
    {
        Console.WriteLine("Instalando aplicativo na App Store da Apple...");
    }

    
    public override void Ligar(string numero)
    {
        Console.WriteLine($"Ligando para {numero} via iPhone.");
    }

    public override void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação no iPhone.");
    }
}