using join.Produtos.Core.Entidades;
using join.Produtos.Core.Portas.Adapters;
using join.Produtos.Core.Portas.Comandos;
using join.Produtos.Core.Portas.Eventos;
using paramore.brighter.commandprocessor;
using paramore.brighter.commandprocessor.Logging;
using paramore.brighter.commandprocessor.policy.Attributes;
using System;

namespace join.Produtos.Core.Portas.Handler
{
    public class AdicionarProdutoCommandHandler : RequestHandler<AdicionarProdutoComando>
    {
        private readonly IProdutoDAO _produtoDAO;
        private readonly IAmACommandProcessor _commandProcessor;

        public AdicionarProdutoCommandHandler(IProdutoDAO _produtoDAO, IAmACommandProcessor _commandProcessor, ILog logger)
            : base(logger)
        {
            this._produtoDAO = _produtoDAO;
            this._commandProcessor = _commandProcessor;
        }

        [RequestLogging(step: 1, timing: HandlerTiming.Before)]
        [UsePolicy(CommandProcessor.RETRYPOLICY, step: 3)]
        public override AdicionarProdutoComando Handle(AdicionarProdutoComando command)
        {
            Produto produtoInserido;

            produtoInserido = _produtoDAO.Add(
                new Produto(command.DescricaoProduto, command.NomeProduto, command.ProdutctPrice)
                );

            command.ProutoId = produtoInserido.ProdutoId;

            if (produtoInserido != null)
                _commandProcessor.Publish(new ProdutosAdicionadosEvento(produtoInserido.DescricaoProduto, produtoInserido.NomeProduto, produtoInserido.PrecoProduto, produtoInserido.ProdutoId));

            return base.Handle(command);
        }

    }
}
