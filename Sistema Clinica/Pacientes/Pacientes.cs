using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Clinica
{
    class Pacientes
    {
        int id, iduscrea, idusmod;
        string nombres, apellidos, DPI, sexo, telefono, celular, tipo_sangre, alergias, nacimiento;
        int estado;

        public int Id { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string DPI1 { get => DPI; set => DPI = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Tipo_sangre { get => tipo_sangre; set => tipo_sangre = value; }
        public string Alergias { get => alergias; set => alergias = value; }
        public string Nacimiento { get => nacimiento; set => nacimiento = value; }
        public int Iduscrea { get => iduscrea; set => iduscrea = value; }
        public int Idusmod { get => idusmod; set => idusmod = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
