using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionSanatorio
{
    class IntervencionQuirurgica
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Especialidad { get; set; }
        public int Arancel { get; set; }

        public Intervencion(string codigo, string desc, string especialidad, int arancel)
        {
            Codigo = codigo;
            Descripcion = desc;
            Especialidad = especialidad;
            Arancel = aracel;
        }
    }


        class IntervencionPaciente
    {
        public string ID { get; set; }
        public DateTime Fecha { get; set; }
        public IntervencionQuirurgica Intervencion { get; set; }
        public Doctor Doc { get; set; }
        public string DNI { get; set; }

        public IntervencionPaciente(string id, Paciente paciente, Doctor doc)
        {
            if (Doc.Especialidad != especializacion)
                throw new InvalidOperationException("El médico no tiene la especialidad requerida");

            if(DNI )

            ID = id;
            Fecha = (DateTime.Now + 7);
            Doctor = doc;
            Paciente = paciente;
            
        }
    }


}
