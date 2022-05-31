using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema_Clinica
{
    class Controlador
    {
        public string ctrlogin(string usuario, string pass)
        {
            modelo modelo = new modelo();
            string respuesta = "";
            Usuarios datosUsuario = null;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(pass))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                datosUsuario = modelo.PorUsuario(usuario);
                if (datosUsuario == null)
                {
                    respuesta = "Este usuario no existe";
                }
                else
                {
                    if (datosUsuario.Pass != generaSHA1(pass))
                    {
                        respuesta = "El usuario y/o contraseña es incorrecto";
                    }
                    else
                    {
                        Session.usuario = usuario;
                        Session.id_usuario = datosUsuario.Id;
                    }
                }
            }
            return respuesta;
        }

        public string ctrlregistro(Usuarios usuario)
        {
            modelo modelo = new modelo();
            string respuesta = "";
            if (string.IsNullOrEmpty(usuario.Nombres) || string.IsNullOrEmpty(usuario.Apellidos) || string.IsNullOrEmpty(usuario.Usuario) || string.IsNullOrEmpty(usuario.Pass))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                if (modelo.existeUsuario(usuario.Usuario))
                {
                    respuesta = "El usuario ya existe";
                }
                else
                {
                    usuario.Pass = generaSHA1(usuario.Pass);
                    modelo.registro(usuario);
                }
            }
            return respuesta;
        }

        public string ctrlnuevacontra(Usuarios usuario)
        {
            modelo modelo = new modelo();
            string respuesta = "";
            if (string.IsNullOrEmpty(usuario.Pass) || string.IsNullOrEmpty(usuario.Newpass) || string.IsNullOrEmpty(usuario.Conpass))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                if (modelo.validacontra(usuario.Usuario, generaSHA1(usuario.Pass)))
                {
                    if (usuario.Newpass == usuario.Pass)
                    {
                        respuesta = "No puede elegir la misma contraseña que la anterior";

                    }
                    else if (usuario.Conpass != usuario.Newpass)
                    {
                        respuesta = "Las contraseñas no coinciden";
                    }
                    else
                    {
                        usuario.Newpass = generaSHA1(usuario.Newpass);
                        modelo.actualizarcontra(usuario);
                    }
                }
                else
                {
                    respuesta = "Por favor verifique su contraseña actual";
                }
            }
            return respuesta;
        }

        public string ctrlacttodo(Usuarios usuario)
        {
            modelo modelo = new modelo();
            string respuesta = "";
                        usuario.Newpass = generaSHA1(usuario.Newpass);
                        modelo.actualizartotal(usuario);                
            return respuesta;
        }

        public string ctrlactualiza(Usuarios usuario)
        {
            modelo modelo = new modelo();
            string respuesta = "";
            if (string.IsNullOrEmpty(usuario.Nombres) || string.IsNullOrEmpty(usuario.Apellidos) || string.IsNullOrEmpty(usuario.Usuario))
            {
                respuesta = "Debe llenar todos los campos para actualizarlos";
            }
            else
            {
                if (modelo.existeUsuarioac(usuario.Id))
                {
                    modelo.actualizar(usuario);
                }
                else
                {

                    respuesta = "El usuario no existe, no es posible editar";
                }
            }
            return respuesta;
        }

        public string ctrlcomprueba(Usuarios usuario)
        {
            modelo modelo = new modelo();
            string respuesta = "";

            if (string.IsNullOrEmpty(usuario.Usuario))
            {
                respuesta = "Debe de indicar el usuario que desea eliminar";
            }
            else
            {
                if (modelo.existeUsuario(usuario.Usuario))
                {
                }
                else
                {
                    respuesta = "Este usuario no existe";
                }
            }

            return respuesta;
        }

        public string ctrlelimina(Usuarios usuario)
        {
            modelo modelo = new modelo();
            string respuesta = "";
            if (modelo.existeUsuario(usuario.Usuario))
            {
                modelo.eliminar(usuario);
            }
            else
            {
                respuesta = "Este usuario no existe";
            }
            return respuesta;
        }

        public List<object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<object> lista = new List<object>();

            string sql;

            if (dato == null)
            {
                sql = "SELECT ID_usuario, Nombres, Apellidos, Usuario FROM usuario WHERE estado = 1 ORDER BY Nombres ASC ";
            }
            else
            {
                sql = "SELECT ID_usuario, Nombres, Apellidos, Usuario FROM usuario WHERE estado = 1 AND Nombres LIKE '%" + dato + "%' OR estado = 1 AND Apellidos LIKE '%" + dato + "%' OR estado = 1 AND Usuario LIKE '%" + dato + "%'   ORDER BY Nombres ASC";
            }
            try
            {
                MySqlConnection conexion = Conexion.GetConnection();
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Usuarios usuario = new Usuarios();
                    usuario.Id = int.Parse(reader.GetString(0));
                    usuario.Nombres = reader[1].ToString();
                    usuario.Apellidos = reader[2].ToString();
                    usuario.Usuario = reader[3].ToString();
                    lista.Add(usuario);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }

        public List<object> consultapac(string dato)
        {
            MySqlDataReader reader;
            List<object> lista = new List<object>();

            string sql;

            if (dato == null)
            {
                sql = "SELECT ID_paciente, nombres, apellidos, DPI, sexo, telefono, celular, tipo_sangre, alergias, fecha_nacimiento, codigo FROM paciente WHERE Estado = 1 ORDER BY nombres ASC ";
            }
            else
            {
                sql = "SELECT ID_paciente, nombres, apellidos, DPI, sexo, telefono, celular, tipo_sangre, alergias, fecha_nacimiento, codigo FROM paciente WHERE estado = 1 AND nombres LIKE '%" + dato + "%' OR estado = 1 AND apellidos LIKE '%" + dato + "%' OR estado = 1 AND sexo LIKE '%" + dato + "%' AND estado = 1 ORDER BY Nombres ASC";

            }
            try
            {
                MySqlConnection conexion = Conexion.GetConnection();
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Pacientes paciente = new Pacientes();
                    paciente.Id = int.Parse(reader.GetString(0));
                    paciente.Nombres = reader[1].ToString();
                    paciente.Apellidos = reader[2].ToString();
                    paciente.DPI1 = reader[3].ToString();
                    paciente.Sexo = reader[4].ToString();
                    paciente.Telefono = reader[5].ToString();
                    paciente.Celular = reader[6].ToString();
                    paciente.Tipo_sangre = reader[7].ToString();
                    paciente.Alergias = reader[8].ToString();
                    paciente.Nacimiento = reader[9].ToString();
                    if (reader[10] != DBNull.Value)
                    {
                        paciente.Codigo = int.Parse(reader[10].ToString());
                    }
                    lista.Add(paciente);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }

        public List<object> consultasignos(string dato)
        {
            MySqlDataReader reader;
            List<object> lista = new List<object>();

            string sql;

            if (dato == null)
            {
                sql = "SELECT ID_sign, estado, nombre, descripcion, medida, estadodesc FROM catalogo_signos ORDER BY nombre ASC";
            }
            else
            {
                sql = "SELECT ID_sign, estado, nombre, descripcion, medida, estadodesc FROM catalogo_signos WHERE nombre LIKE '%" + dato + "%'  ORDER BY nombre ASC";
            }
            try
            {
                MySqlConnection conexion = Conexion.GetConnection();
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Catalogo_signos cat_s = new Catalogo_signos();
                    cat_s.Id_sign = int.Parse(reader.GetString(0));
                    cat_s.Estado = int.Parse(reader.GetString(1));
                    cat_s.Nombre = reader[2].ToString();
                    cat_s.Descripcion = reader[3].ToString();
                    cat_s.Medida = reader[4].ToString();
                    cat_s.Estadodes = reader[5].ToString();
                    lista.Add(cat_s);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }

        public List<object> consultas(string dato, string dato2)
        {
            MySqlDataReader reader;
            List<object> lista = new List<object>();
            string sql;
                sql = "SELECT c.`ID_consulta`, c.`ID_paciente`, c.`hora`, p.`nombres`, p.`apellidos`, c.nombre_provisional, p.`codigo`, c.`motivo`, c.`estado`,  c.`fecha_sig` FROM consulta c INNER JOIN paciente p ON c.`ID_paciente` = p.`ID_paciente`  WHERE fecha_sig = '" + dato + "' AND estadov = 1 AND c.estado = '"+ dato2 + "' ORDER BY hora ASC";
            try
            {
                MySqlConnection conexion = Conexion.GetConnection();
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Consprueba cons = new Consprueba();
                    cons.Id = int.Parse(reader.GetString(0));
                    cons.Idpac = int.Parse(reader.GetString(1));
                    cons.Hora = reader[2].ToString();
                    cons.Nompac = reader[3].ToString();
                    cons.Apellido = reader[4].ToString();
                    cons.Nombre_prov = reader[5].ToString();
                    if(reader[6] != DBNull.Value)
                    {
                        cons.Codigo = int.Parse(reader.GetString(6));
                    }
                    else
                    {
                    }
                    cons.Motivo = reader[7].ToString();
                    cons.Estado = reader[8].ToString();
                    cons.Fecha_sig = reader[9].ToString();
                    lista.Add(cons);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }

        public List<object> Signosconsulta(int ID_consulta)
        {
            MySqlDataReader reader;
            List<object> lista = new List<object>();

            string sql;
            sql = "SELECT  s.`ID_signos`, cs.`nombre`, s.`valor1`, s.`valor2`, s.`observacion`, s.`ID_consulta` FROM signos AS s INNER JOIN catalogo_signos cs ON cs.`ID_sign` = s.`ID_sign` WHERE s.`ID_consulta` = '" + ID_consulta +"' ORDER BY cs.`nombre` ASC";
            try
            {
                MySqlConnection conexion = Conexion.GetConnection();
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Signos sign = new Signos();
                    sign.Id_signos = int.Parse(reader.GetString(0));
                    sign.Nombre = reader[1].ToString();
                    sign.Valor1 = reader[2].ToString();
                    sign.Valor2 = reader[3].ToString();
                    sign.Observacion = reader[4].ToString();
                    sign.Id_consulta = int.Parse(reader.GetString(5));
                    lista.Add(sign);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }

        public string ctrlsignos(Signos signo)
        {
            modelo modelo = new modelo();
            string respuesta = "";
            if (string.IsNullOrEmpty(signo.Valor1))
            {
                respuesta = "Debe de indicar al menos 1 valor";
            }
            else
            {
                modelo.registrasigno(signo);
            }
            return respuesta;
        }

        public string ctrlregistroPaciente(Pacientes paciente)
        {
            modelo modelo = new modelo();
            string respuesta = "";
            if (string.IsNullOrEmpty(paciente.Nombres) || string.IsNullOrEmpty(paciente.Apellidos) || string.IsNullOrEmpty(paciente.Nacimiento))
            {
                respuesta = "Debe indicar al menos: Nombres, Apellidos y fecha de Nacimiento del paciente";
            }
            else
            {
                if (modelo.existePaciente(paciente.Nombres, paciente.Apellidos))
                {
                    respuesta = "El paciente ya existe";
                }
                else
                {
                    modelo.registroPaciente(paciente);
                }
            }
            return respuesta;
        }

        public string ctrlactualizapaciente(Pacientes paciente)
        {
            modelo modelo = new modelo();
            string respuesta = "";
            if (string.IsNullOrEmpty(paciente.Nombres) || string.IsNullOrEmpty(paciente.Apellidos) || string.IsNullOrEmpty(paciente.Nacimiento))
            {
                respuesta = "Debe llenar los campos con '*' para continuar";
            }
            else
            {
                if(modelo.duplicaDPI(paciente.DPI1, paciente.Id))
                {
                    respuesta = "Ese DPI ya existe para otro paciente";
                }
                else
                {
                if (modelo.existePacienteac(paciente.Id))
                {
                    modelo.actualizarPaciente(paciente);
                }
                else
                {
                    respuesta = "Seleccione un paciente existente por favor";
                }

                }
            }
            return respuesta;
        }

        public string ctrlcompruebapaciente(Pacientes paciente)
        {
            modelo modelo = new modelo();
            string respuesta = "";
            if (string.IsNullOrEmpty(paciente.Nombres))
            {
                respuesta = "Debe de indicar el Paciente que desea eliminar";
            }
            else
            {
                if (modelo.existePaciente(paciente.Nombres, paciente.Apellidos))
                {
                }
                else
                {
                    respuesta = "Este Paciente no existe";
                }
            }

            return respuesta;
        }


        public string ctrleliminapac(Pacientes paciente)
        {
            modelo modelo = new modelo();
            string respuesta = "";
            if (modelo.existePaciente(paciente.Nombres, paciente.Apellidos))
            {
                modelo.eliminarpaciente(paciente);
            }
            else
            {
                respuesta = "Este paciente no existe";
            }
            return respuesta;
        }

        public string ctrlregistroconsulta(Consulta consulta)
        {
            modelo modelo = new modelo();
            string respuesta = "";
            if ((string.IsNullOrEmpty(consulta.Nombre_prov) && string.IsNullOrEmpty(consulta.Nompac.ToString())) || string.IsNullOrEmpty(consulta.Motivo))
            {
                respuesta = "Por favor incluya un paciente y un motivo para continuar";
            }
            else
            {
                if (modelo.existeConsulta(consulta.Fecha_sig, consulta.Hora))
                {
                    respuesta = "Ya existe una consulta para esta fecha y esta hora";
                }
                else
                {
                  
                        modelo.registroconsulta(consulta);
                }
            }
            return respuesta;
        }

        public string ctrlractualizaconsulta(Consulta consulta)
        {
            modelo modelo = new modelo();
            string respuesta = "";
            if ((string.IsNullOrEmpty(consulta.Nombre_prov) && string.IsNullOrEmpty(consulta.Id.ToString())) || string.IsNullOrEmpty(consulta.Motivo))
            {
                respuesta = "Recuerde no dejar vacio el campo de Motivo";
            }
            else
            {
                if (modelo.existeConsultaact(consulta.Fecha_sig, consulta.Hora, consulta.Id))
                {
                    respuesta = "Ya existe una consulta para esta fecha y esta hora";
                }
                else
                {
                    modelo.actualizarconsulta(consulta);
                }
            }
            return respuesta;
        }
        public string ctrleliminaconsulta(Consulta consulta)
        {
            modelo modelo = new modelo();
            string respuesta = "";
                modelo.eliminarconsulta(consulta);
                respuesta = "Consulta eliminada exitosamente";
            return respuesta;
        }

        public string ctrlractualizasigno (Signos signo)
        {
            modelo modelo = new modelo();
            string respuesta = "";
            if (string.IsNullOrEmpty(signo.Valor1))
            {
                respuesta = "Debe de indicar al menos 1 valor";
            }
            else
            {
                modelo.Actualizarsigno(signo);
            }
            return respuesta;
        }

        public string ctrlregistroEvaluacion(EvaDatos evaluacion)
        {
            modelo modelo = new modelo();
            string respuesta = "";
            if (string.IsNullOrEmpty(evaluacion.Evaluacion))
            {
                respuesta = "Por favor indique una evaluación ";
            }
            else
            {

                modelo.registroEvaluacion(evaluacion);
                
            }
            return respuesta;
        }

        public string ctrlactualizaEvaluacion(EvaDatos evaluacion)
        {
            modelo modelo = new modelo();
            string respuesta = "";
            if (string.IsNullOrEmpty(evaluacion.Evaluacion))
            {
                respuesta = "Por favor indique una evaluación";
            }
            else
            {
                modelo.ActualizarEvaluacion(evaluacion);
            }
            return respuesta;
        }

        private string generaSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString();
        }


    }
}
