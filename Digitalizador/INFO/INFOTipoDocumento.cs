///////////////////////////////////////////////////////////
//  INFOTipoDocumento.cs
//  Implementation of the Class INFOTipoDocumento
//  Generated by Enterprise Architect
//  Created on:      06-ago-2010 22:24:34
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Collections;

namespace SIGPA.INFO {
	public class INFOTipoDocumento {

		private double idtipodocumento;
		private string nometipodocumento;
		private List<INFODocumento> objDocumento;

		public INFOTipoDocumento(){

		}

		~INFOTipoDocumento(){

		}

		public virtual void Dispose(){

		}

		public double IdTipoDocumento{
			get{
				return idtipodocumento;
			}
			set{
				idtipodocumento = value;
			}
		}

		public string NomeTipoDocumento{
			get{
				return nometipodocumento;
			}
			set{
				nometipodocumento = value;
			}
		}

		public List<INFODocumento> ObjDocumento{
			get{
				return objDocumento;
			}
			set{
				objDocumento = value;
			}
		}

	}//end INFOTipoDocumento

}//end namespace INFO