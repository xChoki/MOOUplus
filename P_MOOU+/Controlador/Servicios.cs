using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Pintermedio.Biblioteca;
using Pintermedio.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Pintermedio.Controlador
{
    public class Servicios
    {

        BaseDato db;
        
        public List<Alumnos> ListarMySql(int id)
        {
            DataTable dt = null;
            List<Alumnos> lista = new List<Alumnos>();
            Alumnos usuario;
            string sql = "select * from tbl_datosmoodle group by id_student";
            if (id != -1)
                sql = "select * from tbl_datosmoodle where id=" + id + " group by id_student";
            try
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                db = new BaseDato();
                dt = db.EjecutarConsultaMySql(cmd);
                //pasamos del DataTable a una List de Clientes                 
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    /*
                    int id_table;
                    int idcourse;
                    int id_student;
                    string lastname1;
                    string lastname2;
                    string firstname;
                    string idrol;
                    int idsection;
                    string namecourse;
                    float score;
                    int attendance;
                    int id_teacher;
                    string nameteacher;
                    int id_campus;
                    string tipe_schedule;*/
                    usuario = new Alumnos();
                    usuario.Id_student = int.Parse(dt.Rows[i]["id_student"].ToString());
                    usuario.Firstname = dt.Rows[i]["firstname"].ToString();
                    usuario.Lastname1 = dt.Rows[i]["lastname1"].ToString();
                    lista.Add(usuario);
                }
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }

        public PartialViewResult SearchUsers(string searchText)
        {
            List<Alumnos> lista = new List<Alumnos>();
            var result = lista.Where(a => a.Firstname.ToLower().Contains(searchText) || a.Id_student.ToString().Contains(searchText)).ToList();

            return PartialView("_GridView", result);

        }

        public List<CursosMoodle> GetNotas(int idrol)
        {
            DataTable dt = null;
            List<CursosMoodle> lista = new List<CursosMoodle>();
            CursosMoodle notasmoodle;
            string sql = "select * from notas";
            if (idrol != -1)
                sql = "select * from notas where idrol=" + idrol;
            try
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                db = new BaseDato();
                dt = db.EjecutarConsultaMySql(cmd);
                //pasamos del DataTable a una List de Clientes                 
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    notasmoodle = new CursosMoodle();
                    notasmoodle.Id = int.Parse(dt.Rows[i]["id"].ToString());
                    notasmoodle.Namecourse = dt.Rows[i]["namecourse"].ToString();
                    notasmoodle.Idrol = dt.Rows[i]["idrol"].ToString();
                    lista.Add(notasmoodle);
                }
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }

        //select r.nombreramo,r.codramo from ramos r join ramoscarrera rc on r.codramo = rc.codramo where rc.codcarr=320001;
        public List<CarrerasUmas> GetCarreras(int idcarrera)
        {
            DataTable dt = null;
            List<CarrerasUmas> lista = new List<CarrerasUmas>();
            CarrerasUmas carrerasumas;
            string sql = "select * from tbl_carreras";
            if (idcarrera != -1)
                sql = "select * from carreras where codcarr=" + idcarrera;
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                db = new BaseDato();
                dt = db.EjecutarConsultaSQLServer(cmd);
                //pasamos del DataTable a una List de Clientes                 
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    carrerasumas = new CarrerasUmas();
                    carrerasumas.Codcarr = int.Parse(dt.Rows[i]["codcarr"].ToString());
                    carrerasumas.Carrera = dt.Rows[i]["carrera"].ToString();
                    lista.Add(carrerasumas);
                }
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }

        public List<RamosUmas> GetRamos(int idcarrera)
        {
            DataTable dt = null;
            List<RamosUmas> lista = new List<RamosUmas>();
            RamosUmas ramosumas;
            string sql = "select r.nombreramo,r.codramo from ramos r join ramoscarrera rc on r.codramo = rc.codramo where rc.codcarr="+idcarrera;
            
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                db = new BaseDato();
                dt = db.EjecutarConsultaSQLServer(cmd);
                //pasamos del DataTable a una List de Clientes                 
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ramosumas = new RamosUmas();
                    ramosumas.Codramo = dt.Rows[i]["codramo"].ToString();
                    ramosumas.Nombreramo = dt.Rows[i]["nombreramo"].ToString();
                    lista.Add(ramosumas);
                }
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }

        /*
        public bool Insert_Usuario(Alumnos usuario)
        {
            bool std = true;
            try
            {
                string sql = $"insert into usuarios " +
                    "values(" +
                    "'" + usuario.Nombre + "', " +
                    "'" + usuario.Apellido + "')";
                   
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                db = new BaseDato();
                db.EjecutarConsultaSQLServer(cmd);
                std = true;
            }
            catch (Exception ex)
            {
                std = false;
                Console.Write(ex.Message);
            }
            return std;
        }*/

    } //fin de servicios
}
