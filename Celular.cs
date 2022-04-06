using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Celular 
    {
        public int resolucionCamara { get; set; }
        public bool bluethoot { get; set; }
        public string procesador { get; set; }
        public int marca { get; set; }
        public bool estado { get; set; }

        public Celular(int resolucionCamara, bool bluethoot, string procesador, int marca, bool estado)
        {
            this.resolucionCamara = resolucionCamara;
            this.bluethoot = bluethoot;
            this.procesador = procesador;
            this.marca = marca;
            this.estado = estado;
        }

        public void calidadFotos() 
        {
            if (resolucionCamara > 48)
            {
                Console.WriteLine("Las fotos tienen una alta calidad de: " + resolucionCamara + "px");
            }
            else if (resolucionCamara < 48 && resolucionCamara > 12)
            {
                Console.WriteLine("Las fotos tienen una calidad media de: " + resolucionCamara + "px");
            }
            else
            {
                Console.WriteLine("Las fotos tienen una calidad baja de: " + resolucionCamara + "px");
            }
        }

        public void estadoDelTelefono()
        {
            if (estado && bluethoot)
            {
                Console.WriteLine("El dispositivo esta encendido y el bluethoot tambien");
            } else if(estado && !bluethoot)
            {
                Console.WriteLine("El dispositivo esta encendido y el bluethoot esta apagado");
            }
            else
            {
                Console.WriteLine("El dispositivo esta apagado");
            }
        } 

        public void marcaTelefono()
        {
            switch (marca) //Decidi aplicar un switch para cambiar el formato de programacion
            {               
                case 1: //Cada numero del integer se relaciona con una marca diferente
                    Console.WriteLine("El celular es un Motorla con procesador: " + procesador);
                    break;
                case 2:
                    Console.WriteLine("El celular es un Samsung con procesador: " + procesador);
                    break;
                case 3:
                    Console.WriteLine("El celular es un Xiaomi con procesador: " + procesador);
                    break;
                case 4:
                    Console.WriteLine("El celular es un Iphone con procesador: " + procesador);
                    break;
                default: Console.WriteLine("El celular no es de ninguna marca conocida por el sistema");
                    break;
            }
        }




    }
}
