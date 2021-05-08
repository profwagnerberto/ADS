using System;
using Fintech;

class MainClass {

  public static void Main (string[] args) {
    Console.Clear();
    ContaCorrente conta0 = new ContaCorrente(11, "Bruno", 100);
    // conta0.numero = 11;
    // conta0.titular = "Bruno";
    // conta0.saldo = 0;
    conta0.Numero = 12;
    // conta0.Titular = "Bruno teste";

    conta0.Sacar(15);
    Console.WriteLine("Titular: {0} | Saldo: {1,6:F2}\n",
     conta0.Titular, conta0.PegarSaldo());

    ContaCorrente conta1 = new ContaPoupanca();
    conta1.Numero = 22;
    conta1.Depositar(100);
    Console.WriteLine("Numero: {0} | Saldo: {1,6:F2}",
     conta1.Numero, conta1.PegarSaldo() );
    conta1.Sacar(15);
    Console.WriteLine("Numero: {0} | Saldo: {1,6:F2}",
     conta1.Numero, conta1.PegarSaldo() );

  }
}
