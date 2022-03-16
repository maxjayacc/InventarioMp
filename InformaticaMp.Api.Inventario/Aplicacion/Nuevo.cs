
using FluentValidation;
using InformaticaMp.Api.Inventario.Modelo;
using InformaticaMp.Api.Inventario.Persistencia;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InformaticaMp.Api.Inventario.Aplicacion
{
    public class Nuevo
    {
        public class Ejecutar : IRequest
        {
            public int PersonalMpId { get; set; }
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
            public string Cargo { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string Dni { get; set; }
            public string RegimenLaboral { get; set; }
            public string AreaDespacho { get; set; }
            public string DistritoFiscal { get; set; }
            public string Sede { get; set; }
            public string Local { get; set; }
            public string DespachoAnterior { get; set; }
            public string Correo { get; set; }
            public string Telefono { get; set; }
            public string Estado { get; set; }
            
        }


        public class EjecutaValidacion: AbstractValidator<Ejecutar>
        {
            public EjecutaValidacion()
            {
                RuleFor(x => x.Nombre).NotEmpty();
                RuleFor(x => x.Apellidos).NotEmpty();
            }
        }

        public class Manejador : IRequestHandler<Ejecutar>
        {
            public readonly ContextoPersonalMp _contexto;

            public Manejador(ContextoPersonalMp contexto)
            {
                _contexto = contexto;
            }
            public async Task<Unit> Handle(Ejecutar request, CancellationToken cancellationToken)
            {
                var personalMp = new PersonalMp
                {

                    Nombre = request.Nombre,
                    Apellidos = request.Apellidos,
                    Cargo = request.Cargo,
                    FechaNacimiento = request.FechaNacimiento,
                    Dni = request.Dni,
                    RegimenLaboral = request.RegimenLaboral,
                    AreaDespacho = request.AreaDespacho,
                    DistritoFiscal = request.DistritoFiscal,
                    Sede = request.Sede,
                    Local = request.Local,
                    DespachoAnterior = request.DespachoAnterior,
                    Correo = request.Correo,
                    Telefono = request.Telefono,
                    Estado = request.Estado,
                    PersonalMpGuid = Convert.ToString(Guid.NewGuid())
                };

                _contexto.PersonalMp.Add(personalMp);
                var valor =await _contexto.SaveChangesAsync();

                if (valor > 0)
                {
                    return Unit.Value;
                }
                throw new Exception("No se puedo insertar nuevo Personal");
               
            
            }
        }

    }
}
