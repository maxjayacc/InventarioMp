using InformaticaMp.Api.Inventario.Modelo;
using InformaticaMp.Api.Inventario.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InformaticaMp.Api.Inventario.Aplicacion
{
    public class Consulta
    {

        public class ListaPersonalMp : IRequest<List<PersonalMp>>
        { }



        public class Manejador : IRequestHandler<ListaPersonalMp, List<PersonalMp>>
        {
            private readonly ContextoPersonalMp _contexto;
            public Manejador(ContextoPersonalMp contexto)
            {
                _contexto = contexto;
            }

            public async Task<List<PersonalMp>> Handle(ListaPersonalMp request, CancellationToken cancellationToken)
            {

              var personal = await  _contexto.PersonalMp.ToListAsync();

                return personal;

            }
        }

    }
}
