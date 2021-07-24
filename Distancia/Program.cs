using System;

class Desafio {
    static void Main() {
        Console.WriteLine("Informe a distância entre a moto Y e a moto X:");
        int quilometros = Int32.Parse(Console.ReadLine());
        int minutos = quilometros * 2; // Digite aqui o calculo dos minutos
        Console.WriteLine(minutos + " minutos");
    }
}
