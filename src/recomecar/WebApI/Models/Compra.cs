recomecar WebApI.Models
{
            public class Compra
    {
        public int CompraId { get; set; }
        public DateTime DataCompra { get; set; }
        public decimal ValorTotal { get; set; }
        public bool PagamentoConfirmado { get; set; }

        // Relacionamento com Pagamentos
        public int PagamentoId { get; set; }
        public virtual Pagamento Pagamento { get; set; }

        // Relacionamento com Produtos
        public virtual ICollection<ProdutoCompra> Produtos { get; set; } 
    }
    

        public class ProdutoCompra
    {
        public int ProdutoCompraId { get; set; }
        public int Quantidade { get; set; }

        // Relacionamento com Produto
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }

        // Relacionamento com Compra
        public int CompraId { get; set; }
        public virtual Compra Compra { get; set; }
    }

}