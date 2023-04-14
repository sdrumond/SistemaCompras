using SolicitacaoAgg = SistemaCompra.Domain.SolicitacaoCompraAggregate;
using System;
using System.Linq;

namespace SistemaCompra.Infra.Data.SolicitacaoCompra
{
    public class SolicitacaoCompraRepository : SolicitacaoAgg.ISolicitacaoCompraRepository
    {
        private readonly SistemaCompraContext context;

        public SolicitacaoCompraRepository(SistemaCompraContext context)  {
            this.context = context;
        }

        public void RegistrarCompra(SolicitacaoAgg.SolicitacaoCompra solicitacao)
        {
            context.Set<SolicitacaoAgg.SolicitacaoCompra>().Add(solicitacao);
        }

        public SolicitacaoAgg.SolicitacaoCompra Obter(Guid id)
        {
            return context.Set<SolicitacaoAgg.SolicitacaoCompra>().Where(c => c.Id == id).FirstOrDefault();
        }
    }
}
