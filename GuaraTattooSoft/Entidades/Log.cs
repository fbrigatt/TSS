using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GuaraTattooSoft.Entidades
{
    public class Log
    {
        public static void Write(string classe, string metodo, string exception)
        {
            try
            {
                string data = DateTime.Now.ToShortDateString().Replace("/", "-");
                if (!Directory.Exists(@"C:\Temp")) Directory.CreateDirectory(@"C:\Temp");
                if (!Directory.Exists(@"C:\Temp\" + data)) Directory.CreateDirectory(@"C:\Temp\" + data);

                string nomeArquivo = (data.Replace("-", "") + DateTime.Now.ToShortTimeString().Replace(":", "") + DateTime.Now.Second + ".txt");
                string diretorioArquivo = (@"C:\Temp\" + data + @"\" + nomeArquivo);

                StreamWriter writer = new StreamWriter(diretorioArquivo);
                writer.WriteLine("Data: " + DateTime.Now);
                writer.WriteLine("Classe: " + classe);
                writer.WriteLine("Metodo: " + metodo);
                writer.WriteLine("Exception: " + exception);
                writer.Close();

            }
            catch(Exception ex)
            {

            }
        }
    }
}
