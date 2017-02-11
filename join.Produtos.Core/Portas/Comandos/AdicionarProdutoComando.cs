using paramore.brighter.commandprocessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace join.Produtos.Core.Portas.Comandos
{
    public class AdicionarProdutoComando : Command
    {
        public AdicionarProdutoComando(string DescricaoProduto, string NomeProduto, double ProdutctPrice)
            : base(Guid.NewGuid())
        {
            this.DescricaoProduto = DescricaoProduto;
            this.NomeProduto = NomeProduto;
            this.ProdutctPrice = ProdutctPrice;
        }

        public string DescricaoProduto { get; set; }

        public int ProutoId { get; set; }

        public string NomeProduto { get; set; }

        public double ProdutctPrice { get; set; }
    }
}
