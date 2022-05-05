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
                usr.Usuario= reader["usuario"].ToString();
                usr.Pass = reader["pass"].ToString();
            }
            return usr;
        }
        public int registrasigno(Signos signo)
        {
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            string sql = "INSERT INTO signos (ID_sign, valor1, valor2, fecha_hora, observacion, ID_consulta) VALUES(@id_sign, @valor1, @valor2, CURRENT_TIMESTAMP(), @observacion,1)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@id_sign", signo.Id_signo);
            comando.Parameters.AddWithValue("@valor1", signo.Valor1);
            comando.Parameters.AddWithValue("@valor2", signo.Valor2);
            comando.Parameters.AddWithValue("@observacion", signo.Observacion);

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
            string sql = "INSERT INTO paciente (nombres, apellidos, DPI, fecha_nacimiento, sexo, telefono, celular, tipo_sangre, alergias, Usuario_crea, estado) VALUES (@nombres, @apellidos, @DPI, @fecha_nacimiento, @sexo, @telefono, @celular, @tipo_sangre, @alergias, @Usuario_crea, 1)";
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
    }
}
