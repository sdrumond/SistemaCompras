using AutoMapper;
using MediatR;
using SistemaCompra.Domain.SolicitacaoCompraAggregate;
using System.Threading;
using System.Threading.Tasks;

namespace SistemaCompra.Application.SolicitacaoCompra.Query.ObterSolicitacaoCompra
{
    public class ObterSolicitacaoCompraQueryHandler : IRequestHandler<ObterSolicitacaoCompraQuery, ObterSolicitacaoCompraViewModel>
    {
        private readonly ISolicitacaoCompraRepository solicitacaoRepository;
        private readonly IMapper mapper;

        public ObterSolicitacaoCompraQueryHandler(ISolicitacaoCompraRepository solicitacaoRepository, IMapper mapper)
        {
            this.solicitacaoRepository = solicitacaoRepository;
            this.mapper = mapper;
        }
        public Task<ObterSolicitacaoCompraViewModel> Handle(ObterSolicitacaoCompraQuery request, CancellationToken cancellationToken)
        {
            var solicitacao = solicitacaoRepository.Obter(request.Id);
            var solicitacaoViewModel = mapper.Map<ObterSolicitacaoCompraViewModel>(solicitacao);

            return Task.FromResult(solicitacaoViewModel);
        }
    }
}
