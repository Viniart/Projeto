using ProjetoAPI.Model;

namespace ProjetoAPI.Repository
{
    public class ProdutoRepository
    {
        // Vetores
        // Lista - List
        List<Produto> listaProdutos = new()
        {
            new Produto()
            {
                Nome = "Produto 1",
                Categoria = "Categoria 1"
            },
            new Produto()
            {
                Nome = "Produto 2",
                Categoria = "Categoria 2"
            }
        };

        public List<Produto> ListarProdutos()
        {
            return listaProdutos;
        }

    }
}
