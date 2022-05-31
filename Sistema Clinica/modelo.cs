using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Clinica
{
    class modelo
    {
        public int registro(Usuarios usuario)
        {
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            string sql = "INSERT INTO usuario (nombres, apellidos, usuario, pass, fecha_crea, estado) VALUES (@nombres, @apellidos, @usuario, @pass, CURRENT_TIMESTAMP(), 1)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombres", usuario.Nombres);
            comando.Parameters.AddWithValue("@apellidos", usuario.Apellidos);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@pass", usuario.Pass);

            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public int eliminar(Usuarios usuario)
        {
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            string sql = "UPDATE usuario SET estado = 0 WHERE usuario = @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@estado", usuario.Estado);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public int actualizar(Usuarios usuario)
        {
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            string sql = "UPDATE usuario SET nombres = @nombres, apellidos = @apellidos, usuario = @usuario WHERE id_usuario = @idusuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombres", usuario.Nombres);
            comando.Parameters.AddWithValue("@apellidos", usuario.Apellidos);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@idusuario", usuario.Id);

            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }
        public int actualizartotal(Usuarios usuario)
        {
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            string sql = "UPDATE usuario SET nombres = @nombres, apellidos = @apellidos, usuario = @usuario, pass = @newpass WHERE id_usuario = @idusuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombres", usuario.Nombres);
            comando.Parameters.AddWithValue("@apellidos", usuario.Apellidos);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@idusuario", usuario.Id);
            comando.Parameters.AddWithValue("@newpass", usuario.Newpass);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }


        public int actualizarcontra(Usuarios usuario)
        {
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            string sql = "UPDATE usuario SET pass = @newpass WHERE usuario = @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@newpass", usuario.Newpass);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);

            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public bool existeUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();

            string sql = "SELECT ID_usuario FROM usuario where usuario = @usuario and estado= 1";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool existeUsuarioac(int usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            string sql = "SELECT usuario FROM usuario where ID_usuario = @idusuario and estado= 1";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idusuario", usuario);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool validacontra(string usuario, string pass)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            string sql = "SELECT ID_usuario FROM usuario where usuario = @usuario and pass = @pass";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@pass", pass);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public Usuarios PorUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();

            string sql = "SELECT ID_usuario, usuario, pass FROM usuario where usuario LIKE @usuario";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            Usuarios usr = null;

            while (reader.Read())
            {
                usr = new Usuarios();
                usr.Id = int.Parse(reader["ID_usuario"].ToString());
                usr.Usuario = reader["usuario"].ToString();
                usr.Pass = reader["pass"].ToString();
            }
            return usr;
        }
        public int registrasigno(Signos signo)
        {
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            string sql = "INSERT INTO signos (ID_sign, valor1, valor2, fecha_hora, observacion, ID_consulta) VALUES(@id_sign, @valor1, @valor2, CURRENT_TIMESTAMP(), @observacion, @idcons)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@id_sign", signo.Id_signo);
            comando.Parameters.AddWithValue("@valor1", signo.Valor1);
            comando.Parameters.AddWithValue("@valor2", signo.Valor2);
            comando.Parameters.AddWithValue("@observacion", signo.Observacion);
            comando.Parameters.AddWithValue("@idcons", signo.Id_consulta);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public int Actualizarsigno(Signos signo)
        {
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            string sql = "UPDATE signos SET  valor1 = @valor1, valor2 = @valor2, observacion = @observacion WHERE id_signos = @idsign";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@valor1", signo.Valor1);
            comando.Parameters.AddWithValue("@valor2", signo.Valor2);
            comando.Parameters.AddWithValue("@observacion", signo.Observacion);
            comando.Parameters.AddWithValue("@idsign", signo.Id_signos);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public bool existePaciente(string nombres, string apellidos)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            string sql = "SELECT ID_paciente FROM paciente where nombres = @nombres and apellidos = @apellidos";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombres", nombres);
            comando.Parameters.AddWithValue("@apellidos", apellidos);
            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool existePacienteac(int paciente)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            string sql = "SELECT ID_paciente FROM paciente where ID_paciente = @idpaciente and estado= 1";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idpaciente", paciente);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int registroPaciente(Pacientes paciente)
        {
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            string sql = "INSERT INTO paciente (nombres, apellidos, DPI, fecha_nacimiento, sexo, telefono, celular, tipo_sangre, alergias, Usuario_crea, estado, codigo) VALUES (@nombres, @apellidos, @DPI, @fecha_nacimiento, @sexo, @telefono, @celular, @tipo_sangre, @alergias, @Usuario_crea, 1, @codigo)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombres", paciente.Nombres);
            comando.Parameters.AddWithValue("@apellidos", paciente.Apellidos);
            comando.Parameters.AddWithValue("@DPI", paciente.DPI1);
            comando.Parameters.AddWithValue("@fecha_nacimiento", paciente.Nacimiento);
            comando.Parameters.AddWithValue("@sexo", paciente.Sexo);
            comando.Parameters.AddWithValue("@telefono", paciente.Telefono);
            comando.Parameters.AddWithValue("@celular", paciente.Celular);
            comando.Parameters.AddWithValue("@tipo_sangre", paciente.Tipo_sangre);
            comando.Parameters.AddWithValue("@alergias", paciente.Alergias);
            comando.Parameters.AddWithValue("@usuario_crea", paciente.Iduscrea);
            comando.Parameters.AddWithValue("@codigo", paciente.Codigo);


            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public int actualizarPaciente(Pacientes paciente)
        {
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            string sql = "UPDATE paciente SET nombres = @nombres, apellidos = @apellidos, DPI = @DPI, fecha_nacimiento = @fecha_nacimiento, sexo = @sexo, telefono = @telefono, celular = @celular, tipo_sangre = @tipo_sangre, alergias = @alergias, usuario_modifica = @idusmod WHERE id_paciente = @idpaciente";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombres", paciente.Nombres);
            comando.Parameters.AddWithValue("@apellidos", paciente.Apellidos);
            comando.Parameters.AddWithValue("@DPI", paciente.DPI1);
            comando.Parameters.AddWithValue("@fecha_nacimiento", paciente.Nacimiento);
            comando.Parameters.AddWithValue("@sexo", paciente.Sexo);
            comando.Parameters.AddWithValue("@telefono", paciente.Telefono);
            comando.Parameters.AddWithValue("@celular", paciente.Celular);
            comando.Parameters.AddWithValue("@tipo_sangre", paciente.Tipo_sangre);
            comando.Parameters.AddWithValue("@alergias", paciente.Alergias);
            comando.Parameters.AddWithValue("@idpaciente", paciente.Id);
            comando.Parameters.AddWithValue("@idusmod", paciente.Idusmod);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }
        public int eliminarpaciente(Pacientes paciente)
        {
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            string sql = "UPDATE paciente SET estado = 0 WHERE nombres = @nombres AND apellidos = @apellidos";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombres", paciente.Nombres);
            comando.Parameters.AddWithValue("@apellidos", paciente.Apellidos);
            comando.Parameters.AddWithValue("@estado", paciente.Estado);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public bool existeConsulta(string fecha, string hora)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            string sql = "SELECT ID_consulta FROM consulta where fecha_sig = @fechasig and hora = @hora";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@fechasig", fecha);
            comando.Parameters.AddWithValue("@hora", hora);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool existeConsultaact(string fecha, string hora, int idcons)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            string sql = "SELECT ID_consulta FROM consulta where fecha_sig = @fechasig and hora = @hora AND id_consulta != @idcons AND estadov = 1";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@fechasig", fecha);
            comando.Parameters.AddWithValue("@hora", hora);
            comando.Parameters.AddWithValue("@idcons", idcons);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool duplicaDPI(string dpi, int idpaciente)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            string sql = "SELECT id_paciente FROM paciente WHERE DPI = @DPI AND id_paciente != @idpac ";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@DPI", dpi);
            comando.Parameters.AddWithValue("@idpac", idpaciente);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int registroconsulta(Consulta consulta)
        {
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            string sql = "INSERT INTO consulta (ID_paciente, nombre_provisional, fecha_crea, motivo, fecha_sig, hora, estado, Usuario_creador, estadov) VALUES (@Idpac, @nomprov, CURRENT_TIMESTAMP(), @motivo, @fecha_sig, @hora, @estado, @uscrea, 1)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idpac", consulta.Idpac);
            comando.Parameters.AddWithValue("@nomprov", consulta.Nombre_prov);
            comando.Parameters.AddWithValue("@motivo", consulta.Motivo);
            comando.Parameters.AddWithValue("@fecha_sig", consulta.Fecha_sig);
            comando.Parameters.AddWithValue("@hora", consulta.Hora);
            comando.Parameters.AddWithValue("@estado", consulta.Estado);
            comando.Parameters.AddWithValue("@uscrea", consulta.Uscrea);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public int registroconsultaprov(Consulta consulta)
        {
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            string sql = "INSERT INTO consulta (nombre_provisional, fecha_crea, motivo, fecha_sig, hora, estado, Usuario_creador, estadov) VALUES (@nomprov, CURRENT_TIMESTAMP(), @motivo, @fecha_sig, @hora, @estado, @uscrea, 1)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nomprov", consulta.Nombre_prov);
            comando.Parameters.AddWithValue("@motivo", consulta.Motivo);
            comando.Parameters.AddWithValue("@fecha_sig", consulta.Fecha_sig);
            comando.Parameters.AddWithValue("@hora", consulta.Hora);
            comando.Parameters.AddWithValue("@estado", consulta.Estado);
            comando.Parameters.AddWithValue("@uscrea", consulta.Uscrea);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public int actualizarconsulta(Consulta consulta)
        {
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            string sql = "UPDATE consulta SET ID_paciente = @Idpac, nombre_provisional = @nomprov, motivo = @motivo , fecha_sig =  @fecha_sig, hora = @hora, estado = @estado, Usuario_modifica = @usmod WHERE id_consulta = @idcons";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idpac", consulta.Idpac);
            comando.Parameters.AddWithValue("@nomprov", consulta.Nombre_prov);
            comando.Parameters.AddWithValue("@motivo", consulta.Motivo);
            comando.Parameters.AddWithValue("@fecha_sig", consulta.Fecha_sig);
            comando.Parameters.AddWithValue("@hora", consulta.Hora);
            comando.Parameters.AddWithValue("@estado", consulta.Estado);
            comando.Parameters.AddWithValue("@usmod", consulta.Usmod);
            comando.Parameters.AddWithValue("@idcons", consulta.Id);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public int eliminarconsulta(Consulta consulta)
        {
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            string sql = "UPDATE consulta SET estadov = 0 WHERE id_consulta = @idcons";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idcons", consulta.Id);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }
        public int registroEvaluacion(EvaDatos evaluacion)
        {
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            string sql = "INSERT INTO evaluacion (ID_consulta, evaluacion, laboratorios, receta) VALUES (@idcons, @evaluacion, @laboratorios, @receta)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idcons", evaluacion.Id_consulta);
            comando.Parameters.AddWithValue("@evaluacion", evaluacion.Evaluacion);
            comando.Parameters.AddWithValue("@laboratorios", evaluacion.Laboratorios);
            comando.Parameters.AddWithValue("@receta", evaluacion.Receta);

            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public int ActualizarEvaluacion(EvaDatos evaluacion)
        {
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            string sql = "UPDATE evaluacion SET evaluacion = @evaluacion, laboratorios = @laboratorios, receta = @receta WHERE ID_consulta = @idcons";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idcons", evaluacion.Id_consulta);
            comando.Parameters.AddWithValue("@evaluacion", evaluacion.Evaluacion);
            comando.Parameters.AddWithValue("@laboratorios", evaluacion.Laboratorios);
            comando.Parameters.AddWithValue("@receta", evaluacion.Receta);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public bool existeEvaluacion(int ID_cons)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();

            string sql = "SELECT ID_eva, evaluacion, laboratorios, receta FROM evaluacion WHERE ID_consulta = @idcons";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idcons", ID_cons);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}