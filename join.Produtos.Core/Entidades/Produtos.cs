namespace join.Produtos.Core.Entidades
{
    public class Produto
    {

        public Produto()
        {

        }

        public Produto(string DescricaoProduto, string NomeProduto, double PrecoProduto)
        {
            this.DescricaoProduto = DescricaoProduto;
            this.NomeProduto = NomeProduto;
            this.PrecoProduto = PrecoProduto;
        }

        public string DescricaoProduto { get; set; }

        public int ProdutoId { get; set; }

        public string NomeProduto { get; set; }

        public double PrecoProduto { get; set; }

    }
}
