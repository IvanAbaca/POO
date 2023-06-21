using System;

namespace Clases
{
    interface IVaciable
    {
        public bool isVacio();
        public void vaciar();
    }
    abstract class Persona : IVaciable //ABSTRACCION
    {
        //DECLARACION DE ATRIBUTOS (ENCAPSULACION APLICADA)
        private int id;
        private string nombre;
        private string apellido;
        private string direccion;
        private string telefono;
        private int dni;
        private string email;

        //METODO CONSTRUCTOR
        public Persona()
        {
            this.id = 0;
            this.nombre = "";
            this.apellido = "";
            this.direccion = "";
            this.telefono = "";
            this.dni = 0;
            this.email = "";

        }

        public Persona(int id)
        {
            this.id = id;
            this.nombre = "SinNombre";
            this.apellido = "SinApellido";
            this.direccion = "Calle Ejemplo 123";
            this.telefono = "+54 9 11 4526-9875";
            this.dni = 40123456;
            this.email = "ejemplo@gmail.com";
        }

        //METODOS
        public virtual void mostrar() //VIRTUAL PARA PODER SOBRE-ESCRIBIRLO
        {
            Console.WriteLine
            (
                "\nId " + "\t:\t " + this.id +
                "\nNombre " + "\t:\t " + this.nombre +
                "\nApellido " + ":\t " + this.apellido +
                "\nDireccion " + ":\t " + this.direccion +
                "\nTelefono " + ":\t " + this.telefono +
                "\nDNI " + "\t:\t " + this.dni +
                "\nEmail " + "\t:\t " + this.email
            );
        }

        public bool equals(Persona per)
        {
            if (this.id != per.id ||
                this.nombre != per.nombre ||
                this.apellido != per.apellido ||
                this.direccion != per.direccion ||
                this.telefono != per.telefono ||
                this.dni != per.dni ||
                this.email != per.email)
                return false;
            return true;
        }

        //USO DE LA INTERFAZ
        public virtual bool isVacio()
        {
            if (this.id == 0 &&
                this.nombre == "" &&
                this.apellido == "" &&
                this.direccion == "" &&
                this.telefono == "" &&
                this.dni == 0 &&
                this.email == "")
                return true;
            return false;
        }
        public virtual void vaciar()
        {
            this.id = 0;
            this.nombre = "";
            this.apellido = "";
            this.direccion = "";
            this.telefono = "";
            this.dni = 0;
            this.email = "";
        }
    }

    class Empleado : Persona //HERENCIA DE UNA CLASE ABSTRACTA (PERSONA) QUE HEREDA DE UNA INTERFAZ (VACIABLE)
    {
        private int sueldo { get; set; }
        public Empleado()
        {
            this.sueldo = 0;
        }
        public Empleado(int id) : base(id)
        {
            this.sueldo = 1;
        }

        //POLIMORFISMO CON METODOS HEREDADOS DE UNA CLASE ABSTRACTA Y UNA INTERFAZ
        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine("Sueldo " + "\t:\t " + this.sueldo);
        }
        public override void vaciar()
        {
            base.vaciar();
            this.sueldo = 0;
        }
        public override bool isVacio()
        {
            if (base.isVacio() && this.sueldo == 0)
                return true;
            return false;
        }
        //SOBRECARGA EN EL OPERADOR +
        public static Empleado operator +(Empleado empleado, int aumento)
        {
            empleado.sueldo += aumento;
            return empleado;
        }
    }
}

/*

+ Persona(String)
+ vaciar() : void
+ isVacio() : boolean
+ Persona(String, String)
+ Persona(String, String, String, String)
+ getCodigo() : int
+ setCodigo(int) : void
+ getNombre() : String
+ setNombre(String) : void
+ getApellido() : String
+ setApellido(String) : void
+ getDireccion() : String
+ setDireccion(String) : void
+ getPartido() : Partido
+ setPartido(Partido) : void
+ getProvincia() : Provincia
+ setProvincia(Provincia) : void
+ getTelefono() : String
+ setTelefono(String) : void
+ getDni() : String
+ setDni(String) : void
+ getEmail() : String
+ setEmail(String) : void
+ equals(Object) : boolean
+ hashcode() : int
*/