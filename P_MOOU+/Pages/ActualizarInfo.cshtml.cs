using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using P_MOOU_.Controlador;
using P_MOOU_.Modelo;

namespace P_MOOU_.Pages
{
    public class ActualizarInfoModel : PageModel
    {
        public void OnGet()
        {

        }
        public void OnPostFuncionAlumnos()
        {
            Servicios servicio = new Servicios();
            List<DatosMoodle> lista;
            lista = servicio.ListarMySql(-1);

            foreach (var c in lista) {
                servicio.Insert_Alumnos(c);
            }
            ViewData["Message"] = "Insertado alumnos exitosamente";
        }
        public void OnPostFuncionCarrera()
        {
            Servicios servicio = new Servicios();
            List<DatosCarrerasMoodle> lista;
            lista = servicio.ListarCarrerasMySql("");

            foreach (var c in lista)
            {
                servicio.Insert_Carreras(c);
            }
            ViewData["Message"] = "Carrera";
        }
        public void OnPostFuncionCampus()
        {
            Servicios servicio = new Servicios();
            List<DatosCampusMoodle> lista;
            lista = servicio.ListarCampusMySql(-1);

            foreach (var c in lista)
            {
                servicio.Insert_Campus(c);
            }
            ViewData["Message"] = "Campus";
        }
        public void OnPostFuncionProfesores()
        {
            Servicios servicio = new Servicios();
            List<DatosProfesoresMoodle> lista;
            lista = servicio.ListarProfesoresMySql(-1);

            foreach (var p in lista)
            {
                servicio.Insert_Profesores(p);
            }
            ViewData["Message"] = "Profesores";
        }
        public void OnPostFuncionCursos()
        {
            Servicios servicio = new Servicios();
            List<DatosCursosMoodle> lista;
            lista = servicio.ListarCursosMoodle("");

            foreach (var c in lista)
            {
                servicio.Insert_Curso(c);
            }
            ViewData["Message"] = "Cursos";
        }
        public void OnPostFuncionNotas()
        {
            Servicios servicio = new Servicios();
            List<DatosNotas> lista;
            lista = servicio.ListarNotas(-1);

            foreach (var c in lista)
            {
                servicio.Procedure_NotasDist(c);
                //servicio.Procedure_NotasVacio(c);
            }
            ViewData["Message"] = "Notas";
        }

    }
}
