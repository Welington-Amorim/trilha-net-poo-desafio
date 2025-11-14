using System;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // iPhone instala via 'App Store' (simulação)
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"[{Modelo} - iPhone] Instalando '{nomeApp}' pela App Store...");
            // Simular processo
            Console.WriteLine($"[{Modelo} - iPhone] '{nomeApp}' instalado com sucesso.");
        }
    }
}
