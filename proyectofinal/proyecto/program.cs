
using System;

namespace proyecto
{
	class Program	{
		
					public static void Main(string[] args)
								
								{
						
						Empresa emp;
						bool bandera = false;
						emp = new Empresa();
						while (bandera == false )
									{
						Console.WriteLine("--------------------------------------------------------------");
						Console.WriteLine("Elija una opción: ");
						Console.WriteLine("1-Contratar un obrero");
						Console.WriteLine("2-Eliminar un obrero");
						Console.WriteLine("3-Listado de obreros");
						Console.WriteLine("4-Listado de obras");
						Console.WriteLine("5-Agregar una nueva obra y asignarle un grupo de obreros");
						Console.WriteLine("6-Modificar el estado de avance de una obra");
						Console.WriteLine("7-Listado de obras finalizadas");
						Console.WriteLine("8-Para salir del programa");
						Console.WriteLine("--------------------------------------------------------------");
						string opcion = Console.ReadLine();
										switch (opcion)
												{
													case "1":
																break;
													case "2":
													case "3":
													case "4":
													case "5":
													case "6":
													case "7":
													case "8": 	bandera = true;
																Console.WriteLine("Saliendo del programa...");
																Console.ReadKey(true);
																break;
					}
						
			}
		}
	}
}
