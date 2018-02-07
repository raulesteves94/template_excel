using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateNPOI
{
    public static class CatalogoProdutos
    {
        public static List<Produto> ObterCatalogo()
        {
            // Inicialização da coleção de objetos
            List<Produto> _Produtos = _Produtos = new List<Produto>();

            // Criação de produtos que serão vinculados
            // à coleção de objetos
            Produto produto;

            produto = new Produto();
            produto.CodigoBarras = "7890000000111";
            produto.NomeProduto = "Iron Maiden - Powerslave";
            produto.Categoria = "CDs";
            produto.DataCadastro = new DateTime(2012, 09, 19);
            produto.QtdEstoque = 37;
            produto.PrecoVenda = 44.90;
            _Produtos.Add(produto);

            produto = new Produto();
            produto.CodigoBarras = "7890000000222";
            produto.NomeProduto = "Metallica - Black Album";
            produto.Categoria = "CDs";
            produto.DataCadastro = new DateTime(2012, 09, 10);
            produto.QtdEstoque = 45;
            produto.PrecoVenda = 39.95;
            _Produtos.Add(produto);

            produto = new Produto();
            produto.CodigoBarras = "7890000000333";
            produto.NomeProduto = "Invictus";
            produto.Categoria = "DVDs";
            produto.DataCadastro = new DateTime(2012, 09, 03);
            produto.QtdEstoque = 7;
            produto.PrecoVenda = 16.90;
            _Produtos.Add(produto);

            produto = new Produto();
            produto.CodigoBarras = "7890000000444";
            produto.NomeProduto = "Uma Mente Brilhante";
            produto.Categoria = "DVDs";
            produto.DataCadastro = new DateTime(2012, 08, 20);
            produto.QtdEstoque = 18;
            produto.PrecoVenda = 29.90;
            _Produtos.Add(produto);

            produto = new Produto();
            produto.CodigoBarras = "7890000000555";
            produto.NomeProduto = "Trilogia Senhor dos Anéis";
            produto.Categoria = "Blu-Ray";
            produto.DataCadastro = new DateTime(2012, 08, 13);
            produto.QtdEstoque = 34;
            produto.PrecoVenda = 129.90;
            _Produtos.Add(produto);

            produto = new Produto();
            produto.CodigoBarras = "7890000000666";
            produto.NomeProduto = "Box Star Wars - 6 episódios";
            produto.Categoria = "Blu-Ray";
            produto.DataCadastro = new DateTime(2012, 08, 06);
            produto.QtdEstoque = 55;
            produto.PrecoVenda = 299.90;
            _Produtos.Add(produto);

            produto = new Produto();
            produto.CodigoBarras = "7890000000777";
            produto.NomeProduto = "A Arte da Guerra";
            produto.Categoria = "Livros";
            produto.DataCadastro = new DateTime(2012, 07, 27);
            produto.QtdEstoque = 10;
            produto.PrecoVenda = 10.00;
            _Produtos.Add(produto);

            produto = new Produto();
            produto.CodigoBarras = "7890000000888";
            produto.NomeProduto = "Transformando Suor em Ouro";
            produto.Categoria = "Livros";
            produto.DataCadastro = new DateTime(2012, 07, 20);
            produto.QtdEstoque = 17;
            produto.PrecoVenda = 24.90;
            _Produtos.Add(produto);

            // Devolve a coleção de objetos como resultado
            return _Produtos;
        }
    }
}