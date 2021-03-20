using System;

namespace VelocMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcule a velocidade, a partir da distância (Δd, em metros) e do tempo (Δt, em segundos).

           // v = Δd / Δt

            //Distância percorrida (m): 100
            //Tempo gasto (s): 15

            //Velocidade média: 6 m/s
            Console.Clear();
            double doubleS;
            double doubleMinutos;
            double doubleKm;
            double doubleMetros;
            double doubleV;
            int intD;
            int intT;
            int intV;
            int intNum;
            Console.WriteLine("« «  Velocidade - MEDIA » »");
            Console.WriteLine("■■■■■■■■■■▄▄▄▄▄▄■■■■■■■■■■■");
            Console.WriteLine("Escolha a opção:\n 1. Distancia percorrida em km\n 2. Distancia em metros");
            Console.WriteLine("Escolha uam OPÇÃO: ");
            intNum = Convert.ToInt32( Console.ReadLine());
            if (intNum < 1 ^ intNum > 2)
            {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Opção invalida"); 
            Console.ResetColor();
            }
            if (intNum == 1)
            {
            Console.Write("Quantos quilometros você percorreu? ");
            doubleKm = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi os eu tempo em minutos? ");
            doubleMinutos = Convert.ToDouble(Console.ReadLine());
            doubleMetros = doubleKm * 1000;
            doubleS = doubleMinutos * 60;
            doubleV = doubleMetros / doubleS;
            //doubleV = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine($" Você percorreu {doubleKm} km\n Em {doubleMinutos} Minutos\n O equivalente a distancia {doubleMetros} m\n E os minutos equivalentea {doubleS} s\n Em uma velocidade média de {doubleV:N2} m/s ");
            }
            if (intNum == 2)
            {
            Console.Write("Quantos metros você percorreu? ");
            intD = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantos segundos gastou para percorrer essa distancia? ");
            intT = Convert.ToInt32(Console.ReadLine());
            intV = intD / intT;
            Console.WriteLine($"Distancia percorrida: {intD} m\nTempo gasto: {intT} s\nVelocidade média: {intV} m/s");
            }
        }
    }
}
