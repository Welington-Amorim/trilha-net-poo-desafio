using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; private set; }
        public string Modelo { get; private set; }
        public string Imei { get; private set; }
        public int Memoria { get; private set; }

        protected Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine($"[{Modelo}] Ligando para {Numero}...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"[{Modelo}] Recebendo ligação...");
        }

        // Implementações diferentes dependendo do fabricante
        public abstract void InstalarAplicativo(string nomeApp);

        public void ExibirInfo()
        {
            Console.WriteLine("---- Informações do Smartphone ----");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"IMEI: {Imei}");
            Console.WriteLine($"Memória: {Memoria} MB");
            Console.WriteLine("-----------------------------------");
        }
    }
}
