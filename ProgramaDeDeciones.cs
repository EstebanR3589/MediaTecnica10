/******************************************************************************
NOMBRE: CESAR ESTEBAN BENITES RODRIGUEZ
FECHA: 22/05/2024
DESCRIPCION: programa con desiciones
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      // variables
     bool sexoMasculino;
      //capturar la informacion del usuario
      Console.Write("digite verdadero si es hombre: ");
     sexoMasculino = Convert.ToBoolean (Console.ReadLine());
      // validaciones
      if (sexoMasculino == true )
      { 
     Console.WriteLine("felizidades; es hombre"); 
       }
      else{ 
           Console.WriteLine("felicidades,es mujer "); 
      }
      Console.WriteLine("fin de la ejeccion ");
} 
}
