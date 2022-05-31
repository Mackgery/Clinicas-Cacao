using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Clinica
{
    class Consprueba
    {
        int id, idpac, uscrea, usmod;
        string nombre_prov, estado, fecha_crea, hora, motivo, fecha_sig;
        string nompac;
        int id_cons;
        string apellido;
        int codigo;

        public int Id { get => id; set => id = value; }
        public int Idpac { get => idpac; set => idpac = value; }
        public int Uscrea { get => uscrea; set => uscrea = value; }
        public int Usmod { get => usmod; set => usmod = value; }
        public string Nombre_prov { get => nombre_prov; set => nombre_prov = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Fecha_crea { get => fecha_crea; set => fecha_crea = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public string Fecha_sig { get => fecha_sig; set => fecha_sig = value; }
        public string Nompac { get => nompac; set => nompac = value; }
        public int Id_cons { get => id_cons; set => id_cons = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Codigo { get => codigo; set => codigo = value; }
    }
}
