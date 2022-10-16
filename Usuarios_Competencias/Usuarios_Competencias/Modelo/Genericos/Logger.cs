using System;
using System.IO;

static class Logger
{
    public static string LogError(Exception ex, string[]? extra = null)
    {

        string mensaje = $"Fecha: {DateTime.Now:dd/MM/yyyy hh:mm:ss tt}";
        mensaje += Environment.NewLine;
        mensaje += "-----------------------------------------------------------";
        mensaje += Environment.NewLine;
        mensaje += $"Mensaje: {ex.Message}";
        mensaje += Environment.NewLine;
        mensaje += $"StackTrace: {ex.StackTrace}";
        mensaje += Environment.NewLine;
        mensaje += $"Fuente: {ex.Source}";
        mensaje += Environment.NewLine;
        mensaje += $"Objetivo: {ex.TargetSite}";
        mensaje += Environment.NewLine;
        mensaje += "-----------------------------------------------------------";
        mensaje += Environment.NewLine;

        extra ??= Array.Empty<string>();

        if (extra.Length != 0)
        {
            mensaje += "Información extra: ";
            foreach (string linea in extra)
            {
                mensaje += Environment.NewLine;
                mensaje += linea;
            }
        }

        string path = AppContext.BaseDirectory + "/error.log";
        using StreamWriter writer = new(path, true);
        writer.WriteLine(mensaje);
        writer.Close();
        return mensaje;
    }
}