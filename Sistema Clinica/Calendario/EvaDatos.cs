using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Clinica
{
    class EvaDatos
    {
        string evaluacion, laboratorios, receta;
        int id_consulta;

        public string Evaluacion { get => evaluacion; set => evaluacion = value; }
        public string Laboratorios { get => laboratorios; set => laboratorios = value; }
        public string Receta { get => receta; set => receta = value; }
        public int Id_consulta { get => id_consulta; set => id_consulta = value; }
    }
}
