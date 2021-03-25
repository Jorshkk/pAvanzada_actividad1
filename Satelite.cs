using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Satelite : CuerpoCeleste
    {
        private int volumen;
        public Satelite(int volumen)
        {
            this.volumen = volumen;
        }
        public Satelite(string nombre, int masa, int volumen)
        {
            this.Nombre = nombre;
            this.Masa = masa;
            this.volumen = volumen;
        }
        public Satelite()
        {
        }
        public int Volumen { get => volumen; set => volumen = value; }

        public void MostrarSatelite()
        {
            Console.WriteLine("\n**********************" +
               "\nSatelite" +
               "\nNombre: " + this.Nombre +
               "\nMasa: " + this.Masa +
               "\nVolumen: " + this.volumen);
        }
    }
}
