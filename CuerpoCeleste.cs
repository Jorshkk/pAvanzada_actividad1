using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CuerpoCeleste
    {
        private string nombre;
        private int masa;

        public CuerpoCeleste()
        {

        }
        public CuerpoCeleste(string nombre, int masa)
        {
            this.nombre = nombre;
            this.masa = masa;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Masa { get => masa; set => masa = value; }
    }
}
