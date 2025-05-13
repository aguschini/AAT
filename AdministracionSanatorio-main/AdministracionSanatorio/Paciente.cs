using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionSanatorio
{
    class Paciente
    {
        public string DocumentoIdentidad { get; set; }
        public string NombreCompleto { get; set; }
        public string Telefono { get; set; }
        public string ObraSocial { get; set; }
        public decimal? MontoCobertura { get; set; }
        public List<Intervencion> Intervenciones { get; private set; } = new List<Intervencion>();

        public Paciente(string documentoIdentidad, string nombreCompleto, string telefono)
        {
            DocumentoIdentidad = documentoIdentidad;
            NombreCompleto = nombreCompleto;
            Telefono = telefono;
            ObraSocial = null;
            MontoCobertura = null;
        }

        public Paciente(string documentoIdentidad, string nombreCompleto, string telefono, string obraSocial, decimal montoCobertura) 
            :this(documentoIdentidad, nombreCompleto, telefono)  // ← Aquí está el magic
        {
            ObraSocial = obraSocial;
            MontoCobertura = montoCobertura;
        }
    }
}
