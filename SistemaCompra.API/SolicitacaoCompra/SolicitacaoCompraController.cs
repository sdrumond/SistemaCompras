using MediatR;
using Microsoft.AspNetCore.Mvc;
using SistemaCompra.Application.SolicitacaoCompra.Command.RegistrarCompra;
using SistemaCompra.Application.SolicitacaoCompra.Query.ObterSolicitacaoCompra;
using System;

namespace SistemaCompra.API.SolicitacaoCompra
{
    public class SolicitacaoCompraController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SolicitacaoCompraController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet, Route("SolicitacaoCompra/{id}")]
        public IActionResult Obter(Guid id)
        {
            var query = new ObterSolicitacaoCompraQuery() { Id = id };
            var SolicitacaoCompraViewModel = _mediator.Send(query);
            return Ok(SolicitacaoCompraViewModel);
        }

        [HttpPost, Route("SolicitacaoCompra/cadastro")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult CadastrarSolicitacaoCompra([FromBody] RegistrarCompraCommand registrarSolicitacaoCompraCommand)
        {
            _mediator.Send(registrarSolicitacaoCompraCommand);
            return StatusCode(201);
        }
    }
}
