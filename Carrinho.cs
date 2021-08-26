public class Carrinho
{
  private int _Quantidade;
  private double _Total;
  private string _Pagamento;


  public Carrinho(int quantidade, double total, string pagamento)
  {
    this._Quantidade = quantidade;
    this._Total = total;
    this._Pagamento = pagamento;
  }

  public int getQuantidade()
  {
    return _Quantidade;
  }

  public double getTotal()
  {
    return _Total;
  }
  
  public string getPagamento()
  {
    return _Pagamento;
  }
}