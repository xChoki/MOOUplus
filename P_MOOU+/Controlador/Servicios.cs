﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using P_MOOU_.Biblioteca;
using P_MOOU_.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Ubiety.Dns.Core;

namespace P_MOOU_.Controlador
{
    public class Servicios
    {

        BaseDato db;

        public List<DatosMoodle> ListarMySql(int id)
        {
            DataTable dt = null;
            List<DatosMoodle> lista = new List<DatosMoodle>();
            DatosMoodle usuario;
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
                    usuario = new DatosMoodle();
                    usuario.Id_table = int.Parse(dt.Rows[i]["id_table"].ToString());
                    usuario.Idcourse = int.Parse(dt.Rows[i]["idcourse"].ToString());
                    usuario.Id_student = int.Parse(dt.Rows[i]["id_student"].ToString());
                    usuario.Firstname = dt.Rows[i]["firstname"].ToString();
                    usuario.Lastname1 = dt.Rows[i]["lastname1"].ToString();
                    usuario.Lastname2 = dt.Rows[i]["lastname2"].ToString();
                    usuario.Idrol = dt.Rows[i]["idrol"].ToString();
                    usuario.Idsection = int.Parse(dt.Rows[i]["idsection"].ToString());
                    usuario.Namecourse = dt.Rows[i]["namecourse"].ToString();
                    usuario.Score = float.Parse(dt.Rows[i]["score"].ToString());
                    usuario.Attendance = int.Parse(dt.Rows[i]["attendance"].ToString());
                    usuario.Id_teacher = int.Parse(dt.Rows[i]["id_teacher"].ToString());
                    usuario.Nameteacher = dt.Rows[i]["nameteacher"].ToString();
                    usuario.Id_campus = int.Parse(dt.Rows[i]["id_campus"].ToString());
                    usuario.Tipe_schedule = dt.Rows[i]["tipe_schedule"].ToString();

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
        
        /*
        public bool P_InsertNotas(DatosNotas notas)
        {
            bool std = true;
            DataTable dt = null;
            SqlParameter param;
            List<DatosNotas> lista = new List<DatosNotas>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InsertarNotas";

                param = new SqlParameter("@codalu", notas.Codalu);
                param.Direction = ParameterDirection.InputOutput;
                param.DbType = DbType.Int32;

                cmd.Parameters.Add(param);

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

        public List<DatosNotas> ListarNotasUmas(int idalumno)
        {
            DataTable dt = null;
            List<DatosNotas> lista = new List<DatosNotas>();
            DatosNotas nota;
            string sql = "select * from tbl_notas order by codalu";
            if (idalumno != -1)
                sql = "select * from tbl_notas where codalu = "+ idalumno + " order by codalu";
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
                    nota = new DatosNotas();
                    nota.Codalu = int.Parse(dt.Rows[i]["codalu"].ToString());
                    nota.Codcurso = dt.Rows[i]["codcurso"].ToString();
                    nota.Idseccion = int.Parse(dt.Rows[i]["idseccion"].ToString());
                    nota.Nombrecurso = dt.Rows[i]["nombrecurso"].ToString();
                    nota.Codcarr = int.Parse(dt.Rows[i]["Codcarr"].ToString());
                    nota.Rutprofesor = int.Parse(dt.Rows[i]["rutprofesor"].ToString());
                    nota.Periodo = int.Parse(dt.Rows[i]["periodo"].ToString());
                    nota.Anno = int.Parse(dt.Rows[i]["anno"].ToString());
                    nota.Nota = float.Parse(dt.Rows[i]["nota"].ToString());
                    nota.Estatus = dt.Rows[i]["estatus"].ToString();
                    nota.Ocasion = int.Parse(dt.Rows[i]["ocasion"].ToString());
                    lista.Add(nota);
                }
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }

        public List<DatosNotasMoodle> ListarNotasMoodle(int idstudent)
        {
            DataTable dt = null;
            List<DatosNotasMoodle> lista = new List<DatosNotasMoodle>();
            DatosNotasMoodle nota;
            string sql = "select ua.id_student, ua.score, ua.idcourse, ua.namecourse from MYSQL...tbl_datosmoodle ua order by ua.id_student";
            if (idstudent != -1)
                sql = "select ua.id_student, ua.score, ua.idcourse, ua.namecourse from MYSQL...tbl_datosmoodle ua where id_student = " + idstudent + " order by ua.id_student";
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
                    nota = new DatosNotasMoodle();
                    nota.Id_student = int.Parse(dt.Rows[i]["id_student"].ToString());
                    nota.Score = float.Parse(dt.Rows[i]["score"].ToString());
                    nota.Idcourse = int.Parse(dt.Rows[i]["idcourse"].ToString());
                    nota.Namecourse = dt.Rows[i]["namecourse"].ToString();
                    lista.Add(nota);
                }
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }

        public List<DatosCarrerasMoodle> ListarCarrerasMySql(string idrol)
        {
            DataTable dt = null;
            List<DatosCarrerasMoodle> lista = new List<DatosCarrerasMoodle>();
            DatosCarrerasMoodle carrera;
            string sql = "select idrol, namecourse, idcourse from tbl_datosmoodle group by idrol;";
            if (idrol != "")
                sql = "select idrol, namecourse from tbl_datosmoodle where idrol=" + idrol + " group by idrol";
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
                    carrera = new DatosCarrerasMoodle();
                    carrera.Idrol = dt.Rows[i]["idrol"].ToString();
                    carrera.Namecourse = dt.Rows[i]["namecourse"].ToString();
                    lista.Add(carrera);
                }
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }

        public List<DatosCampusMoodle> ListarCampusMySql(int id_campus)
        {
            DataTable dt = null;
            List<DatosCampusMoodle> lista = new List<DatosCampusMoodle>();
            DatosCampusMoodle campus;
            string sql = "select id_campus from tbl_datosmoodle group by id_campus;";
            if (id_campus != -1)
                sql = "select id_campus from tbl_datosmoodle where id_campus=" + id_campus + " group by id_campus";
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
                    campus = new DatosCampusMoodle();
                    campus.Id_campus = int.Parse(dt.Rows[i]["id_campus"].ToString());
                    lista.Add(campus);
                }
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }

        public List<DatosProfesoresMoodle> ListarProfesoresMySql(int id_teacher)
        {
            DataTable dt = null;
            List<DatosProfesoresMoodle> lista = new List<DatosProfesoresMoodle>();
            DatosProfesoresMoodle profesor;
            string sql = "select id_teacher, nameteacher from tbl_datosmoodle group by id_teacher;";
            if (id_teacher != -1)
                sql = "select id_teacher, nameteacher from tbl_datosmoodle where id_teacher=" + id_teacher + " group by id_teacher";
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
                    profesor = new DatosProfesoresMoodle();
                    profesor.Id_teacher = int.Parse(dt.Rows[i]["id_teacher"].ToString());
                    profesor.Nameteacher = dt.Rows[i]["nameteacher"].ToString();
                    lista.Add(profesor);
                }
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }


        public List<DatosCursosMoodle> ListarCursosMoodle(string id_course)
        {
            DataTable dt = null;
            List<DatosCursosMoodle> lista = new List<DatosCursosMoodle>();
            DatosCursosMoodle cursos;
            string sql = "select idrol, namecourse from tbl_datosmoodle group by idrol;";
            if (id_course != "")
                sql = "select idrol, namecourse from tbl_datosmoodle where idrol=" + id_course + " group by idrol";
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
                    cursos = new DatosCursosMoodle();
                    cursos.Idrol = dt.Rows[i]["idrol"].ToString();
                    cursos.Namecourse = dt.Rows[i]["namecourse"].ToString();
                    lista.Add(cursos);
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
        public List<CarrerasUmas> GetNombreCarreras(int idcarrera)
        {
            DataTable dt = null;
            List<CarrerasUmas> lista = new List<CarrerasUmas>();
            CarrerasUmas carrerasumas;
            string sql = "select DISTINCT nombrecarr from tbl_carreras group by codcarr, nombrecarr order by nombrecarr";
            if (idcarrera != -1)
                sql = "select DISTINCT nombrecarr from tbl_carreras where codcarr=" + idcarrera + "group by codcarr, nombrecarr order by nombrecarr";
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
                    carrerasumas.Nombrecarr = dt.Rows[i]["nombrecarr"].ToString();
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

        public List<CarrerasUmas> GetCarreras(int idcarrera)
        {
            DataTable dt = null;
            List<CarrerasUmas> lista = new List<CarrerasUmas>();
            CarrerasUmas carrerasumas;
            string sql = "select DISTINCT codcarr, nombrecarr from tbl_carreras order by nombrecarr";
            if (idcarrera != -1)
                sql = "select DISTINCT codcarr, nombrecarr from tbl_carreras where codcarr=" + idcarrera + "order by nombrecarr";
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
                    carrerasumas.Nombrecarr = dt.Rows[i]["nombrecarr"].ToString();
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

        public List<EquivMoodleUmas> GetEquivMoodleUmas(string idcarrera)
        {
            DataTable dt = null;
            List<EquivMoodleUmas> lista = new List<EquivMoodleUmas>();
            EquivMoodleUmas equivMoodleUmas;

            string sql = "select m.idrol, u.codcarr, u.nombrecarr, u.nombrecurso, u.escuelacarr from MYSQL...tbl_datosmoodle m join DB_UMAS.dbo.tbl_carreras u on m.idrol = u.codcurso group by u.codcarr, m.idrol, u.nombrecarr, u.nombrecurso, u.escuelacarr";
            //if (idcarrera != "")
                //sql = "select m.idrol, u.codcarr from MYSQL...tbl_datosmoodle m join DB_UMAS.dbo.tbl_carreras u on m.idrol = u.codcurso where c.codcarr = '" + idcarrera + " group by u.codcarr, m.idrol')";
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
                    equivMoodleUmas = new EquivMoodleUmas();
                    equivMoodleUmas.Idrol = dt.Rows[i]["idrol"].ToString();
                    equivMoodleUmas.Codcarr = int.Parse(dt.Rows[i]["codcarr"].ToString());
                    equivMoodleUmas.Nombrecarr = dt.Rows[i]["nombrecarr"].ToString();
                    equivMoodleUmas.Nombrecurso = dt.Rows[i]["nombrecurso"].ToString();
                    equivMoodleUmas.Escuelacarr = dt.Rows[i]["escuelacarr"].ToString();
                    lista.Add(equivMoodleUmas);
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

        
        public bool Insert_Carreras(DatosCarrerasMoodle carreras)
        {
            bool std = true;
            try
            {
                string sql = $"insert into tbl_carreras " +
                    "values(" +
                    "'" + carreras.Idrol + "', " +
                    "'" + carreras.Namecourse + "')";

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
        }

        public bool Insert_Alumnos(DatosMoodle alumnos)
        {
            bool std = true;
            try
            {
                //insert into tbl_alumnos values(18972156,'GODOY', 'VEGA', 'RAYEN ALEJANDRA', 'COM117', 9018,15506209 ,320);
                string sql = $"insert into tbl_alumnos " +
                    "values(" +
                    "" + alumnos.Id_student + "," +
                    "'" + alumnos.Lastname1 + "'," +
                    "'" + alumnos.Lastname2 + "'," +
                    "'" + alumnos.Firstname + "'," +
                    "'" + alumnos.Idrol + "'," +
                    "" + alumnos.Idsection + "," +
                    "" + alumnos.Id_teacher + "," +
                    "" + alumnos.Id_campus + ")";

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
        }

        public bool Insert_Campus(DatosCampusMoodle campus)
        {
            bool std = true;
            try
            {
                string sql = $"insert into tbl_campus " +
                    "values(" +
                    "" + campus.Id_campus + ", " +
                    "'nombre campus')";

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
        }

        public bool Insert_Curso(DatosCursosMoodle carreras)
        {
            bool std = true;
            try
            {
                string sql = $"insert into tbl_cursos " +
                    "values(" +
                    "'" + carreras.Idrol + "', " +
                    "'" + carreras.Namecourse + "')";

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
        }

        public bool Insert_Profesores(DatosProfesoresMoodle profesores)
        {
            bool std = true;
            try
            {
                string sql = $"insert into tbl_profesores " +
                    "values(" +
                    "" + profesores.Id_teacher + ", " +
                    "'" + profesores.Nameteacher + "')";

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
        }

    } //fin de servicios
}
