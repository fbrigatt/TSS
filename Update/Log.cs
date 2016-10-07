using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Update
{
    public class Log
    {
        public static void Write(string msg)
        {
            try
            {
                string path = @"C:\Temp\";
                string fileName = "Update-RC-" + DateTime.Now.ToShortDateString().Replace(@"\", "").Replace("/", "") + ".txt";
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                if (File.Exists(path + @"\" + fileName)) File.Delete(path + @"\" + fileName);
                StreamWriter writer = new StreamWriter(path + @"\" + fileName);
                writer.WriteLine(msg);
                writer.Close();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
