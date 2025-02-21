namespace ProjetoAPI.Model
{
    public class Produto
    {
        // Construtor - Define o que a classe tem que fazer quando for instanciada
        public Produto()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Categoria { get; set; }
    }
}
