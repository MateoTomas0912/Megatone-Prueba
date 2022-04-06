using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celular primerCelular = new Celular(64, true, "Snapdragon 888", 2, true);
            Celular segundoCelular = new Celular(10, false, "Snapdragon 720", 1, true);
            Celular tercerCelular = new Celular(52, true, "Exynos", 9, false);

            primerCelular.estadoDelTelefono();
            primerCelular.calidadFotos();
            primerCelular.marcaTelefono();

            segundoCelular.estadoDelTelefono();
            segundoCelular.calidadFotos();
            segundoCelular.marcaTelefono();

            tercerCelular.estadoDelTelefono();
            tercerCelular.calidadFotos();
            tercerCelular.marcaTelefono();

            Console.ReadKey();
        }
    }
}
