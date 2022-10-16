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

                };
            }
            catch (Exception e)
            {
                Logger.LogError(e);
                Mensajes.MensajeError($"Errar inesperado: {e.Message}");
            }
        }
    }
}
