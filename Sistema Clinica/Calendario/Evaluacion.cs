using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Clinica
{
    public class Evaluacion
    {
        public static string motivo;
        public static string nombre;
        public static string apellidos;
        public static string nombreprov;
        public static string fechanac;
        public static string alergias;
        public static string tiposan;
        public static int codigo;

        public static string Nombre { get => nombre; set => nombre = value; }
        public static string Apellidos { get => apellidos; set => apellidos = value; }
        public static string Nombreprov { get => nombreprov; set => nombreprov = value; }
        public static string Fechanac { get => fechanac; set => fechanac = value; }
        public static string Alergias { get => alergias; set => alergias = value; }
        public static string Tiposan { get => tiposan; set => tiposan = value; }
        public static string Motivo { get => motivo; set => motivo = value; }
    }
}
