using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Clinica
{
    class Catalogo_signos
    {
        int id_sign, estado;
        string nombre, descripcion, medida;
        int cambio;
        string estadodes;


        public int Id_sign { get => id_sign; set => id_sign = value; }
        public int Estado { get => estado; set => estado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Medida { get => medida; set => medida = value; }
        public int Cambio { get => cambio; set => cambio = value; }
        public string Estadodes { get => estadodes; set => estadodes = value; }
    }
}
