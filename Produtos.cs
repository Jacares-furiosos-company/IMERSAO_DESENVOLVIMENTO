using System.Collections.Generic;

public class Produtos
{
  private int id_produto;
  private string nome_produto;
  public List<Produtos> _ListaProdutos = new List<Produtos>();

    public Produtos()
    { }

    public Produtos(string nome, int idProduto)
    {
        this.id_produto = idProduto;
        this.nome_produto = nome;
    }
    public int getId_Produto()
    {
        return id_produto;
    }
    public string getNomeProduto()
    {
        return nome_produto;
    }

}