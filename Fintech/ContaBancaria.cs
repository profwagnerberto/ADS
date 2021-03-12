namespace Fintech{

  class ContaBancaria{
    private int numero;
    private string titular;
    private double saldo;

    public void Depositar(double valor){
      this.saldo += valor;
    }

    public double PegarSaldo(){
      return this.saldo;
    }

    public void Sacar(double valor){
      if(this.PegarSaldo() >= valor)
        this.saldo -= valor;
    }

    public void Transferir(double valor, ContaBancaria contaDestino){
      this.Sacar(valor);
      contaDestino.Depositar(valor);
    }

    public string Titular {
      get { return this.titular; }
      set {
        if ( !value.Equals("") )
          this.titular = value;
      }
    }

    public int Numero {
      get { return this.numero; }
      set {
        if ( value > 0 )
          this.numero = value;
      }
    }
  }

}