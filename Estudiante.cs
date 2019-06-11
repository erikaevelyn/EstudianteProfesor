using System;
namespace EstudianteProfesor{

/*●	
La clase "Estudiante" tendrá un método público "GoToClasses", que escribirá en la pantalla
 "Voy a clase." */
 /*
● El estudiante tendrá un método público "ShowAge" que escribirá en la pantalla 
"Mi edad es: 20 años" (o el número correspondiente). */
    public class Estudiante : Persona {

        public void GoToClasses(){
            Console.WriteLine("Voy a clases.");
        }

        public void ShowAge(){
            Console.WriteLine($"Mi edad es: {base.edad} años.");
        }

    }
}