
using System;
using System.Collections;
namespace proyecto
{
	class Program	{
		
					public static void Main(string[] args)
								
								{
						//creacion empresa y grupos
						Empresa emp;
						emp = new Empresa();
						
						Grupo uno = new Grupo();
						Grupo dos = new Grupo();
						Grupo tres = new Grupo();
						Grupo cuatro = new Grupo();
						Grupo cinco = new Grupo();
						Grupo seis = new Grupo();
						Grupo siete = new Grupo();
						Grupo ocho = new Grupo();
	
						uno.NumeroGrupo = 1;
						dos.NumeroGrupo = 2;
						tres.NumeroGrupo = 3;
						cuatro.NumeroGrupo = 4;
						cinco.NumeroGrupo = 5;
						seis.NumeroGrupo = 6;
						siete.NumeroGrupo = 7;
						ocho.NumeroGrupo = 8;
						
						emp.agregarGrupo(uno);
						emp.agregarGrupo(dos);
						emp.agregarGrupo(tres);
						emp.agregarGrupo(cuatro);
						emp.agregarGrupo(cinco);
						emp.agregarGrupo(seis);
						emp.agregarGrupo(siete);
						emp.agregarGrupo(ocho);	
						

						
						//menu

						bool bandera = false;
						int valor = 0;
						
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
															Console.WriteLine("Presione una tecla para continuar...");
															Console.ReadKey();
															break;
													case "2":
															eliminarObrero(emp);
															Console.WriteLine("Presione una tecla para continuar...");
															Console.ReadKey();
															break;
													case "3":
															verObreros(emp);
															Console.WriteLine("Presione una tecla para continuar...");
															Console.ReadKey();
															break;
													case "4":
															verObras(emp);
															Console.WriteLine("Presione una tecla para continuar...");
															Console.ReadKey();
															break;
													case "5":
															valor = valor + 1;
															agregarObra (emp, valor);
															Console.WriteLine("Presione una tecla para continuar...");
															Console.ReadKey();
															break;
													case "6":
															modificarAvance(emp);
															Console.WriteLine("Presione una tecla para continuar...");
															Console.ReadKey();
															break;
													case "7":
															verObrasFinalizadas(emp);
															Console.WriteLine("Presione una tecla para continuar...");
															Console.ReadKey();
															break;
													case "8": 	
															bandera = true;
															Console.WriteLine("Saliendo del programa...");
															Console.ReadKey();
															break;
														default:
															Console.WriteLine("No se ingreso ninguna opcion valida, intente nuevamente...");
															Console.ReadKey();
															break;
					}
						
			}
		}
					//funcion para agregar un nuevo obrero a la empresa
					
					public static void agregarObrero (Empresa emp){
						string nombre, apellido, cargo;
 						int dni, legajo, codigoGrupo;
 						Obrero obr;
 						Console.WriteLine("Ingrese el nombre del obrero:");
 						nombre = Console.ReadLine();
 						Console.WriteLine("Ingrese el apellido del obrero:");
 						apellido = Console.ReadLine();
 						Console.WriteLine("Ingrese el cargo del obrero:");
 						cargo = Console.ReadLine();
 						Console.WriteLine("Ingrese el dni del obrero:");
 						dni = int.Parse(Console.ReadLine());
 						Console.WriteLine("Ingrese el numero de legajo del obrero:");
 						legajo = int.Parse(Console.ReadLine());
 						Console.WriteLine ("Ingrese el numero de grupo (del 1 al 8)al que se desea agregar al obrero:");
 						codigoGrupo = int.Parse(Console.ReadLine());
 						obr = new Obrero (nombre, apellido, cargo, dni, legajo, codigoGrupo);
 						
 						bool existeGrupo = false;
 						
 						foreach(Grupo grp in emp.gruposIntegrados()){
 							if (grp.NumeroGrupo == codigoGrupo){
 								existeGrupo = true;
 								grp.agregarObrero(obr);
 								Console.WriteLine("El obrero se agrego con exito");
 								break;
 							}
 						}
 						if (existeGrupo == false){
 							Console.WriteLine("El grupo ingresado no existe, intente nuevamente...");
 						}
		}
					
					//funcion para eliminar un obrero de la empresa
					
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

					}
					
					//funcion para ver a todos los obreros de la empresa
					
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

			}
					//funcion para ver el total de obras en progreso de la empresa
					
					public static void verObras (Empresa emp){
						for (int i = 0; i < emp.cantidadObras(); i++){
							Obra proyec = emp.verObra(i);
							Console.WriteLine("------------------------------------------");
							Console.WriteLine("Nombre propietario: " + proyec.NombrePropietario);
							Console.WriteLine("Dni del propietario: " + proyec.DniPropietario);
							Console.WriteLine("codigo interno: " + proyec.CodigoInterno);
							Console.WriteLine("Tipo de obra: " + proyec.TipoDeObra);
							Console.WriteLine("Tiempo estimado: " + proyec.TiempoEstimado + " dias");
							Console.WriteLine("Estado de avance: " + proyec.Avance + "%");
							Console.WriteLine("Grupo trabajando: " + proyec.GruposTrabajando);
							Console.WriteLine("Costo: " + proyec.Costo);
							Console.WriteLine("------------------------------------------");							
						}

				}
					//funcion para agregar una nueva obra y asignarle automaticamente un grupo, si no hay grupos disponibles se levanta una excepcion
					
					public static void agregarObra (Empresa emp, int val){
						string propietario, tipo_Obra, tiempo;
						int dni_Propietario, costoObra, codigoInterno, grupotrabajando;
						grupotrabajando = 0;
						codigoInterno = val;
						Obra proyecto;
						Console.WriteLine("Ingrese el nombre del propietario:");
						propietario = Console.ReadLine();
						Console.WriteLine("Ingrese el dni del propietario:");
						dni_Propietario = int.Parse(Console.ReadLine());
						Console.WriteLine("Ingrese el tipo de obra:");
						tipo_Obra = Console.ReadLine();
						Console.WriteLine("Ingrese la cantidad de dias esperados de ejecucion:");
						tiempo = Console.ReadLine();
						Console.WriteLine("Ingrese el costo de obra:");
						costoObra = int.Parse(Console.ReadLine());
						
						proyecto = new Obra ();
						
						proyecto.CodigoInterno = val;
						proyecto.NombrePropietario = propietario;
						proyecto.DniPropietario = dni_Propietario;
						proyecto.GruposTrabajando = grupotrabajando;
						proyecto.Costo = costoObra;
						proyecto.TipoDeObra = tipo_Obra;
						proyecto.TiempoEstimado = tiempo;
						
						int contador = 0;
						
							for (int i = 0; i < emp.cantidadGrupos();i++){
								Grupo grp = emp.verGrupo (i);
								if (grp.CodigoDeObra == 0){
									contador ++;
								}
							}
						try {
							if (contador > 0){
								foreach (Grupo grup in emp.gruposIntegrados()){
									if (grup.CodigoDeObra == 0){
										grup.CodigoDeObra = val;
										proyecto.GruposTrabajando = grup.NumeroGrupo;
										emp.agregarObra(proyecto);
										Console.WriteLine("------------------------------------------");
										Console.WriteLine("Se Agrego la obra con exito");
										Console.WriteLine("------------------------------------------");
										break;
									}
								}
							}
							else
								throw new SinGrupos();
							
						}
						catch(SinGrupos){
							Console.WriteLine ("No hay grupos disponibles");
						}
						                    
				}
					//funcion para modificar el avance, y si supera el 100%, se retira de obras en progreso y se libera su grupo
					
					public static void modificarAvance (Empresa emp){
						int codigo, valorAvance;
						bool existe = false;
						verObras(emp);
						Console.WriteLine("Ingrese el codigo interno de la obra a modificar:");
						codigo = int.Parse(Console.ReadLine());
						
						foreach (Obra proyecto in emp.todasObras()){
							if (codigo == proyecto.CodigoInterno){
								Console.WriteLine("Ingrese el progreso de avance de la obra:");
								valorAvance = int.Parse(Console.ReadLine());
								proyecto.Avance += valorAvance;
								existe = true;
								if (proyecto.Avance >= 100){
									emp.agregarObraFinalizada(proyecto);
									emp.eliminarObra(proyecto);
									foreach (Grupo grp in emp.gruposIntegrados()){
										if (grp.CodigoDeObra == codigo){
											grp.CodigoDeObra = 0;
											break;
										}
									}
									break;
								}
								Console.WriteLine("------------------------------------------");
								Console.WriteLine("Se modifico el estado de obra con exito");
							}
							
						}
						if (existe == false){
							Console.WriteLine("El codigo de obra ingresado no se encuentra, intentelo nuevamente...");
						}
					}
					
					//Funcion que muestra todas las obras finalizadas de la empresa
					
					public static void verObrasFinalizadas (Empresa emp){
						foreach (Obra proyecto in emp.todasObrasFinalizadas()){
						proyecto.Avance = 100;
							Console.WriteLine("------------------------------------------");
							Console.WriteLine("Nombre propietario:" + proyecto.NombrePropietario);
							Console.WriteLine("Dni del propietario:" + proyecto.DniPropietario);
							Console.WriteLine("codigo interno:" + proyecto.CodigoInterno);
							Console.WriteLine("Tipo de obra:" + proyecto.TipoDeObra);
							Console.WriteLine("Tiempo estimado:" + proyecto.TiempoEstimado + " dias");
							Console.WriteLine("Estado de avance:" + proyecto.Avance + "%");
							Console.WriteLine("grupo trabajando:" + proyecto.GruposTrabajando);
							Console.WriteLine("Costo:" + proyecto.Costo);
							Console.WriteLine("------------------------------------------");	
						}
					}
		}
}
