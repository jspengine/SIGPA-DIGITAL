///////////////////////////////////////////////////////////
//  INFOUsuario.cs
//  Implementation of the Class INFOUsuario
//  Generated by Enterprise Architect
//  Created on:      06-ago-2010 22:24:34
///////////////////////////////////////////////////////////




namespace WSOpusDigitalizacao.INFO
{
	public class wsINFOUsuario {

		private string nomeusuario;
		private string perfilusuario;

		public wsINFOUsuario(){

		}

		~wsINFOUsuario(){

		}

		public virtual void Dispose(){

		}

		public string NomeUsuario{
			get{
				return nomeusuario;
			}
			set{
				nomeusuario = value;
			}
		}

		public string PerfilUsuario{
			get{
				return perfilusuario;
			}
			set{
				perfilusuario = value;
			}
		}

	}//end INFOUsuario

}//end namespace INFO