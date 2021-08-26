using System;

public class DadosCliente
{
  private int _ID;
  private string _Nome;
  private string _Telefone;
  private string _Endereco;
  private string _Cpf;

  public DadosCliente(int id, string nome, string telefone, string endereco, string cpf)
  {
    this._ID = id;
    this._Nome= nome;
    this._Telefone = telefone;
    this._Endereco = endereco;
    this._Cpf = cpf;
  }

  public string getNome()
  {
    return _Nome;
  } 

  public string getTelefone()
  {
    return _Telefone;
  } 
  
  public string getEndereco()
  {
    return _Endereco;
  }
  public string getCpf()
  {
    return _Cpf;
  }

}