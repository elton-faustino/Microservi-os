using paramore.brighter.commandprocessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace join.Produtos.Core.Portas.Comandos
{
    public class RemoverProdutoComando : Command
    {
        public RemoverProdutoComando(int ProutoId)
            : base(new Guid())
        {
            this.ProutoId = ProutoId;
        }

        public int ProutoId { get; set; }

    }
}
