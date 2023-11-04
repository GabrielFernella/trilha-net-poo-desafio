﻿using System; // Certifique-se de que o namespace System esteja incluído para o Console.WriteLine.
using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        var nokia = new Nokia("7666854", "Nokia 20", "IMEI123123312", 64);

        var iphone = new Iphone("332251", "iPhone 14", "IMEI123123314",0);

        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("TikTok");

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");
    }
}