using System;

class MainClass {
  public static void Main (string[] args) {
    const int divisor = 10;
    var txtTmp = "";
    int Z,resto,quociente;

    Console.Clear();
    Console.Write("Informe o número Z*+ menor que 1000: ");
    txtTmp = Console.ReadLine();
    Z = int.Parse(txtTmp);

    resto = Z % divisor;
    quociente = Z / divisor;
    Console.WriteLine($"{resto} cédulas de 1 real.");

    Z = quociente;
    resto = Z % divisor;
    quociente = Z / divisor;
    Console.WriteLine($"{resto} cédulas de 10 reais.");

    Z = quociente;
    resto = Z % divisor;
    quociente = Z / divisor;
    Console.WriteLine($"{resto} cédulas de 100 reais.");
  }
}