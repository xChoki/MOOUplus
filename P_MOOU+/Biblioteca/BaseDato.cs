using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Pintermedio.Biblioteca
{
    public class BaseDato
    {
        string conx = "Data Source=PC-JAVIER-WIN10\\SQLEXPRESS;Initial Catalog = DB_UMAS; Integrated Security = True";

        // sql server
        public DataTable EjecutarConsultaSQLServer(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                cmd.Connection = new SqlConnection(conx);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                Console.Write(ex.Message);
            }
            return dt;
        }


        public DataTable EjecutarConsultaMySql(MySqlCommand cmd)
        {
            DataTable dt = new DataTable();
            string conexion = "Server=localhost;Database=db_moodle;User ID=root;Password= ;Pooling=false;";
            MySqlConnection conn = new MySqlConnection(conexion);
            
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                cmd.Connection = conn;
                sda.Fill(dt);

            }
            catch (Exception ex)
            {
                dt = null;
                Console.Write(ex.Message);
            }
            return dt;
        }

    } //fin de la clase
}
