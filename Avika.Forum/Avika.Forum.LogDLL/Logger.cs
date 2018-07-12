using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Avika.Forum.LogDLL
{
    public class Logger
    {
        public static string RUTA = "~/App_Data/errores";
        string _ruta = "";
        public Logger(string ruta)
        {
            this._ruta = ruta;
            crearCarpetasDestino(this._ruta);
        }

        void crearCarpetasDestino(string ruta)
        {
            if (!Directory.Exists(ruta))
            {
                string rutaPegada = string.Empty;
                var carpetas = ruta.Split(new[] { "\\" }, StringSplitOptions.None);
                foreach (var carpeta in carpetas)
                {
                    rutaPegada = Path.Combine(rutaPegada + @"\", carpeta);
                    if (!Directory.Exists(rutaPegada))
                        try
                        {
                            Directory.CreateDirectory(rutaPegada);
                        }
                        catch { }
                }
            }

        }

        public void EscribirError(string formato, params string[] parametros)
        {
            try
            {
                StreamWriter Adestino; string linea = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                linea += "(" + Thread.CurrentThread.ManagedThreadId.ToString() + ")";
                linea += " - " + string.Format(formato, parametros);
                string rutaCompleta = Path.Combine(_ruta, string.Format("Log.{0}.{1}.{2}.txt", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year));
                Adestino = File.AppendText(rutaCompleta);
                Adestino.WriteLine($"Error: {linea}");
                Adestino.Close();
            }
            catch
            {
            }
        }

        public void EscribirLog(string error = null)
        {
            try
            {
                StreamWriter Adestino; string linea = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                linea += "(" + Thread.CurrentThread.ManagedThreadId.ToString() + ")";
                linea += " - " + string.Format(error);
                string rutaCompleta = Path.Combine(_ruta, string.Format("Peticiones.{0}.{1}.{2}.txt", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year));
                Adestino = File.AppendText(rutaCompleta);
                Adestino.WriteLine($"Actividad: {linea}");
                Adestino.Close();
            }
            catch
            {
            }
        }
    }
}
