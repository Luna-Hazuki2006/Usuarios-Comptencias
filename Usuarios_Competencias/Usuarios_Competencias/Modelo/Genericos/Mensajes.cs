using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Mensajes
{
    public static void MensajeExito(string mensaje)
    {
        MessageBox.Show(mensaje,
            "Exito",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    public static void MensajeError(string mensaje)
    {
        MessageBox.Show(mensaje,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
    }

    public static void MensajeAdvertencia(string mensaje)
    {
        MessageBox.Show(mensaje,
            "Advertencia",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
    }

    public static bool VerificarAccion(string mensaje)
    {
        return MessageBox.Show(mensaje,
            "Confirmar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning) == DialogResult.Yes;
    }
}