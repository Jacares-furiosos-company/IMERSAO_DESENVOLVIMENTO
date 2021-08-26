using System;

public class Cerveja : Produtos
{
  private string _Nome;
  private string _Fabricante;
  private bool _Alcolica;

  public Cerveja(string nome, string fabricante, bool alcolica,  int idProduto): base(nome, idProduto)
  {
    this._Nome = nome;
    this._Fabricante = fabricante;
    this._Alcolica = alcolica;
  }

  public string getNome()
  {
    return _Nome;
  } 

  public string getFabricante()
  {
    return _Fabricante;
  } 

  public bool getAlcolica()
  {
    return _Alcolica;
  } 

}
