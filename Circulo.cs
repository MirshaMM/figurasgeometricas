using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurasgeometricas
{
    class Circulo:Figura //es una clase hija figura
    {
        //usamos el constructor de la clse padre
        public Circulo(float radio)
        {//radio se va a leer de la caja de texto con
            //usando el boton guardar
            Lado1 = radio;
        }
        //vamos a usar los metodos de la clase padre
        //vamos a sobreescribir el comportamiento de estos
        public override float area()
        {
            return 3.1416F * Lado1 * Lado1;
            //agregamos F al finla de un numero cuando es una constante no definida en una variable previamnete
            //asi el programa sabe qeu es un #
        }
        public override float perimetro()
        {
            return 3.1416F * 2 * Lado1;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
            //ESTA ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
}
