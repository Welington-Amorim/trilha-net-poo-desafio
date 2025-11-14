using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teste Nokia
            Smartphone nokia = new Nokia("1199999-0000", "Nokia 3310", "111111111111111", 32);
            Console.WriteLine("Smartphone Nokia:");
            nokia.ExibirInfo();
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Snake");

            Console.WriteLine();

            // Teste iPhone
            Smartphone iphone = new Iphone("1198888-0000", "iPhone 11", "222222222222222", 128);
            Console.WriteLine("Smartphone iPhone:");
            iphone.ExibirInfo();
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("WhatsApp");

            Console.WriteLine();
            Console.WriteLine("Teste finalizado. Pressione ENTER para sair.");
            Console.ReadLine();
        }
    }
}
