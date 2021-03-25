using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Planeta : CuerpoCeleste
    {
        private int periodo_orbital;
        private float albedo;
        private string estrella;

        public Planeta()
        {
        }
        public Planeta(int periodo_orbital, float albedo, string estrella)
        {
            this.periodo_orbital = periodo_orbital;
            this.albedo = albedo;
            this.estrella = estrella;
        }
        public Planeta(string nombre,int masa,int periodo_orbital, float albedo, string estrella)
        {
            this.Nombre = nombre;
            this.Masa = masa;
            this.periodo_orbital = periodo_orbital;
            this.albedo = albedo;
            this.estrella = estrella;
        }
        public int Periodo_orbital { get => periodo_orbital; set => periodo_orbital = value; }
        public float Albedo { get => albedo; set => albedo = value; }
        public string Estrella { get => estrella; set => estrella = value; }

        public void MostrarPlaneta()
        {
            Console.WriteLine("\n====================="+
                "\nPLANETA"+
                "\nNombre: "+this.Nombre+
                "\nMasa: "+this.Masa+
                "\nPerdiodo Orbital: "+this.Periodo_orbital+
                "\nAlbedo: "+this.albedo+
                "\nEstrella: "+this.estrella);
        }
    }
}
