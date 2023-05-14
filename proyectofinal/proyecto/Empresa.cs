
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
		
		public Obra verObra (int valor){
			return (Obra)this.listaObras[valor];
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
		public Grupo verGrupo (int valor){
			return (Grupo)this.listaGrupos[valor];
		}
	}
}
