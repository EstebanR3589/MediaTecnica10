/******************************************************************************
autor: cesar esteban benites rodriguez
fecha:23/05/2024
DESCRIPCION: un docente requiere de un sistema de notas donde recibe
4 calificaciones generando un promedio y luego determinado si gana o pierde
si su promedio es menor a 3 pierde
si es mayor gana
si tiene un promedio mayor a 4.5 emitir mansaje:
"felicidades, te has ganado la beca"
**********************************************************************/
using System;

class Program{
    static void Main(){
   
    double nota1;
    double nota2;
    double nota3;
    double nota4;
   
        Console.WriteLine("ingrese las nota 1 ");
        nota1 = Double.Parse(Console.ReadLine());
       
        Console.WriteLine("ingrese las nota 2 ");
        nota2 = Double.Parse(Console.ReadLine());
       
        Console.WriteLine("ingrese las nnota 3 ");
        nota3 = Double.Parse(Console.ReadLine());
       
        Console.WriteLine("ingrese las nota 4 ");
        nota4 = Double.Parse(Console.ReadLine());
     
           if(nota1>=3.0){
               Console.WriteLine("felicidades has aprobado la materia con: " + (nota1 + nota2 +  nota3
               + nota4) / 4 );
           }
         if(nota1<=2.9){
              Console.WriteLine("lo siento has perdido la materia con: " + (nota1 + nota2 +nota3
               + nota4) / 4 );
         }
       
         if(nota1>=4.5){
               Console.WriteLine("felicidades has ganado la beca con: " + (nota1 + nota2 +nota3
               + nota4) / 4 );
           }
    }
}
