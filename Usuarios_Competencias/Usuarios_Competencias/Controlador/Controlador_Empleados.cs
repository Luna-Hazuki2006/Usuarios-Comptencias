using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios_Competencias.Modelo;

namespace Usuarios_Competencias.Controlador
{
    public class Controlador_Empleados
    {
        public static void Crear(Empleado empleado)
        {
            try
            {
                using (var db = new EmpledoContext())
                {
                    empleado.Estado = 'a';
                    db.Empleados.Add(empleado);
                    db.SaveChanges();
                };
            }
            catch (Exception e)
            {
                Logger.LogError(e);
                Mensajes.MensajeError($"Error inesperado: {e.Message}");
            }
        }

        public static Empleado? Consultar(string cedula)
        {
            try
            {
                using (var db = new EmpledoContext())
                {
                    var empleado = db.Empleados.Find(cedula);
                    return empleado;
                };
            }
            catch (Exception e)
            {
                Logger.LogError(e);
                Mensajes.MensajeError($"Error inesperado: {e.Message}");
                return default;
            }
        }

        public static void Modificar(Empleado empleado)
        {
            try
            {
                using (var db = new EmpledoContext())
                {
                    db.Empleados.Update(empleado);
                    db.SaveChanges();
                };
            }
            catch (Exception e)
            {
                Logger.LogError(e);
                Mensajes.MensajeError($"Error inesperado: {e.Message}");
            }
        }

        public static void Eliminar(string cedula)
        {
            try
            {
                using (var db = new EmpledoContext())
                {
                    var empleado = db.Empleados.Find(cedula);
                    db.Empleados.Remove(empleado);
                    db.SaveChanges();
                };
            }
            catch (Exception e)
            {
                Logger.LogError(e);
                Mensajes.MensajeError($"Error inesperado: {e.Message}");
            }
        }

        public static List<Empleado>? Listar()
        {
            try
            {
                using (var db = new EmpledoContext())
                {
                    var empleados = db.Empleados.ToList();
                    return empleados;
                };
            }
            catch (Exception e)
            {
                Logger.LogError(e);
                Mensajes.MensajeError($"Error inesperado: {e.Message}");
                return default;
            }
        }

        public static List<Empleado>? Listar_Cedulas(string cedula)
        {
            try
            {
                using (var db = new EmpledoContext())
                {
                    var empleados = db.Empleados.Where(t => t.Cedula.Contains(cedula)).ToList();
                    return empleados;
                };
            }
            catch (Exception e)
            {
                Logger.LogError(e);
                Mensajes.MensajeError($"Error inesperado: {e.Message}");
                return default;
            }
        }

        public static List<Empleado>? Listar_Estados(char estado)
        {
            try
            {
                using (var db = new EmpledoContext())
                {
                    var empleados = db.Empleados.Where(t => t.Estado == estado).ToList();
                    return empleados;
                };
            }
            catch (Exception e)
            {
                Logger.LogError(e);
                Mensajes.MensajeError($"Error inesperado: {e.Message}");
                return default;
            }
        }
    }
}
