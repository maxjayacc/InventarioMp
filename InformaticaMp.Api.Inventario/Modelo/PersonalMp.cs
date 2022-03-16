using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformaticaMp.Api.Inventario.Modelo
{
    public class PersonalMp
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
        public ICollection<BienInformatico> ListabienInformaticos { get; set; }
        public string PersonalMpGuid { get;set;}

    
    }

}
