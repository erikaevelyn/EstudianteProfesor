using System;
/*Debes crear otra clase de prueba llamada "StudentAndTeacherTest" que contendrá "Main" y:
○ Crea una persona y hazla decir hola
○ Crea un estudiante, establece su edad en 21, dile que salude y muestre su edad
○ Cree un maestro, de 30 años, pídale que lo salude y luego que explique. */

namespace EstudianteProfesor{

    public class EstudianteProfesorTest{

        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Saludar();

            Estudiante estudiante = new Estudiante();
            estudiante.setAge(21);
            estudiante.Saludar();
            estudiante.ShowAge();

            Profesor profe = new Profesor();
            profe.setAge(30);
            profe.Saludar();
            profe.Explicar();

        }

    }
}