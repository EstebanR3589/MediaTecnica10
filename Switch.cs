using System;
class HelloWorld {
  static void Main() {
      Console.WriteLine("digite la nota que a obtenido (1-5), luego enter");
      Console.WriteLine("opcion");
    int opcion = Int32.Parse(Console.ReadLine());
switch (opcion) 
{
  case 1:
    Console.WriteLine("pierde");
    break;
  case 2:
    Console.WriteLine("pierde");
    break;
  case 3:
    Console.WriteLine("gana");
    break;
  case 4:
    Console.WriteLine("alto");
    break;
  case 5:
    Console.WriteLine("superior");
    break;
 default:

  Console.WriteLine("salir del el programa ");
  break;
}
  }
}
