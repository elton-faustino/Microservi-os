using paramore.brighter.commandprocessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace join.Produtos.Core.Portas.Eventos
{
    public class ProdutosAdicionadosEvento : Event
    {
        public ProdutosAdicionadosEvento(string DescricaoProduto, string NomeProduto, double ProdutctPrice, int ProutoId)
            : base(new Guid())
        {
            this.DescricaoProduto = DescricaoProduto;
            this.NomeProduto = NomeProduto;
            this.ProdutctPrice = ProdutctPrice;
            this.ProutoId = ProutoId;
        }

        public string DescricaoProduto { get; set; }

        public int ProutoId { get; set; }

        public string NomeProduto { get; set; }

        public double ProdutctPrice { get; set; }
    }
}
