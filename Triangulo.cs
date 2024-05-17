using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurasgeometricas
{
    class Triangulo:Figura //la clase trinagulo es hija de Figura
    {
        private float lado2;
        private float h;//altura
        public float b;//base
        public float Lado2
        {
            set
            {
                //pregunta si el lado <0
                if (value < 0)
                {
                    lado2 = 0; //manda el valor a 0
                } //no se puede calcular con lados negativos
                else
                {
                    lado2 = value;
                }
            }
            get //obtener el valor
            {
                return lado2; //regresa o cacha el valor de la variable lado1
            }

        }
        private float H
        {
            set
            {
                //pregunta si el lado <0
                if (value < 0)
                {
                    h = 0; //manda el valor a 0
                } //no se puede calcular con lados negativos
                else
                {
                    h = value;
                }
            }
            get //obtener el valor
            {
                return h; //regresa o cacha el valor de la variable lado1
            }
        }
        private float BaseT
        {
            set
            {
                //pregunta si el lado <0
                if (value < 0)
                {
                    BaseT = 0; //manda el valor a 0
                } //NO EXISTEN LADOS NEGATIVOS
                else
                {
                    BaseT = value;
                }
            }
            get //obtener el valor
            {
                return BaseT; //regresa o cacha el valor de la variable lado1
            }
        }
        public Triangulo(float lado1, float lado2, float altura, float baset)
        {  //la operacion que realiza es leer lo que ya se guardo en nuestra caja de texto
            this.h = lado1;// hace que unicamente el valor la
                               //cantidad del lado sea disponible
                               //para la clase triangulo, cuando no se usa triangulo
                               //la variable sera=0
            this.Lado2 = lado2;
            this.H = h;
            this.BaseT = baset;
        }
        //vamos a usar los metodos de la clase padre
        //vamos a sobreescribir el comportamiento de estos
        public override float area() //aqui realiza la operacion para sacar el area
        {
            return BaseT * H / 2; 
        }
        public override float perimetro()
        {
            return h + Lado2 + BaseT;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
}
