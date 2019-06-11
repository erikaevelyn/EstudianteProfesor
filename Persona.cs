using System;
namespace EstudianteProfesor{

/*●	La persona de clase debe tener un método "SetAge (int n)" que indicará el
valor de su edad (por ejemplo, 20 años). */


    public class Persona{

        public int edad;

        public void setAge(int n){
            edad = n;
        }

        public void Saludar(){
            Console.WriteLine("Hola!");
        }

    }
}