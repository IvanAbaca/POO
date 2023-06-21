using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

/*
TEMAS ABORDADOS: POO
    -OBJETOS
    -HERENCIA
    -ABSTRACCION
    -POLIMORFISMO
    -ENCAPSULAMIENTO
    -SOBRECARGA DE OPERADORES

SIGUIENTES TEMAS A INVESTIGAR: 
    -ARRAYS DE OBJETOS
    -API's
*/

namespace POO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Empleado objeto1 = new Empleado(); //CREA UN OBJETO VACIO (DE UNA CLASE HEREDADA)
            Empleado objeto2 = new Empleado(5);//CREA UN OBJETO INICIALIZADO (DE UNA CLASE HEREDADA)

            objeto1.mostrar(); //MUESTRA OBJETO1 (CON UN METODO SOBRE-ESCRITO)
            objeto2.mostrar(); //MUESTRA OBJETO2 (CON UN METODO SOBRE-ESCRITO)

            if (objeto1.equals(objeto2)) //COMPARA OBJETOS (NO VAN A SER IGUALES)
                Console.WriteLine("Son iguales.");
            else
                Console.WriteLine("No son iguales.");

            objeto2.vaciar(); //UTILIZA EL METODO SOBRE-ESCRITO DE UNA INTERFAZ PARA VACIAR EL OBJETO

            if (objeto1.equals(objeto2)) //COMPARA OBJETOS (VAN A SER IGUALES YA QUE ESTAN VACIOS)
                Console.WriteLine("Son iguales.");
            else
                Console.WriteLine("No son iguales.");

            objeto2.mostrar(); //MUESTRA EL OBJETO VACIADO

        }
    }

}
