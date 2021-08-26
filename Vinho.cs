public class Vinho : Produtos
{
  private string _Nome;
  private string _Tipo;
  private string _Fabricante;
  private string _Uva;
  
  public Vinho(string nome, string tipo, string fabricante, string uva, int idProduto): base(nome, idProduto)
  {
    this._Nome = nome;
    this._Tipo = tipo;
    this._Fabricante = fabricante;
    this._Uva = uva;
    
  }

  public string getNome()
  {
    return _Nome;
  } 

  public string getTipo()
  {
    return _Tipo;
  } 

  public string getFabricante()
  {
    return _Fabricante;
  } 

  public string getUva()
  {
    return _Uva;
  } 

}