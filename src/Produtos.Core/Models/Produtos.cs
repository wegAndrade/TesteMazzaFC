using Produtos.Core.Enums;
namespace Produtos.Core.Models
{
    public class Produtos :Entity
    {
        
        public string Nome { get; set; }
        public Categorias Categoria { get; set; }
        public decimal Preco { get; set; }

        public Produtos(string nome, Categorias categoria, decimal preco)
        {
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
        }



    }
}
