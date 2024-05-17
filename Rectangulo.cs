using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurasgeometricas
{
    class Rectangulo:Figura //Clase hija de figura
    {
        //esta clase requiere dos lados para funcionar
        //creamos el lado2
        private float lado2;
        //crear un constructor para rectangulo
        public float Lado2
        {
            set
            {
                //pregunta si el lado <0
                if (value <0)
                {
                    Lado2 = 0; //manda el valor a 0
                }//no existen lados negativos
                else
                {
                    Lado2 = value;
                    //value es el valor del textbox
                }
            }
            get //obtener el valor
            {
                return Lado2; //regresa o cacha el valor de la variable lado1
            }
        }
        //usamos le constructor de la clase padre
        public Rectangulo (float lado1, float lado2)
        {//lado1 y lado2 se van a leer de la cajade texto
            //usando el boton guardar
            this.Lado1 = lado1;//hace que unicamente el valor 
                               //cantidad del lado sea disponible
                               //´para la clase rectangulo, cuando no se use rectangulo
                               //la variable sera = 0
            this.Lado2 = lado2;
        }
        //vamos  ausar los metodos de la clase padre
        //vamos a sobreescribir el comportamiento de estos
        public override float area()
        {
            return Lado1 * Lado2;
        }
        public override float perimetro()
        {
            return (2 * Lado1) + (2 * Lado2);
        }
        public override float volumen()
        {
            throw new NotImplementedException();
            //esto es una exepcion de uso default del sistema
        }
    }
}
