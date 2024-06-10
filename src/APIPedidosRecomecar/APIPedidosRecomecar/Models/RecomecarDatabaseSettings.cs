namespace APIPedidosRecomecar.Models
{
    public class RecomecarDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string PedidoCollectionName { get; set; } = null!;

        public string CarrinhoCompraCollectionName { get; set; } = null!;
    }
}
