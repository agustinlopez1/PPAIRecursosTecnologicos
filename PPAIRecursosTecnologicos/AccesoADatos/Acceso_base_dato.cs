using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using PPAIRecursosTecnologicos.Entidades;

namespace PPAIRecursosTecnologicos.AccesoADatos
{
    public class Acceso_base_dato
    {
        public enum TipoConexion { simple, transaccion }
        public enum TipoEstado { correcto, error, sinTransaccion }
        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        SqlTransaction transaccion;
        TipoConexion ControlTipoConexion = TipoConexion.simple;
        TipoEstado ControlTransaccion = TipoEstado.correcto;
        string cadena_conexion = @"Data Source=DESKTOP-LN2QDRN\SQLEXPRESS;Initial Catalog=RecursosTecnologicosBD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private void Conectar()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.ConnectionString = cadena_conexion;
                try
                {
                    Conexion.Open();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Hubo un error en la Base de Datos\n"
                    + "Con el comando: \n"
                    + "Conexion.Open()" + "\n"
                    + "El error en la base de datos:\n"
                    + e.Message);
                    ControlTransaccion = TipoEstado.error;
                    return;
                }
                Cmd.Connection = Conexion;
                Cmd.CommandType = CommandType.Text;
                if (ControlTipoConexion == TipoConexion.transaccion)
                {
                    transaccion = Conexion.BeginTransaction(IsolationLevel.ReadCommitted);
                    Cmd.Transaction = transaccion;
                }
            }

        }

        private void Desconectar()
        {
            if (ControlTipoConexion == TipoConexion.simple)
            {
                Conexion.Close();
            }
        }

        public DataTable EjecutarSelect(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            try
            {
                tabla.Load(Cmd.ExecuteReader());
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un error en la base de datos\n"
                    + "Con el comando: \n"
                    + sql + "\n"
                    + "El error en la base de datos:\n"
                    + e.Message);
                ControlTransaccion = TipoEstado.error;
                Desconectar();
                return tabla;
            }
            Desconectar();
            return tabla;
        }

        public void EjecutarInsert(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un error en la Base de Datos\n"
                + "Con el comando: \n"
                + sql + "\n"
                + "El error en la base de datos:\n"
                + e.Message);
                ControlTransaccion = TipoEstado.error;
            }
            Desconectar();
        }
    }
}
