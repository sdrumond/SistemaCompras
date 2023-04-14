﻿using SistemaCompra.Domain.SolicitacaoCompraAggregate;
using System;

namespace SistemaCompra.Domain.SolicitacaoCompraAggregate
{
    public interface ISolicitacaoCompraRepository
    {
        SolicitacaoCompra Obter(Guid id);
        void RegistrarCompra(SolicitacaoCompra solicitacaoCompra);
    }
}
