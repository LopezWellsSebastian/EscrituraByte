using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace EscrituraByte
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            byte[] buffer = new byte[81];
            int nBytes=0, Car;
            try
            {
                fs = new FileStream("text.txt", FileMode.Create, FileAccess.Write);
                Console.WriteLine("Escriba el texto que desea almacenar en el archivo: ");

                while ((Car=Console.Read()) != '\r' && (nBytes<buffer.Length))
                {
                    buffer[nBytes] = (byte)Car;
                    nBytes++;
                    
                }
                fs.Write(buffer, 0, nBytes);
            }
            catch(IOException E)
            {
                Console.WriteLine(E.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }
    }
}
