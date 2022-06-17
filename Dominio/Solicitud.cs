using Dominio.Common;

namespace Dominio
{
	public class Solicitud : BaseDomainModel
	{
		public int Id { get; set; }
		public int Identificacion { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public int Edad { get; set; }
		public string Casa { get; set; }
	}
}