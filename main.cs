using System;

class Program 
{
  static Produtos produto = new Produtos();
  public static void Main (string[] args)
  {
    IniciarCatalogo();
    foreach(Produtos produto in produto._ListaProdutos)
        {
            Console.WriteLine(produto.getNomeProduto());
        }
      
  }

  public static void IniciarCatalogo()
  {
    produto._ListaProdutos.Add(new Vinho("Portada","suave","DFJ Vinhos","UvaVerde",0));
    produto._ListaProdutos.Add(new Cerveja("Bohemia","Ambev", true,1));
  } 


      
}
