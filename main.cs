using System;

class MainClass {
  public static void Main (string[] args) {
    double celsius,coeficiente,resultado;

    Console.Clear();
    Console.WriteLine("Conversão de temperatura Celsius para Kelvin");
    Console.WriteLine("============================================");
    Console.Write("\nDigite a temperatura em Celsius: ");
    celsius = double.Parse( Console.ReadLine() );

    coeficiente = 273.15;
    resultado = celsius + coeficiente;

    Console.WriteLine("\nTemperatura em Kelvin: " + resultado);

  }
}