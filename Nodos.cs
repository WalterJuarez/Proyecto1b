using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Proyecto1
{
    class Nodos<T>
    {
        

        public T data { get; set; }
        public Nodos<T> actual { get; set; }
        public Nodos<T> siguiente { get; set; }

        public bool ValidacionEx(string ubicacion)
        {
            bool result;
            try
            {

                StreamReader sr = new StreamReader("C:\\" + ubicacion+"\\");
                string compar = Convert.ToString(sr);
                if (compar == "C:\\temp\\")
                {
                    result = true;        
                }
                else
                {
                    result = false;
                }

                
            }catch(Exception e)
            {
                Console.WriteLine("Exception: "+ e.Message);
            }
            return result;
        }
        public void LeerArchivo()
        {
            string line;
            try
            {
                StreamReader sr = new StreamReader("C:\\");
                
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exeption: " + e.Message);
            }
        }

        public void EscribirArchivo()
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\");
                sw.WriteLine("");
                sw.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exceptio: " + e.Message);
            }
        }
    }
}
