/*
 * Creado por SharpDevelop.
 * Usuario: ianga
 * Fecha: 04/05/2023
 * Hora: 15:53
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
namespace proyecto
{
	public class Empresa
	{	
		// atributos
		private ArrayList listaObras;
		private ArrayList listaGrupos;
		
		//constructor
		public Empresa()
		{
			listaObras = new ArrayList();
			listaGrupos = new ArrayList();
		}
		
		// metodos basicos relacionados con obras
		
		public void agregarObra (Obra proyecto){
			listaObras.Add(proyecto);
		}
		
		public void eliminarObra (Obra proyecto){
			listaObras.Remove(proyecto);
		}
		
		public int cantidadObras (){
			return listaObras.Count;
		}
		
		public ArrayList todasObras (){
			return listaObras;
		}
		
		public bool existeObra (Obra proyecto){
			return listaObras.Contains(proyecto);
		}
	
		//metodos basicos relacionados con grupos
		
		public void agregarGrupo (Grupo equip){
			listaGrupos.Add(equip);
		}
		
		public void eliminarGrupo (Grupo equip){
			listaGrupos.Remove(equip);
		}
		
		public bool existeGrupo (Grupo equip){
			return listaGrupos.Contains(equip);
		}
		
		public int cantidadGrupos (){
			return listaGrupos.Count;
		}
		
		public ArrayList gruposIntegrados (){
			return listaGrupos;
		}
	}
}
