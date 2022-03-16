using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformaticaMp.Api.Inventario.Modelo
{
    public class BienInformatico
    {
        public int BienInformaticoId { get; set; }
        public string CodigoPatrimonial { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public string Ip { get; set; }
        public string EstadoBien { get; set; }
        public string TipoBien { get; set; }
        public string Estado { get; set; }
        public string CodigoInventario { get; set; }
        public string Procesador { get; set; }
        public string MemoriaGB { get; set; }
        public string DiscoDuro { get; set; }
        public string FuncionEquipo { get; set; }
        public string TipoImpresion { get; set; }
        public string TipoSoftware { get; set; }
        public int PersonalMpId { get; set; }
        public PersonalMp PersonalMp { get; set;}
        public string BienInformaticoGuid { get; set; }

    }
}
