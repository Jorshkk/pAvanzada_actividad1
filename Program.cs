using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Planeta p1 = new Planeta {
                Nombre = "Planeta 1",
                Masa = 233222,
                Periodo_orbital = 665,
                Albedo = 1,
                Estrella = "Estrella 1"
        };
           
            p1.MostrarPlaneta();

            Planeta p2 = new Planeta("Planeta 2",343,3434,1,"Estrella 2");
            p2.MostrarPlaneta();

            Satelite s1 = new Satelite("Satelite 1",234,55544);
            s1.MostrarSatelite();
            Satelite s2 = new Satelite("Satelite 2", 234, 55544);
            s2.MostrarSatelite();
            Satelite s3 = new Satelite("Satelite 3", 234, 55544);
            s3.MostrarSatelite();
            Satelite s4 = new Satelite("Satelite 4", 234, 55544);
            s4.MostrarSatelite();

            Console.ReadKey();
        }
    }
}
