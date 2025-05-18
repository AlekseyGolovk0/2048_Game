using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048GameWinFormsApp
{
    public class FileProvider
    {
        public static string Read(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                var read = reader.ReadToEnd();
                return read;
            }
        }
        public static bool Exist(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return false;
            }
            return true;
        }
        public static void Save(string fileName, string userResult)
        {
            using (var writer = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                writer.WriteLine(userResult);
            }
        }
    }
}
