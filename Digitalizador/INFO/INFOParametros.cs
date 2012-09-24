///////////////////////////////////////////////////////////
//  INFOParametros.cs
//  Implementation of the Class INFOParametros
//  Generated by Enterprise Architect
//  Created on:      06-ago-2010 22:24:34
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Collections;


namespace SIGPA.INFO {
	public class INFOParametros {

		private double idparametros;
		private string nomediretoriodocumentos;
		private double numerocontador;

		public INFOParametros(){

		}

		~INFOParametros(){

		}

		public virtual void Dispose(){

		}

		public double IdParametros{
			get{
				return idparametros;
			}
			set{
				idparametros = value;
			}
		}

		public string NomeDiretorioDocumentos{
			get{
				return nomediretoriodocumentos;
			}
			set{
				nomediretoriodocumentos = value;
			}
		}

		public double NumeroContador{
			get{
				return numerocontador;
			}
			set{
				numerocontador = value;
			}
		}

	}//end INFOParametros

}//end namespace INFO