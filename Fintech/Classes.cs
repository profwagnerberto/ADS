namespace Fintech {
  
  class ContaCorrente{
    private int numero;
    // private string titular;
    public string Titular { get; private set; }
    protected double saldo;

    public ContaCorrente(){
    }

    public ContaCorrente(int numero, string titular){
      this.Numero = numero;
      this.Titular = titular;
    }

    public ContaCorrente(int numero, string titular, double valor) :this(numero, titular) {
      this.saldo = valor;
    }

    public void Depositar(double valor){
      this.saldo += valor;
    }

    public int Numero {
      set {
        if( value > 0 )
          this.numero = value;
      }

      get {
        return this.numero * 10;
      }
    }

    public double PegarSaldo(){
      return this.saldo;
    }

    public virtual void Sacar(double valor){
      if(this.PegarSaldo() >= valor)
        this.saldo -= valor;
    }

    public void Transferir(double valor, ContaCorrente contaDestino){
      this.Sacar(valor);
      contaDestino.Depositar(valor);
    }

  }

  class ContaPoupanca : ContaCorrente {

    public override void Sacar(double valor){
      if(this.PegarSaldo() >= valor + 1)
        this.saldo -= valor + 1;
    }

  }

}
