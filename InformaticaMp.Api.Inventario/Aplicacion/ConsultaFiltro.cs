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
    public class ConsultaFiltro
    {
        public class PersonalMpUnico: IRequest<PersonalMp>
        {
            public string PersonalMpGuid { get; set; }
        }


           public class Manejador : IRequestHandler<PersonalMpUnico, PersonalMp>
            {

            private readonly ContextoPersonalMp _context;

            public Manejador(ContextoPersonalMp context)
            {
                _context = context;
            }
            public async Task<PersonalMp> Handle(PersonalMpUnico request, CancellationToken cancellationToken)
            {
                var personal = await _context.PersonalMp.Where(x => x.PersonalMpGuid == request.PersonalMpGuid).FirstOrDefaultAsync();

                if (personal == null)
                {
                    throw new Exception("No se encontro empleado");
                }

                return personal;

            }
        }
    }
}
