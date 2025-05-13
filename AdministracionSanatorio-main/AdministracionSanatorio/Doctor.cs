using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionSanatorio
{
    class Doctor
    {
        public string NombreCompleto { get; set; }
        public string Matricula { get; set; }
        public string Especialidad { get; set; }
        public bool Disponibilidad { get; set; }

        public Doctor(string nombrecompleto, string matricula, string especialidad, bool disponibilidad)
        {
            NombreCompleto = nombrecompleto;
            Matricula = matricula;
            Especialidad = especialidad;
            Disponibilidad = disponibilidad;
        }

        public override string ToString()
        {
            return $"{Nombre} - {Apellido} - (Matrícula: {Matricula}) - {Especialidad} - {(Disponibilidad ? "Disponible" : "No disponible")}";
        }
    }


}   
