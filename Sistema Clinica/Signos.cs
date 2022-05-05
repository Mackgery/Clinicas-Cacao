using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Clinica
{
    class Signos
    {
        int id_signos, id_signo;
        string valor1, valor2;
        string observacion;

        public int Id_signos { get => id_signos; set => id_signos = value; }
        public int Id_signo { get => id_signo; set => id_signo = value; }
        public string Valor1 { get => valor1; set => valor1 = value; }
        public string Valor2 { get => valor2; set => valor2 = value; }
        public string Observacion { get => observacion; set => observacion = value; }
    }
}
