using InformaticaMp.Api.Inventario.Aplicacion;
using InformaticaMp.Api.Inventario.Modelo;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformaticaMp.Api.Inventario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonalController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Crear(Nuevo.Ejecutar data)
        {
            return await _mediator.Send(data);
        }


        [HttpGet]
        public async Task<ActionResult<List<PersonalMp>>> GetPersonales()
        {
            return await _mediator.Send(new Consulta.ListaPersonalMp());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PersonalMp>> GetPersonalMp(string id)
        {
            return await _mediator.Send(new ConsultaFiltro.PersonalMpUnico { PersonalMpGuid = id });
        }
    }
}
