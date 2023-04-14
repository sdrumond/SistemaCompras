using SistemaCompra.Domain.Core.Model;
using SistemaCompra.Domain.SolicitacaoCompraAggregate;
using System;
using System.Collections.Generic;

namespace SistemaCompra.Application.SolicitacaoCompra.Query.ObterSolicitacaoCompra
{
    public class ObterSolicitacaoCompraViewModel
    {
        public UsuarioSolicitante UsuarioSolicitante { get;  set; }
        public NomeFornecedor NomeFornecedor { get;  set; }
        public IList<Item> Itens { get;  set; }
        public DateTime Data { get;  set; }
        public Money TotalGeral { get;  set; }
        public Situacao Situacao { get;  set; }
    }
}
