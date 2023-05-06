/*
 * Creado por SharpDevelop.
 * Usuario: ianga
 * Fecha: 04/05/2023
 * Hora: 10:48
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
namespace proyecto
{
	public class Grupo
	{
		//atributos
		private ArrayList listaObreros;
		private int codigoDeObra;
		
		// constructor
		public Grupo()
		{
			this.listaObreros = new ArrayList();
		}

		// metodos
		public void agregarObrero (Obrero obr){
			listaObreros.Add(obr);
		}
		public void eliminarObrero (Obrero obr){
			listaObreros.Remove(obr);
		}
		
		public bool existeObrero (Obrero obr){
			return listaObreros.Contains(obr);
		}
		
		public ArrayList miembrosGrupos(){
			return listaObreros;
			}
		
		public int cantidadObreros (){
			return listaObreros.Count;
		}
		public int CodigoDeObra{
			set { codigoDeObra = value;
		}
			get {
				return codigoDeObra;}
				}
		}	
	}
