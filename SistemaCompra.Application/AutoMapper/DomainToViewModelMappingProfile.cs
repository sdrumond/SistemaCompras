﻿using AutoMapper;
using SistemaCompra.Application.Produto.Query.ObterProduto;
using SistemaCompra.Application.SolicitacaoCompra.Query.ObterSolicitacaoCompra;
using ProdutoAgg = SistemaCompra.Domain.ProdutoAggregate;
using SolicitacaoCompraAgg = SistemaCompra.Domain.SolicitacaoCompraAggregate;

namespace SistemaCompra.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProdutoAgg.Produto, ObterProdutoViewModel>()
                .ForMember(d=> d.Preco, o=> o.MapFrom(src=> src.Preco.Value));

            CreateMap<SolicitacaoCompraAgg.SolicitacaoCompra, ObterSolicitacaoCompraViewModel>()
                .ForMember(d=> d.TotalGeral, o=> o.MapFrom(src=> src.TotalGeral.Value));
        }
    }
}
