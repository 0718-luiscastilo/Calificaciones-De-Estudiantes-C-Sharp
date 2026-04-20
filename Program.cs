using System;

public class Program {
    public static void Main(string[] args) {
        int suma =0;
        double promedioGeneral =0;
        int aprobados =0;
        int reprobados =0;
        Console.WriteLine("Ingrese la Cantidad de Estudiantes: ");
        int cantidadEstudiantes = int.Parse(Console.ReadLine());

        string[] nombres = new string[cantidadEstudiantes];
        int [] arrayCalificacion  = new int[cantidadEstudiantes];


        for(int i=0; i<cantidadEstudiantes;i++){
            Console.WriteLine("Estudiante " + (i+1) + ":");
            Console.WriteLine("Nombre: ");
            string nombreEstudiante = Console.ReadLine();
            Console.WriteLine("Calificacion: ");
            int calificacion = int.Parse(Console.ReadLine());
            nombres[i] = nombreEstudiante;
            arrayCalificacion [i] = calificacion;

        }
        Console.WriteLine("-------------------------");
        for(int j =0; j<cantidadEstudiantes;j++){
            Console.WriteLine(nombres[j] + " - " + arryCalificacion[j]);
        }
        for(int i =0; i<cantidadEstudiantes;i++){    
            suma = suma +arrayCalificacion [i];
            if(arrayCalificacion [i] >= 70){
                aprobados++;
            }
        }
        reprobados = arrayCalificacion .Length - aprobados;
        promedioGeneral = (double)suma / arryCalificacion.Length;

        Console.WriteLine("-------------------------");
        Console.WriteLine("Promedio general: " + promedioGeneral);
        Console.WriteLine("Aprobados: " + aprovados);
        Console.WriteLine("Reprobados: " + reprovados);

    }
}