using System;


        Nokia nokia = new Nokia();
        nokia.Numero = "123456789";
        nokia.Modelo = "Nokia 3310";
        nokia.IMEI = "123456789012345";
        nokia.Memoria = 16;

        nokia.Ligar("987654321");
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo();

        Console.WriteLine();

        IPhone iPhone = new IPhone();
        iPhone.Numero = "987654321";
        iPhone.Modelo = "iPhone 12";
        iPhone.IMEI = "987654321098765";
        iPhone.Memoria = 128;

        iPhone.Ligar("123456789");
        iPhone.ReceberLigacao();
        iPhone.InstalarAplicativo();