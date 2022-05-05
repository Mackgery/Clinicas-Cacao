using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Clinica
{
    class Usuarios
    {
        int id, estado;
        string nombres, apellidos, usuario, pass;
        string newpass, conpass;
        int indice;

        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Pass { get => pass; set => pass = value; }
        public int Id { get => id; set => id = value; }
        public int Estado { get => estado; set => estado = value; }
        public string Newpass { get => newpass; set => newpass = value; }
        public string Conpass { get => conpass; set => conpass = value; }
        public int Indice { get => indice; set => indice = value; }
    }
}
