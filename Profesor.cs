using System;
namespace EstudianteProfesor{

/*
● La clase "Profesor" tendrá un método público "Explicar", que se mostrará en la pantalla 
"Comienza la explicación".
Además, tendrá un atributo privado "sujeto", una cadena. */
/*Para que es el subject?  El metodo saludar lo agregue */
    public class Profesor : Persona {

        private string subject;

        public void Explicar(){
            Console.WriteLine("Comienza la explicacion");
        }

    }
}