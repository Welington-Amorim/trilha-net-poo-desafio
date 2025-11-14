using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // Nokia instala via 'Loja Android' (simulação)
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"[{Modelo} - Nokia] Instalando '{nomeApp}' pela Loja do Android...");
            // Simular processo
            Console.WriteLine($"[{Modelo} - Nokia] '{nomeApp}' instalado com sucesso.");
        }
    }
}
