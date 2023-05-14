
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
												case "1": 	agregarObrero(emp);
															break;
													case "2":
															eliminarObrero(emp);
															break;
													case "3":
															verObreros(emp);
															break;
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
					public static void agregarObrero (Empresa emp){
						string nombre, apellido, cargo;
 						int dni, legajo, codigoGrupo;
 						Obrero obr;
 						Console.WriteLine("Ingrese el nombre del obrero");
 						nombre = Console.ReadLine();
 						Console.WriteLine("Ingrese el apellido del obrero");
 						apellido = Console.ReadLine();
 						Console.WriteLine("Ingrese el cargo del obrero");
 						cargo = Console.ReadLine();
 						Console.WriteLine("Ingrese el dni del obrero");
 						dni = int.Parse(Console.ReadLine());
 						Console.WriteLine("Ingrese el numero de legajo del obrero");
 						legajo = int.Parse(Console.ReadLine());
 						Console.WriteLine ("Ingrese el numero de grupo al que se desea agregar al obrero");
 						codigoGrupo = int.Parse(Console.ReadLine());
 						obr = new Obrero (nombre, apellido, cargo, dni, legajo, codigoGrupo);
 						
 						bool existeGrupo = false;
 						
 						foreach(Grupo grp in emp.gruposIntegrados()){
 							if (grp.NumeroGrupo == codigoGrupo){
 								existeGrupo = true;
 								grp.agregarObrero(obr);
 								break;
 							}
 						}
 						if (existeGrupo == false){
 							Grupo grup = new Grupo();
 							grup.NumeroGrupo = codigoGrupo;
 							grup.agregarObrero(obr);
 							emp.agregarGrupo(grup);
 						}
 						Console.WriteLine("El obrero se agrego con exito");
 						Console.WriteLine("Presione una tecla para continuar...");
 						Console.ReadKey();
		}
					
					public static void eliminarObrero (Empresa emp){
						int dni;
						bool existe = false;
						Console.WriteLine("Ingrese el dni del obrero a eliminar.");
						dni = int.Parse(Console.ReadLine());
						for (int i = 0; i < emp.cantidadGrupos();i++){
							Grupo grp = emp.verGrupo(i);
							foreach (Obrero obr in grp.miembrosGrupos()) {
								if(obr.Dni == dni){
									existe = true;
									grp.eliminarObrero(obr);
									Console.WriteLine("Se elimino el obrero con exito");
									break;
								}
							}
						}
						if (existe == false){
							Console.WriteLine("El dni ingresado no pertenece a ningun obrero, intentelo nuevamente...");
						}
						Console.WriteLine("Presione una tecla para continuar...");
						Console.ReadKey();
					}
					
					public static void verObreros (Empresa emp){
						for (int i = 0; i < emp.cantidadGrupos();i++){
							Grupo grp = emp.verGrupo(i);
							foreach (Obrero obr in grp.miembrosGrupos()) {
								Console.WriteLine("------------------------------------------");
								Console.WriteLine("Nombre:" + obr.Nombre);
								Console.WriteLine("Apellido:" + obr.Nombre);
								Console.WriteLine("Cargo:" + obr.Cargo);
								Console.WriteLine("Dni:" + obr.Dni);
								Console.WriteLine("Legajo:" + obr.Legajo);
								Console.WriteLine("Grupo:" + obr.CodigoGrupo);
								Console.WriteLine("------------------------------------------");
					}
				}
					Console.WriteLine("Presione una tecla para continuar...");
			}
	}
}
